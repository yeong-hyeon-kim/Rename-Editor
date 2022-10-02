using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rename_Editor
{
    public partial class Editor : Form
    {
        FolderBrowserDialog FbDialog = new FolderBrowserDialog();

        public Editor()
        {
            InitializeComponent();
        }

        private void BtnOpenCopyPath_Click(object sender, EventArgs e)
        {
            CreateCopyPathList();
        }
        private void BtnCopyNameExecution_Click(object sender, EventArgs e)
        {
            CopyFileName();
        }
        private void BtnMergeFolder_Click(object sender, EventArgs e)
        {
            MergeFolder();
        }
        private void BtnForceDelete_Click(object sender, EventArgs e)
        {
            DeleteForceFile();
        }
        private void BtnRenameExecution_Click(object sender, EventArgs e)
        {
            EditFileName();
        }
        private void BtnOpenMergeFolder_Click(object sender, EventArgs e)
        {
            string PathString = TextParentFolderPath.Text;

            OpenDialog(out PathString);
            TextParentFolderPath.Text = PathString;
        }
        private void BtnOpenRenamePath_Click(object sender, EventArgs e)
        {
            string PathString = txt_folder_pt.Text;

            OpenDialog(out PathString);
            txt_folder_pt.Text = PathString;
        }

        /// <summary>
        /// 다이얼로그 열기
        /// </summary>
        /// <param name="sPath"></param>
        private void OpenDialog(out string sPath)
        {
            string SelectedPath = string.Empty;

            try
            {
                FbDialog.ShowDialog();

                if (!string.IsNullOrEmpty(FbDialog.SelectedPath))
                {
                    SelectedPath = FbDialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sPath = SelectedPath;
        }

        /// <summary>
        /// 파일 이름 수정
        /// </summary>
        private void EditFileName()
        {
            try
            {
                DirectoryInfo Dir_info = new DirectoryInfo(txt_folder_pt.Text);

                progbar_status.Minimum = 0;
                progbar_status.Value = 0;
                progbar_status.Maximum = Dir_info.GetFiles().Count();

                foreach (var files in Dir_info.GetFiles())
                {
                    progbar_status.Value += 1;

                    if (rbtn_replace_mode.Checked)
                    {
                        if (rbtnStringReplace.Checked)
                        {
                            // 자동 교체 모드 : 찾을려는 문자열을 대체 문자열로 교체합니다.
                            if (files.Name.Contains(txt_find_string.Text))
                            {
                                try
                                {
                                    string ReplacePath = files.Name.Replace(txt_find_string.Text, txt_replace_string.Text);
                                    File.Move(files.FullName, files.DirectoryName + "\\" + ReplacePath);
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            string ReplaceString = string.Empty;
                            ReplaceString = files.Name.Substring(Int32.Parse(txt_start_index.Text), Int32.Parse(txt_end_index.Text));

                            // 자동 교체 모드 : 특정 문자열 인덱스를 범위를 직접 조절하여 교체
                            File.Move(files.FullName, files.DirectoryName + "\\" + files.Name.Replace(ReplaceString, ""));
                        }
                    }
                    else if (rbtn_index_mode.Checked)
                    {
                        // 인덱스 모드 : 지정한 문자열의 범위의 문자열을 파일명으로 수정합니다.
                        File.Move(files.FullName, files.DirectoryName + files.Name.Substring(Int32.Parse(txt_start_index.Text), Int32.Parse(txt_end_index.Text)));
                    }
                    else if (rbtn_remove_integer_mode.Checked)
                    {
                        // 숫자 제거 모드 : 파일명에 포함된 숫자를 제거합니다.
                        File.Move(files.FullName, files.DirectoryName + Regex.Replace(files.Name.Substring(0, files.Name.Length - 4), @"\d", "") + files.Extension);
                    }
                    else if (rbtn_insert_mode.Checked)
                    {
                        // 삽입 모드 : 기존 파일명에 삽입할 문자열을 붙여 줍니다.
                        File.Move(files.FullName, files.DirectoryName + files.Name + txt_insert_string.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 원본, 대상 파일 경로 리스트 작성
        /// </summary>
        private void CreateCopyPathList()
        {
            try
            {
                FbDialog.ShowDialog();

                if (!string.IsNullOrEmpty(FbDialog.SelectedPath))
                {
                    text_Folder_Path.Text = FbDialog.SelectedPath;

                    DirectoryInfo DirInfo = new DirectoryInfo(text_Folder_Path.Text);
                    List<string> ExtensionList = new List<string>();

                    lb_FlieList.Items.Clear();

                    foreach (var Files in DirInfo.GetFiles())
                    {
                        lb_FlieList.Items.Add(Files);
                        ExtensionList.Add(Files.Extension.ToString());
                    }

                    ExtensionList = ExtensionList.Distinct<string>().ToList();

                    cmb_Source_Extension.Items.Clear();
                    cmb_Target_Extension.Items.Clear();

                    foreach (var item in ExtensionList)
                    {
                        cmb_Source_Extension.Items.Add(item);
                        cmb_Target_Extension.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 원본, 대상 파일 이름 복사
        /// </summary>
        private void CopyFileName()
        {
            try
            {
                DirectoryInfo DirInfo = new DirectoryInfo(text_Folder_Path.Text);
                Dictionary<string, string> FileMap = new Dictionary<string, string>();

                List<string> SourceList = new List<string>();
                List<string> TargetList = new List<string>();

                progbar_status.Minimum = 0;
                progbar_status.Value = 0;

                int ListIndex = 0;

                foreach (var Files in DirInfo.GetFiles())
                {
                    if (cmb_Source_Extension.SelectedItem.ToString() == Files.Extension)
                    {
                        SourceList.Add(Files.Name);
                    }

                    if (cmb_Target_Extension.SelectedItem.ToString() == Files.Extension)
                    {
                        TargetList.Add(Files.Name);
                    }
                }

                foreach (var item in SourceList)
                {
                    FileMap.Add(item, TargetList[ListIndex]);
                    ListIndex += 1;
                }

                progbar_status.Maximum = SourceList.Count();

                foreach (var item in SourceList)
                {
                    var SourcePath = @$"{text_Folder_Path.Text}\{FileMap[item.ToString()]}";
                    var TagetPath = @$"{text_Folder_Path.Text}\{item.Replace(cmb_Source_Extension.SelectedItem.ToString(), cmb_Target_Extension.SelectedItem.ToString())}";

                    File.Move(SourcePath, TagetPath);

                    progbar_status.Value += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 폴더 병합
        /// </summary>
        private void MergeFolder()
        {
            try
            {
                ListMerge.Items.Clear();

                // 메인 디렉토리
                DirectoryInfo DirInfo = new DirectoryInfo(TextParentFolderPath.Text);
                // 하위(파일 분류 폴더) 디렉토리
                DirectoryInfo[] SubDirList = DirInfo.GetDirectories();

                Parallel.ForEach(DirInfo.GetDirectories(), PrantFolder =>
                {
                    DirectoryInfo SubDirInfo = new(PrantFolder.FullName);
                    // 카테고리, 챕터 별 폴더
                    Parallel.ForEach(SubDirInfo.GetDirectories(), Folders =>
                    {
                        DirectoryInfo SubSubDirInfo = new(Folders.FullName);

                        // 카테고리, 챕터 내 파일
                        Parallel.ForEach(SubSubDirInfo.GetFiles(), Files =>
                        {
                            Debug.WriteLine(Files.FullName);
                            // 파일 분류 폴더로 이동
                            File.Move(Files.FullName, $"{Files.DirectoryName}_{Files.Name}");
                        });

                        // 빈 폴더 삭제 여부
                        if (ChkDeleteBlankFolder.Checked)
                        {
                            // 빈 폴더이면 삭제
                            if (SubSubDirInfo.GetFiles().Length == 0)
                            {
                                SubSubDirInfo.Delete();
                            }
                        }
                    });
                });

                Debug.WriteLine("Work End!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 사용 중인 파일 강제 삭제
        /// </summary>
        private void DeleteForceFile()
        {
            DialogResult dialogResult = MessageBox.Show("삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string FilePath = TextForceDeletePath.Text;

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(FilePath))
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        FileInfo f = new FileInfo(FilePath);
                        f.Delete();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}