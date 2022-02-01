
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
            this.btn_open_dg = new System.Windows.Forms.Button();
            this.lbl_find_string = new System.Windows.Forms.Label();
            this.txt_find_string = new System.Windows.Forms.TextBox();
            this.txt_replace_string = new System.Windows.Forms.TextBox();
            this.lbl_replace_string = new System.Windows.Forms.Label();
            this.btn_execute = new System.Windows.Forms.Button();
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
            this.btn_Open_Folder = new System.Windows.Forms.Button();
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
            this.txt_folder_pt.Location = new System.Drawing.Point(99, 21);
            this.txt_folder_pt.Name = "txt_folder_pt";
            this.txt_folder_pt.Size = new System.Drawing.Size(586, 23);
            this.txt_folder_pt.TabIndex = 0;
            // 
            // lbl_folder_pt
            // 
            this.lbl_folder_pt.AutoSize = true;
            this.lbl_folder_pt.Location = new System.Drawing.Point(12, 21);
            this.lbl_folder_pt.Name = "lbl_folder_pt";
            this.lbl_folder_pt.Size = new System.Drawing.Size(59, 15);
            this.lbl_folder_pt.TabIndex = 1;
            this.lbl_folder_pt.Text = "폴더 경로";
            // 
            // btn_open_dg
            // 
            this.btn_open_dg.Location = new System.Drawing.Point(691, 21);
            this.btn_open_dg.Name = "btn_open_dg";
            this.btn_open_dg.Size = new System.Drawing.Size(83, 23);
            this.btn_open_dg.TabIndex = 2;
            this.btn_open_dg.Text = "폴더 열기";
            this.btn_open_dg.UseVisualStyleBackColor = true;
            this.btn_open_dg.Click += new System.EventHandler(this.btn_open_dg_Click);
            // 
            // lbl_find_string
            // 
            this.lbl_find_string.AutoSize = true;
            this.lbl_find_string.Location = new System.Drawing.Point(12, 66);
            this.lbl_find_string.Name = "lbl_find_string";
            this.lbl_find_string.Size = new System.Drawing.Size(71, 15);
            this.lbl_find_string.TabIndex = 3;
            this.lbl_find_string.Text = "대상 문자열";
            // 
            // txt_find_string
            // 
            this.txt_find_string.Location = new System.Drawing.Point(99, 67);
            this.txt_find_string.Name = "txt_find_string";
            this.txt_find_string.Size = new System.Drawing.Size(167, 23);
            this.txt_find_string.TabIndex = 4;
            // 
            // txt_replace_string
            // 
            this.txt_replace_string.Location = new System.Drawing.Point(354, 64);
            this.txt_replace_string.Name = "txt_replace_string";
            this.txt_replace_string.Size = new System.Drawing.Size(167, 23);
            this.txt_replace_string.TabIndex = 6;
            // 
            // lbl_replace_string
            // 
            this.lbl_replace_string.AutoSize = true;
            this.lbl_replace_string.Location = new System.Drawing.Point(277, 67);
            this.lbl_replace_string.Name = "lbl_replace_string";
            this.lbl_replace_string.Size = new System.Drawing.Size(71, 15);
            this.lbl_replace_string.TabIndex = 5;
            this.lbl_replace_string.Text = "대체 문자열";
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(691, 53);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(83, 23);
            this.btn_execute.TabIndex = 7;
            this.btn_execute.Text = "실행";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // progbar_status
            // 
            this.progbar_status.Location = new System.Drawing.Point(19, 341);
            this.progbar_status.Name = "progbar_status";
            this.progbar_status.Size = new System.Drawing.Size(787, 24);
            this.progbar_status.TabIndex = 8;
            // 
            // lbl_status_cnt
            // 
            this.lbl_status_cnt.AutoSize = true;
            this.lbl_status_cnt.Location = new System.Drawing.Point(19, 314);
            this.lbl_status_cnt.Name = "lbl_status_cnt";
            this.lbl_status_cnt.Size = new System.Drawing.Size(43, 15);
            this.lbl_status_cnt.TabIndex = 9;
            this.lbl_status_cnt.Text = "진행률";
            // 
            // txt_start_index
            // 
            this.txt_start_index.Location = new System.Drawing.Point(99, 106);
            this.txt_start_index.Name = "txt_start_index";
            this.txt_start_index.Size = new System.Drawing.Size(167, 23);
            this.txt_start_index.TabIndex = 10;
            // 
            // txt_end_index
            // 
            this.txt_end_index.Location = new System.Drawing.Point(354, 106);
            this.txt_end_index.Name = "txt_end_index";
            this.txt_end_index.Size = new System.Drawing.Size(167, 23);
            this.txt_end_index.TabIndex = 11;
            // 
            // lbl_start_index
            // 
            this.lbl_start_index.AutoSize = true;
            this.lbl_start_index.Location = new System.Drawing.Point(12, 106);
            this.lbl_start_index.Name = "lbl_start_index";
            this.lbl_start_index.Size = new System.Drawing.Size(71, 15);
            this.lbl_start_index.TabIndex = 12;
            this.lbl_start_index.Text = "시작 인덱스";
            // 
            // lbl_end_index
            // 
            this.lbl_end_index.AutoSize = true;
            this.lbl_end_index.Location = new System.Drawing.Point(277, 109);
            this.lbl_end_index.Name = "lbl_end_index";
            this.lbl_end_index.Size = new System.Drawing.Size(71, 15);
            this.lbl_end_index.TabIndex = 13;
            this.lbl_end_index.Text = "종료 인덱스";
            // 
            // rbtn_replace_mode
            // 
            this.rbtn_replace_mode.AutoSize = true;
            this.rbtn_replace_mode.Checked = true;
            this.rbtn_replace_mode.Location = new System.Drawing.Point(8, 12);
            this.rbtn_replace_mode.Name = "rbtn_replace_mode";
            this.rbtn_replace_mode.Size = new System.Drawing.Size(101, 19);
            this.rbtn_replace_mode.TabIndex = 15;
            this.rbtn_replace_mode.TabStop = true;
            this.rbtn_replace_mode.Text = "Replace Mode";
            this.rbtn_replace_mode.UseVisualStyleBackColor = true;
            // 
            // rbtn_index_mode
            // 
            this.rbtn_index_mode.AutoSize = true;
            this.rbtn_index_mode.Location = new System.Drawing.Point(115, 12);
            this.rbtn_index_mode.Name = "rbtn_index_mode";
            this.rbtn_index_mode.Size = new System.Drawing.Size(89, 19);
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
            this.panel1.Location = new System.Drawing.Point(12, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 43);
            this.panel1.TabIndex = 17;
            // 
            // rbtn_insert_mode
            // 
            this.rbtn_insert_mode.AutoSize = true;
            this.rbtn_insert_mode.Location = new System.Drawing.Point(360, 12);
            this.rbtn_insert_mode.Name = "rbtn_insert_mode";
            this.rbtn_insert_mode.Size = new System.Drawing.Size(89, 19);
            this.rbtn_insert_mode.TabIndex = 18;
            this.rbtn_insert_mode.TabStop = true;
            this.rbtn_insert_mode.Text = "Insert Mode";
            this.rbtn_insert_mode.UseVisualStyleBackColor = true;
            // 
            // rbtn_remove_integer_mode
            // 
            this.rbtn_remove_integer_mode.AutoSize = true;
            this.rbtn_remove_integer_mode.Location = new System.Drawing.Point(210, 12);
            this.rbtn_remove_integer_mode.Name = "rbtn_remove_integer_mode";
            this.rbtn_remove_integer_mode.Size = new System.Drawing.Size(144, 19);
            this.rbtn_remove_integer_mode.TabIndex = 17;
            this.rbtn_remove_integer_mode.TabStop = true;
            this.rbtn_remove_integer_mode.Text = "Remove Integer Mode";
            this.rbtn_remove_integer_mode.UseVisualStyleBackColor = true;
            // 
            // lbl_insert_string
            // 
            this.lbl_insert_string.AutoSize = true;
            this.lbl_insert_string.Location = new System.Drawing.Point(12, 150);
            this.lbl_insert_string.Name = "lbl_insert_string";
            this.lbl_insert_string.Size = new System.Drawing.Size(71, 15);
            this.lbl_insert_string.TabIndex = 19;
            this.lbl_insert_string.Text = "삽입 인덱스";
            // 
            // txt_insert_string
            // 
            this.txt_insert_string.Location = new System.Drawing.Point(99, 147);
            this.txt_insert_string.Name = "txt_insert_string";
            this.txt_insert_string.Size = new System.Drawing.Size(167, 23);
            this.txt_insert_string.TabIndex = 18;
            // 
            // Tab_File_Rename
            // 
            this.Tab_File_Rename.Controls.Add(this.Tab_FileName_Edit);
            this.Tab_File_Rename.Controls.Add(this.Tab_FileName_Copy);
            this.Tab_File_Rename.Location = new System.Drawing.Point(15, 8);
            this.Tab_File_Rename.Name = "Tab_File_Rename";
            this.Tab_File_Rename.SelectedIndex = 0;
            this.Tab_File_Rename.Size = new System.Drawing.Size(795, 291);
            this.Tab_File_Rename.TabIndex = 20;
            // 
            // Tab_FileName_Edit
            // 
            this.Tab_FileName_Edit.Controls.Add(this.rbtnIndexReplace);
            this.Tab_FileName_Edit.Controls.Add(this.rbtnStringReplace);
            this.Tab_FileName_Edit.Controls.Add(this.lbl_end_index);
            this.Tab_FileName_Edit.Controls.Add(this.lbl_insert_string);
            this.Tab_FileName_Edit.Controls.Add(this.btn_open_dg);
            this.Tab_FileName_Edit.Controls.Add(this.btn_execute);
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
            this.Tab_FileName_Edit.Location = new System.Drawing.Point(4, 24);
            this.Tab_FileName_Edit.Name = "Tab_FileName_Edit";
            this.Tab_FileName_Edit.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_FileName_Edit.Size = new System.Drawing.Size(787, 263);
            this.Tab_FileName_Edit.TabIndex = 0;
            this.Tab_FileName_Edit.Text = "이름 변경";
            this.Tab_FileName_Edit.UseVisualStyleBackColor = true;
            // 
            // rbtnIndexReplace
            // 
            this.rbtnIndexReplace.AutoSize = true;
            this.rbtnIndexReplace.Location = new System.Drawing.Point(613, 67);
            this.rbtnIndexReplace.Name = "rbtnIndexReplace";
            this.rbtnIndexReplace.Size = new System.Drawing.Size(49, 19);
            this.rbtnIndexReplace.TabIndex = 21;
            this.rbtnIndexReplace.Text = "수동";
            this.rbtnIndexReplace.UseVisualStyleBackColor = true;
            // 
            // rbtnStringReplace
            // 
            this.rbtnStringReplace.AutoSize = true;
            this.rbtnStringReplace.Checked = true;
            this.rbtnStringReplace.Location = new System.Drawing.Point(548, 66);
            this.rbtnStringReplace.Name = "rbtnStringReplace";
            this.rbtnStringReplace.Size = new System.Drawing.Size(49, 19);
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
            this.Tab_FileName_Copy.Controls.Add(this.btn_Open_Folder);
            this.Tab_FileName_Copy.Controls.Add(this.text_Folder_Path);
            this.Tab_FileName_Copy.Controls.Add(this.lbl_Folder_Path);
            this.Tab_FileName_Copy.Location = new System.Drawing.Point(4, 24);
            this.Tab_FileName_Copy.Name = "Tab_FileName_Copy";
            this.Tab_FileName_Copy.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_FileName_Copy.Size = new System.Drawing.Size(787, 263);
            this.Tab_FileName_Copy.TabIndex = 1;
            this.Tab_FileName_Copy.Text = "이름 복사";
            this.Tab_FileName_Copy.UseVisualStyleBackColor = true;
            // 
            // lbl_File_List
            // 
            this.lbl_File_List.AutoSize = true;
            this.lbl_File_List.Location = new System.Drawing.Point(13, 113);
            this.lbl_File_List.Name = "lbl_File_List";
            this.lbl_File_List.Size = new System.Drawing.Size(71, 15);
            this.lbl_File_List.TabIndex = 12;
            this.lbl_File_List.Text = "파일 리스트";
            // 
            // lb_FlieList
            // 
            this.lb_FlieList.FormattingEnabled = true;
            this.lb_FlieList.ItemHeight = 15;
            this.lb_FlieList.Location = new System.Drawing.Point(16, 140);
            this.lb_FlieList.Name = "lb_FlieList";
            this.lb_FlieList.Size = new System.Drawing.Size(749, 109);
            this.lb_FlieList.TabIndex = 11;
            // 
            // btn_Name_Match
            // 
            this.btn_Name_Match.Location = new System.Drawing.Point(682, 63);
            this.btn_Name_Match.Name = "btn_Name_Match";
            this.btn_Name_Match.Size = new System.Drawing.Size(83, 23);
            this.btn_Name_Match.TabIndex = 10;
            this.btn_Name_Match.Text = "실행";
            this.btn_Name_Match.UseVisualStyleBackColor = true;
            this.btn_Name_Match.Click += new System.EventHandler(this.btn_Name_Match_Click);
            // 
            // cmb_Target_Extension
            // 
            this.cmb_Target_Extension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Target_Extension.FormattingEnabled = true;
            this.cmb_Target_Extension.Location = new System.Drawing.Point(337, 63);
            this.cmb_Target_Extension.Name = "cmb_Target_Extension";
            this.cmb_Target_Extension.Size = new System.Drawing.Size(132, 23);
            this.cmb_Target_Extension.TabIndex = 9;
            // 
            // cmb_Source_Extension
            // 
            this.cmb_Source_Extension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Source_Extension.FormattingEnabled = true;
            this.cmb_Source_Extension.Location = new System.Drawing.Point(90, 63);
            this.cmb_Source_Extension.Name = "cmb_Source_Extension";
            this.cmb_Source_Extension.Size = new System.Drawing.Size(132, 23);
            this.cmb_Source_Extension.TabIndex = 8;
            // 
            // lbl_Target_Extension
            // 
            this.lbl_Target_Extension.AutoSize = true;
            this.lbl_Target_Extension.Location = new System.Drawing.Point(260, 63);
            this.lbl_Target_Extension.Name = "lbl_Target_Extension";
            this.lbl_Target_Extension.Size = new System.Drawing.Size(71, 15);
            this.lbl_Target_Extension.TabIndex = 7;
            this.lbl_Target_Extension.Text = "대상 확장자";
            // 
            // lbl_Source_Extension
            // 
            this.lbl_Source_Extension.AutoSize = true;
            this.lbl_Source_Extension.Location = new System.Drawing.Point(13, 63);
            this.lbl_Source_Extension.Name = "lbl_Source_Extension";
            this.lbl_Source_Extension.Size = new System.Drawing.Size(71, 15);
            this.lbl_Source_Extension.TabIndex = 6;
            this.lbl_Source_Extension.Text = "기준 확장자";
            // 
            // btn_Open_Folder
            // 
            this.btn_Open_Folder.Location = new System.Drawing.Point(682, 21);
            this.btn_Open_Folder.Name = "btn_Open_Folder";
            this.btn_Open_Folder.Size = new System.Drawing.Size(83, 23);
            this.btn_Open_Folder.TabIndex = 5;
            this.btn_Open_Folder.Text = "폴더 열기";
            this.btn_Open_Folder.UseVisualStyleBackColor = true;
            this.btn_Open_Folder.Click += new System.EventHandler(this.btn_Open_Folder_Click);
            // 
            // text_Folder_Path
            // 
            this.text_Folder_Path.Location = new System.Drawing.Point(90, 21);
            this.text_Folder_Path.Name = "text_Folder_Path";
            this.text_Folder_Path.Size = new System.Drawing.Size(586, 23);
            this.text_Folder_Path.TabIndex = 3;
            // 
            // lbl_Folder_Path
            // 
            this.lbl_Folder_Path.AutoSize = true;
            this.lbl_Folder_Path.Location = new System.Drawing.Point(16, 21);
            this.lbl_Folder_Path.Name = "lbl_Folder_Path";
            this.lbl_Folder_Path.Size = new System.Drawing.Size(59, 15);
            this.lbl_Folder_Path.TabIndex = 4;
            this.lbl_Folder_Path.Text = "폴더 경로";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(823, 390);
            this.Controls.Add(this.lbl_status_cnt);
            this.Controls.Add(this.progbar_status);
            this.Controls.Add(this.Tab_File_Rename);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(839, 429);
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
        private System.Windows.Forms.Button btn_open_dg;
        private System.Windows.Forms.TextBox txt_folder_pt;
        private System.Windows.Forms.Label lbl_find_string;
        private System.Windows.Forms.TextBox txt_replace_string;
        private System.Windows.Forms.Label lbl_replace_string;
        private System.Windows.Forms.Button btn_execute;
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
        private System.Windows.Forms.Button btn_Open_Folder;
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

