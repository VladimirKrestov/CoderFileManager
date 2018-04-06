namespace DataBase
{
    partial class UserForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxUserFiles = new System.Windows.Forms.ListBox();
            this.butDeleteFile = new System.Windows.Forms.Button();
            this.butAddFile = new System.Windows.Forms.Button();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Файлы пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // listBoxUserFiles
            // 
            this.listBoxUserFiles.FormattingEnabled = true;
            this.listBoxUserFiles.Location = new System.Drawing.Point(12, 37);
            this.listBoxUserFiles.Name = "listBoxUserFiles";
            this.listBoxUserFiles.Size = new System.Drawing.Size(336, 199);
            this.listBoxUserFiles.TabIndex = 4;
            // 
            // butDeleteFile
            // 
            this.butDeleteFile.Location = new System.Drawing.Point(240, 259);
            this.butDeleteFile.Name = "butDeleteFile";
            this.butDeleteFile.Size = new System.Drawing.Size(108, 28);
            this.butDeleteFile.TabIndex = 6;
            this.butDeleteFile.Text = "Удалить";
            this.butDeleteFile.UseVisualStyleBackColor = true;
            this.butDeleteFile.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butAddFile
            // 
            this.butAddFile.Location = new System.Drawing.Point(126, 259);
            this.butAddFile.Name = "butAddFile";
            this.butAddFile.Size = new System.Drawing.Size(108, 28);
            this.butAddFile.TabIndex = 7;
            this.butAddFile.Text = "Добавить";
            this.butAddFile.UseVisualStyleBackColor = true;
            this.butAddFile.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butOpenFile
            // 
            this.butOpenFile.Location = new System.Drawing.Point(12, 259);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(108, 28);
            this.butOpenFile.TabIndex = 8;
            this.butOpenFile.Text = "Открыть";
            this.butOpenFile.UseVisualStyleBackColor = true;
            this.butOpenFile.Click += new System.EventHandler(this.butOpenFile_Click);
            // 
            // UserForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 301);
            this.Controls.Add(this.butOpenFile);
            this.Controls.Add(this.butAddFile);
            this.Controls.Add(this.butDeleteFile);
            this.Controls.Add(this.listBoxUserFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserForm2";
            this.Text = "UserForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxUserFiles;
        private System.Windows.Forms.Button butDeleteFile;
        private System.Windows.Forms.Button butAddFile;
        private System.Windows.Forms.Button butOpenFile;
    }
}