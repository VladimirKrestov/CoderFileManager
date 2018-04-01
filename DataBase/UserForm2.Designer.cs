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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSelect = new System.Windows.Forms.TabPage();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.listBoxSelect = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.listBoxDelete = new System.Windows.Forms.ListBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.butUpdateDelete = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSelect.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSelect);
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabDelete);
            this.tabControl1.Location = new System.Drawing.Point(16, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 273);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSelect
            // 
            this.tabSelect.Controls.Add(this.butUpdate);
            this.tabSelect.Controls.Add(this.listBoxSelect);
            this.tabSelect.Controls.Add(this.butOpenFile);
            this.tabSelect.Location = new System.Drawing.Point(4, 22);
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelect.Size = new System.Drawing.Size(651, 247);
            this.tabSelect.TabIndex = 0;
            this.tabSelect.Text = "Выбрать";
            this.tabSelect.UseVisualStyleBackColor = true;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.butAdd);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(651, 247);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Добавить";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // butOpenFile
            // 
            this.butOpenFile.Location = new System.Drawing.Point(532, 213);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(108, 28);
            this.butOpenFile.TabIndex = 1;
            this.butOpenFile.Text = "Открыть";
            this.butOpenFile.UseVisualStyleBackColor = true;
            this.butOpenFile.Click += new System.EventHandler(this.butOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Файлы пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.butUpdateDelete);
            this.tabDelete.Controls.Add(this.listBoxDelete);
            this.tabDelete.Controls.Add(this.butDelete);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(651, 247);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Удалить";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // listBoxSelect
            // 
            this.listBoxSelect.FormattingEnabled = true;
            this.listBoxSelect.Location = new System.Drawing.Point(8, 10);
            this.listBoxSelect.Name = "listBoxSelect";
            this.listBoxSelect.Size = new System.Drawing.Size(632, 199);
            this.listBoxSelect.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выберите файл который хотите добавить";
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(9, 42);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(102, 31);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Выбрать";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // listBoxDelete
            // 
            this.listBoxDelete.FormattingEnabled = true;
            this.listBoxDelete.Location = new System.Drawing.Point(9, 8);
            this.listBoxDelete.Name = "listBoxDelete";
            this.listBoxDelete.Size = new System.Drawing.Size(632, 199);
            this.listBoxDelete.TabIndex = 2;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(533, 211);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(108, 28);
            this.butDelete.TabIndex = 3;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butUpdateDelete
            // 
            this.butUpdateDelete.Location = new System.Drawing.Point(413, 211);
            this.butUpdateDelete.Name = "butUpdateDelete";
            this.butUpdateDelete.Size = new System.Drawing.Size(114, 28);
            this.butUpdateDelete.TabIndex = 4;
            this.butUpdateDelete.Text = "Обновить";
            this.butUpdateDelete.UseVisualStyleBackColor = true;
            this.butUpdateDelete.Click += new System.EventHandler(this.butUpdateDelete_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(412, 213);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(114, 28);
            this.butUpdate.TabIndex = 5;
            this.butUpdate.Text = "Обновить";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // UserForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserForm2";
            this.Text = "UserForm2";
            this.tabControl1.ResumeLayout(false);
            this.tabSelect.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSelect;
        private System.Windows.Forms.ListBox listBoxSelect;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDelete;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butUpdateDelete;
    }
}