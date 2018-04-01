namespace DataBase
{
    partial class MainForm
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
            this.lableLogin = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.butSignIn = new System.Windows.Forms.Button();
            this.butReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lableLogin
            // 
            this.lableLogin.AutoSize = true;
            this.lableLogin.Location = new System.Drawing.Point(64, 9);
            this.lableLogin.Name = "lableLogin";
            this.lableLogin.Size = new System.Drawing.Size(38, 13);
            this.lableLogin.TabIndex = 0;
            this.lableLogin.Text = "Логин";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(15, 25);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(138, 20);
            this.login.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(15, 74);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(138, 20);
            this.pass.TabIndex = 3;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(64, 58);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(45, 13);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "Пароль";
            // 
            // butSignIn
            // 
            this.butSignIn.Location = new System.Drawing.Point(53, 100);
            this.butSignIn.Name = "butSignIn";
            this.butSignIn.Size = new System.Drawing.Size(65, 23);
            this.butSignIn.TabIndex = 4;
            this.butSignIn.Text = "Вход";
            this.butSignIn.UseVisualStyleBackColor = true;
            this.butSignIn.Click += new System.EventHandler(this.butSignIn_Click);
            // 
            // butReg
            // 
            this.butReg.Location = new System.Drawing.Point(33, 139);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(108, 24);
            this.butReg.TabIndex = 5;
            this.butReg.Text = "Регистрация";
            this.butReg.UseVisualStyleBackColor = true;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 175);
            this.Controls.Add(this.butReg);
            this.Controls.Add(this.butSignIn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lableLogin);
            this.Name = "MainForm";
            this.Text = "База";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableLogin;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button butSignIn;
        public System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button butReg;
    }
}

