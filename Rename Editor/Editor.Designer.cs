
namespace Rename_Editor
{
    partial class Editor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_folder_pt = new System.Windows.Forms.TextBox();
            this.lbl_folder_pt = new System.Windows.Forms.Label();
            this.BtnOpenRenamePath = new System.Windows.Forms.Button();
            this.lbl_find_string = new System.Windows.Forms.Label();
            this.txt_find_string = new System.Windows.Forms.TextBox();
            this.txt_replace_string = new System.Windows.Forms.TextBox();
            this.lbl_replace_string = new System.Windows.Forms.Label();
            this.BtnRenameExecution = new System.Windows.Forms.Button();
            this.progbar_status = new System.Windows.Forms.ProgressBar();
            this.lbl_status_cnt = new System.Windows.Forms.Label();
            this.txt_start_index = new System.Windows.Forms.TextBox();
            this.txt_end_index = new System.Windows.Forms.TextBox();
            this.lbl_start_index = new System.Windows.Forms.Label();
            this.lbl_end_index = new System.Windows.Forms.Label();
            this.rbtn_replace_mode = new System.Windows.Forms.RadioButton();
            this.rbtn_index_mode = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_insert_mode = new System.Windows.Forms.RadioButton();
            this.rbtn_remove_integer_mode = new System.Windows.Forms.RadioButton();
            this.lbl_insert_string = new System.Windows.Forms.Label();
            this.txt_insert_string = new System.Windows.Forms.TextBox();
            this.Tab_File_Rename = new System.Windows.Forms.TabControl();
            this.Tab_FileName_Edit = new System.Windows.Forms.TabPage();
            this.rbtnIndexReplace = new System.Windows.Forms.RadioButton();
            this.rbtnStringReplace = new System.Windows.Forms.RadioButton();
            this.Tab_FileName_Copy = new System.Windows.Forms.TabPage();
            this.lbl_File_List = new System.Windows.Forms.Label();
            this.lb_FlieList = new System.Windows.Forms.ListBox();
            this.btn_Name_Match = new System.Windows.Forms.Button();
            this.cmb_Target_Extension = new System.Windows.Forms.ComboBox();
            this.cmb_Source_Extension = new System.Windows.Forms.ComboBox();
            this.lbl_Target_Extension = new System.Windows.Forms.Label();
            this.lbl_Source_Extension = new System.Windows.Forms.Label();
            this.BtnOpenCopyPath = new System.Windows.Forms.Button();
            this.text_Folder_Path = new System.Windows.Forms.TextBox();
            this.lbl_Folder_Path = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Tab_File_Rename.SuspendLayout();
            this.Tab_FileName_Edit.SuspendLayout();
            this.Tab_FileName_Copy.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_folder_pt
            // 
            this.txt_folder_pt.Location = new System.Drawing.Point(127, 28);
            this.txt_folder_pt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_folder_pt.Name = "txt_folder_pt";
            this.txt_folder_pt.Size = new System.Drawing.Size(752, 27);
            this.txt_folder_pt.TabIndex = 0;
            // 
            // lbl_folder_pt
            // 
            this.lbl_folder_pt.AutoSize = true;
            this.lbl_folder_pt.Location = new System.Drawing.Point(15, 28);
            this.lbl_folder_pt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_folder_pt.Name = "lbl_folder_pt";
            this.lbl_folder_pt.Size = new System.Drawing.Size(74, 20);
            this.lbl_folder_pt.TabIndex = 1;
            this.lbl_folder_pt.Text = "폴더 경로";
            // 
            // BtnOpenRenamePath
            // 
            this.BtnOpenRenamePath.Location = new System.Drawing.Point(888, 28);
            this.BtnOpenRenamePath.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOpenRenamePath.Name = "BtnOpenRenamePath";
            this.BtnOpenRenamePath.Size = new System.Drawing.Size(107, 31);
            this.BtnOpenRenamePath.TabIndex = 2;
            this.BtnOpenRenamePath.Text = "폴더 열기";
            this.BtnOpenRenamePath.UseVisualStyleBackColor = true;
            this.BtnOpenRenamePath.Click += new System.EventHandler(this.BtnOpenRenamePath_Click);
            // 
            // lbl_find_string
            // 
            this.lbl_find_string.AutoSize = true;
            this.lbl_find_string.Location = new System.Drawing.Point(15, 88);
            this.lbl_find_string.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_find_string.Name = "lbl_find_string";
            this.lbl_find_string.Size = new System.Drawing.Size(89, 20);
            this.lbl_find_string.TabIndex = 3;
            this.lbl_find_string.Text = "대상 문자열";
            // 
            // txt_find_string
            // 
            this.txt_find_string.Location = new System.Drawing.Point(127, 89);
            this.txt_find_string.Margin = new System.Windows.Forms.Padding(4);
            this.txt_find_string.Name = "txt_find_string";
            this.txt_find_string.Size = new System.Drawing.Size(214, 27);
            this.txt_find_string.TabIndex = 4;
            // 
            // txt_replace_string
            // 
            this.txt_replace_string.Location = new System.Drawing.Point(455, 85);
            this.txt_replace_string.Margin = new System.Windows.Forms.Padding(4);
            this.txt_replace_string.Name = "txt_replace_string";
            this.txt_replace_string.Size = new System.Drawing.Size(214, 27);
            this.txt_replace_string.TabIndex = 6;
            // 
            // lbl_replace_string
            // 
            this.lbl_replace_string.AutoSize = true;
            this.lbl_replace_string.Location = new System.Drawing.Point(356, 89);
            this.lbl_replace_string.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_replace_string.Name = "lbl_replace_string";
            this.lbl_replace_string.Size = new System.Drawing.Size(89, 20);
            this.lbl_replace_string.TabIndex = 5;
            this.lbl_replace_string.Text = "대체 문자열";
            // 
            // BtnRenameExecution
            // 
            this.BtnRenameExecution.Location = new System.Drawing.Point(888, 71);
            this.BtnRenameExecution.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRenameExecution.Name = "BtnRenameExecution";
            this.BtnRenameExecution.Size = new System.Drawing.Size(107, 31);
            this.BtnRenameExecution.TabIndex = 7;
            this.BtnRenameExecution.Text = "실행";
            this.BtnRenameExecution.UseVisualStyleBackColor = true;
            this.BtnRenameExecution.Click += new System.EventHandler(this.BtnRenameExecution_Click);
            // 
            // progbar_status
            // 
            this.progbar_status.Location = new System.Drawing.Point(24, 455);
            this.progbar_status.Margin = new System.Windows.Forms.Padding(4);
            this.progbar_status.Name = "progbar_status";
            this.progbar_status.Size = new System.Drawing.Size(1012, 32);
            this.progbar_status.TabIndex = 8;
            // 
            // lbl_status_cnt
            // 
            this.lbl_status_cnt.AutoSize = true;
            this.lbl_status_cnt.Location = new System.Drawing.Point(24, 419);
            this.lbl_status_cnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status_cnt.Name = "lbl_status_cnt";
            this.lbl_status_cnt.Size = new System.Drawing.Size(54, 20);
            this.lbl_status_cnt.TabIndex = 9;
            this.lbl_status_cnt.Text = "진행률";
            // 
            // txt_start_index
            // 
            this.txt_start_index.Location = new System.Drawing.Point(127, 141);
            this.txt_start_index.Margin = new System.Windows.Forms.Padding(4);
            this.txt_start_index.Name = "txt_start_index";
            this.txt_start_index.Size = new System.Drawing.Size(214, 27);
            this.txt_start_index.TabIndex = 10;
            // 
            // txt_end_index
            // 
            this.txt_end_index.Location = new System.Drawing.Point(455, 141);
            this.txt_end_index.Margin = new System.Windows.Forms.Padding(4);
            this.txt_end_index.Name = "txt_end_index";
            this.txt_end_index.Size = new System.Drawing.Size(214, 27);
            this.txt_end_index.TabIndex = 11;
            // 
            // lbl_start_index
            // 
            this.lbl_start_index.AutoSize = true;
            this.lbl_start_index.Location = new System.Drawing.Point(15, 141);
            this.lbl_start_index.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_start_index.Name = "lbl_start_index";
            this.lbl_start_index.Size = new System.Drawing.Size(89, 20);
            this.lbl_start_index.TabIndex = 12;
            this.lbl_start_index.Text = "시작 인덱스";
            // 
            // lbl_end_index
            // 
            this.lbl_end_index.AutoSize = true;
            this.lbl_end_index.Location = new System.Drawing.Point(356, 145);
            this.lbl_end_index.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_end_index.Name = "lbl_end_index";
            this.lbl_end_index.Size = new System.Drawing.Size(89, 20);
            this.lbl_end_index.TabIndex = 13;
            this.lbl_end_index.Text = "종료 인덱스";
            // 
            // rbtn_replace_mode
            // 
            this.rbtn_replace_mode.AutoSize = true;
            this.rbtn_replace_mode.Checked = true;
            this.rbtn_replace_mode.Location = new System.Drawing.Point(10, 16);
            this.rbtn_replace_mode.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_replace_mode.Name = "rbtn_replace_mode";
            this.rbtn_replace_mode.Size = new System.Drawing.Size(128, 24);
            this.rbtn_replace_mode.TabIndex = 15;
            this.rbtn_replace_mode.TabStop = true;
            this.rbtn_replace_mode.Text = "Replace Mode";
            this.rbtn_replace_mode.UseVisualStyleBackColor = true;
            // 
            // rbtn_index_mode
            // 
            this.rbtn_index_mode.AutoSize = true;
            this.rbtn_index_mode.Location = new System.Drawing.Point(148, 16);
            this.rbtn_index_mode.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_index_mode.Name = "rbtn_index_mode";
            this.rbtn_index_mode.Size = new System.Drawing.Size(112, 24);
            this.rbtn_index_mode.TabIndex = 16;
            this.rbtn_index_mode.TabStop = true;
            this.rbtn_index_mode.Text = "Index Mode";
            this.rbtn_index_mode.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_insert_mode);
            this.panel1.Controls.Add(this.rbtn_remove_integer_mode);
            this.panel1.Controls.Add(this.rbtn_replace_mode);
            this.panel1.Controls.Add(this.rbtn_index_mode);
            this.panel1.Location = new System.Drawing.Point(15, 276);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 57);
            this.panel1.TabIndex = 17;
            // 
            // rbtn_insert_mode
            // 
            this.rbtn_insert_mode.AutoSize = true;
            this.rbtn_insert_mode.Location = new System.Drawing.Point(463, 16);
            this.rbtn_insert_mode.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_insert_mode.Name = "rbtn_insert_mode";
            this.rbtn_insert_mode.Size = new System.Drawing.Size(112, 24);
            this.rbtn_insert_mode.TabIndex = 18;
            this.rbtn_insert_mode.TabStop = true;
            this.rbtn_insert_mode.Text = "Insert Mode";
            this.rbtn_insert_mode.UseVisualStyleBackColor = true;
            // 
            // rbtn_remove_integer_mode
            // 
            this.rbtn_remove_integer_mode.AutoSize = true;
            this.rbtn_remove_integer_mode.Location = new System.Drawing.Point(270, 16);
            this.rbtn_remove_integer_mode.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_remove_integer_mode.Name = "rbtn_remove_integer_mode";
            this.rbtn_remove_integer_mode.Size = new System.Drawing.Size(182, 24);
            this.rbtn_remove_integer_mode.TabIndex = 17;
            this.rbtn_remove_integer_mode.TabStop = true;
            this.rbtn_remove_integer_mode.Text = "Remove Integer Mode";
            this.rbtn_remove_integer_mode.UseVisualStyleBackColor = true;
            // 
            // lbl_insert_string
            // 
            this.lbl_insert_string.AutoSize = true;
            this.lbl_insert_string.Location = new System.Drawing.Point(15, 200);
            this.lbl_insert_string.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_insert_string.Name = "lbl_insert_string";
            this.lbl_insert_string.Size = new System.Drawing.Size(89, 20);
            this.lbl_insert_string.TabIndex = 19;
            this.lbl_insert_string.Text = "삽입 인덱스";
            // 
            // txt_insert_string
            // 
            this.txt_insert_string.Location = new System.Drawing.Point(127, 196);
            this.txt_insert_string.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insert_string.Name = "txt_insert_string";
            this.txt_insert_string.Size = new System.Drawing.Size(214, 27);
            this.txt_insert_string.TabIndex = 18;
            // 
            // Tab_File_Rename
            // 
            this.Tab_File_Rename.Controls.Add(this.Tab_FileName_Edit);
            this.Tab_File_Rename.Controls.Add(this.Tab_FileName_Copy);
            this.Tab_File_Rename.Location = new System.Drawing.Point(19, 11);
            this.Tab_File_Rename.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_File_Rename.Name = "Tab_File_Rename";
            this.Tab_File_Rename.SelectedIndex = 0;
            this.Tab_File_Rename.Size = new System.Drawing.Size(1022, 388);
            this.Tab_File_Rename.TabIndex = 20;
            // 
            // Tab_FileName_Edit
            // 
            this.Tab_FileName_Edit.Controls.Add(this.rbtnIndexReplace);
            this.Tab_FileName_Edit.Controls.Add(this.rbtnStringReplace);
            this.Tab_FileName_Edit.Controls.Add(this.lbl_end_index);
            this.Tab_FileName_Edit.Controls.Add(this.lbl_insert_string);
            this.Tab_FileName_Edit.Controls.Add(this.BtnOpenRenamePath);
            this.Tab_FileName_Edit.Controls.Add(this.BtnRenameExecution);
            this.Tab_FileName_Edit.Controls.Add(this.txt_end_index);
            this.Tab_FileName_Edit.Controls.Add(this.lbl_start_index);
            this.Tab_FileName_Edit.Controls.Add(this.panel1);
            this.Tab_FileName_Edit.Controls.Add(this.txt_insert_string);
            this.Tab_FileName_Edit.Controls.Add(this.txt_start_index);
            this.Tab_FileName_Edit.Controls.Add(this.lbl_replace_string);
            this.Tab_FileName_Edit.Controls.Add(this.txt_replace_string);
            this.Tab_FileName_Edit.Controls.Add(this.txt_find_string);
            this.Tab_FileName_Edit.Controls.Add(this.txt_folder_pt);
            this.Tab_FileName_Edit.Controls.Add(this.lbl_find_string);
            this.Tab_FileName_Edit.Controls.Add(this.lbl_folder_pt);
            this.Tab_FileName_Edit.Location = new System.Drawing.Point(4, 29);
            this.Tab_FileName_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_FileName_Edit.Name = "Tab_FileName_Edit";
            this.Tab_FileName_Edit.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_FileName_Edit.Size = new System.Drawing.Size(1014, 355);
            this.Tab_FileName_Edit.TabIndex = 0;
            this.Tab_FileName_Edit.Text = "이름 변경";
            this.Tab_FileName_Edit.UseVisualStyleBackColor = true;
            // 
            // rbtnIndexReplace
            // 
            this.rbtnIndexReplace.AutoSize = true;
            this.rbtnIndexReplace.Location = new System.Drawing.Point(788, 89);
            this.rbtnIndexReplace.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnIndexReplace.Name = "rbtnIndexReplace";
            this.rbtnIndexReplace.Size = new System.Drawing.Size(60, 24);
            this.rbtnIndexReplace.TabIndex = 21;
            this.rbtnIndexReplace.Text = "수동";
            this.rbtnIndexReplace.UseVisualStyleBackColor = true;
            // 
            // rbtnStringReplace
            // 
            this.rbtnStringReplace.AutoSize = true;
            this.rbtnStringReplace.Checked = true;
            this.rbtnStringReplace.Location = new System.Drawing.Point(705, 88);
            this.rbtnStringReplace.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnStringReplace.Name = "rbtnStringReplace";
            this.rbtnStringReplace.Size = new System.Drawing.Size(60, 24);
            this.rbtnStringReplace.TabIndex = 20;
            this.rbtnStringReplace.TabStop = true;
            this.rbtnStringReplace.Text = "자동";
            this.rbtnStringReplace.UseVisualStyleBackColor = true;
            // 
            // Tab_FileName_Copy
            // 
            this.Tab_FileName_Copy.Controls.Add(this.lbl_File_List);
            this.Tab_FileName_Copy.Controls.Add(this.lb_FlieList);
            this.Tab_FileName_Copy.Controls.Add(this.btn_Name_Match);
            this.Tab_FileName_Copy.Controls.Add(this.cmb_Target_Extension);
            this.Tab_FileName_Copy.Controls.Add(this.cmb_Source_Extension);
            this.Tab_FileName_Copy.Controls.Add(this.lbl_Target_Extension);
            this.Tab_FileName_Copy.Controls.Add(this.lbl_Source_Extension);
            this.Tab_FileName_Copy.Controls.Add(this.BtnOpenCopyPath);
            this.Tab_FileName_Copy.Controls.Add(this.text_Folder_Path);
            this.Tab_FileName_Copy.Controls.Add(this.lbl_Folder_Path);
            this.Tab_FileName_Copy.Location = new System.Drawing.Point(4, 29);
            this.Tab_FileName_Copy.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_FileName_Copy.Name = "Tab_FileName_Copy";
            this.Tab_FileName_Copy.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_FileName_Copy.Size = new System.Drawing.Size(1014, 355);
            this.Tab_FileName_Copy.TabIndex = 1;
            this.Tab_FileName_Copy.Text = "이름 복사";
            this.Tab_FileName_Copy.UseVisualStyleBackColor = true;
            // 
            // lbl_File_List
            // 
            this.lbl_File_List.AutoSize = true;
            this.lbl_File_List.Location = new System.Drawing.Point(17, 151);
            this.lbl_File_List.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_File_List.Name = "lbl_File_List";
            this.lbl_File_List.Size = new System.Drawing.Size(89, 20);
            this.lbl_File_List.TabIndex = 12;
            this.lbl_File_List.Text = "파일 리스트";
            // 
            // lb_FlieList
            // 
            this.lb_FlieList.FormattingEnabled = true;
            this.lb_FlieList.ItemHeight = 20;
            this.lb_FlieList.Location = new System.Drawing.Point(21, 187);
            this.lb_FlieList.Margin = new System.Windows.Forms.Padding(4);
            this.lb_FlieList.Name = "lb_FlieList";
            this.lb_FlieList.Size = new System.Drawing.Size(962, 144);
            this.lb_FlieList.TabIndex = 11;
            // 
            // btn_Name_Match
            // 
            this.btn_Name_Match.Location = new System.Drawing.Point(877, 84);
            this.btn_Name_Match.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Name_Match.Name = "btn_Name_Match";
            this.btn_Name_Match.Size = new System.Drawing.Size(107, 31);
            this.btn_Name_Match.TabIndex = 10;
            this.btn_Name_Match.Text = "실행";
            this.btn_Name_Match.UseVisualStyleBackColor = true;
            this.btn_Name_Match.Click += new System.EventHandler(this.BtnCopyNameExecution_Click);
            // 
            // cmb_Target_Extension
            // 
            this.cmb_Target_Extension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Target_Extension.FormattingEnabled = true;
            this.cmb_Target_Extension.Location = new System.Drawing.Point(433, 84);
            this.cmb_Target_Extension.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Target_Extension.Name = "cmb_Target_Extension";
            this.cmb_Target_Extension.Size = new System.Drawing.Size(169, 28);
            this.cmb_Target_Extension.TabIndex = 9;
            // 
            // cmb_Source_Extension
            // 
            this.cmb_Source_Extension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Source_Extension.FormattingEnabled = true;
            this.cmb_Source_Extension.Location = new System.Drawing.Point(116, 84);
            this.cmb_Source_Extension.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Source_Extension.Name = "cmb_Source_Extension";
            this.cmb_Source_Extension.Size = new System.Drawing.Size(169, 28);
            this.cmb_Source_Extension.TabIndex = 8;
            // 
            // lbl_Target_Extension
            // 
            this.lbl_Target_Extension.AutoSize = true;
            this.lbl_Target_Extension.Location = new System.Drawing.Point(334, 84);
            this.lbl_Target_Extension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Target_Extension.Name = "lbl_Target_Extension";
            this.lbl_Target_Extension.Size = new System.Drawing.Size(89, 20);
            this.lbl_Target_Extension.TabIndex = 7;
            this.lbl_Target_Extension.Text = "대상 확장자";
            // 
            // lbl_Source_Extension
            // 
            this.lbl_Source_Extension.AutoSize = true;
            this.lbl_Source_Extension.Location = new System.Drawing.Point(17, 84);
            this.lbl_Source_Extension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Source_Extension.Name = "lbl_Source_Extension";
            this.lbl_Source_Extension.Size = new System.Drawing.Size(89, 20);
            this.lbl_Source_Extension.TabIndex = 6;
            this.lbl_Source_Extension.Text = "기준 확장자";
            // 
            // BtnOpenCopyPath
            // 
            this.BtnOpenCopyPath.Location = new System.Drawing.Point(877, 28);
            this.BtnOpenCopyPath.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOpenCopyPath.Name = "BtnOpenCopyPath";
            this.BtnOpenCopyPath.Size = new System.Drawing.Size(107, 31);
            this.BtnOpenCopyPath.TabIndex = 5;
            this.BtnOpenCopyPath.Text = "폴더 열기";
            this.BtnOpenCopyPath.UseVisualStyleBackColor = true;
            this.BtnOpenCopyPath.Click += new System.EventHandler(this.BtnOpenCopyPath_Click);
            // 
            // text_Folder_Path
            // 
            this.text_Folder_Path.Location = new System.Drawing.Point(116, 28);
            this.text_Folder_Path.Margin = new System.Windows.Forms.Padding(4);
            this.text_Folder_Path.Name = "text_Folder_Path";
            this.text_Folder_Path.Size = new System.Drawing.Size(752, 27);
            this.text_Folder_Path.TabIndex = 3;
            // 
            // lbl_Folder_Path
            // 
            this.lbl_Folder_Path.AutoSize = true;
            this.lbl_Folder_Path.Location = new System.Drawing.Point(21, 28);
            this.lbl_Folder_Path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Folder_Path.Name = "lbl_Folder_Path";
            this.lbl_Folder_Path.Size = new System.Drawing.Size(74, 20);
            this.lbl_Folder_Path.TabIndex = 4;
            this.lbl_Folder_Path.Text = "폴더 경로";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1056, 509);
            this.Controls.Add(this.lbl_status_cnt);
            this.Controls.Add(this.progbar_status);
            this.Controls.Add(this.Tab_File_Rename);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1074, 556);
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tab_File_Rename.ResumeLayout(false);
            this.Tab_FileName_Edit.ResumeLayout(false);
            this.Tab_FileName_Edit.PerformLayout();
            this.Tab_FileName_Copy.ResumeLayout(false);
            this.Tab_FileName_Copy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_find_string;
        private System.Windows.Forms.Label lbl_folder_pt;
        private System.Windows.Forms.Button BtnOpenRenamePath;
        private System.Windows.Forms.TextBox txt_folder_pt;
        private System.Windows.Forms.Label lbl_find_string;
        private System.Windows.Forms.TextBox txt_replace_string;
        private System.Windows.Forms.Label lbl_replace_string;
        private System.Windows.Forms.Button BtnRenameExecution;
        private System.Windows.Forms.ProgressBar progbar_status;
        private System.Windows.Forms.Label lbl_status_cnt;
        private System.Windows.Forms.TextBox txt_start_index;
        private System.Windows.Forms.TextBox txt_end_index;
        private System.Windows.Forms.Label lbl_start_index;
        private System.Windows.Forms.Label lbl_end_index;
        private System.Windows.Forms.RadioButton rbtn_replace_mode;
        private System.Windows.Forms.RadioButton rbtn_index_mode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_remove_integer_mode;
        private System.Windows.Forms.RadioButton rbtn_insert_mode;
        private System.Windows.Forms.Label lbl_insert_string;
        private System.Windows.Forms.TextBox txt_insert_string;
        private System.Windows.Forms.TabControl Tab_File_Rename;
        private System.Windows.Forms.TabPage Tab_FileName_Edit;
        private System.Windows.Forms.TabPage Tab_FileName_Copy;
        private System.Windows.Forms.Button BtnOpenCopyPath;
        private System.Windows.Forms.TextBox text_Folder_Path;
        private System.Windows.Forms.Label lbl_Folder_Path;
        private System.Windows.Forms.ComboBox cmb_Target_Extension;
        private System.Windows.Forms.ComboBox cmb_Source_Extension;
        private System.Windows.Forms.Label lbl_Target_Extension;
        private System.Windows.Forms.Label lbl_Source_Extension;
        private System.Windows.Forms.Button btn_Name_Match;
        private System.Windows.Forms.Label lbl_File_List;
        private System.Windows.Forms.ListBox lb_FlieList;
        private System.Windows.Forms.RadioButton rbtnIndexReplace;
        private System.Windows.Forms.RadioButton rbtnStringReplace;
    }
}

