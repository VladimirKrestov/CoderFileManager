using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class AddNameForm : Form
    {
        DB db = new DB();
        string fileName;
        UserForm2 mainForm;
        
        string addFilePath;
        int userId;
        public AddNameForm(string addFilePath, string fileName,int userId, UserForm2 f)
        {
            this.addFilePath = addFilePath;
            this.userId = userId;
            mainForm = f;
            InitializeComponent();
            textBoxNameNewFile.Text = fileName;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = textBoxNameNewFile.Text;
            DbFile file = db.DbFile.FirstOrDefault(f => f.FileName == fileName);
           
            if (file == null)
            {
                Coding codeFile = new Coding(addFilePath, fileName, userId);
                Close();
                mainForm.UpdateEvent();
            }
            else MessageBox.Show("Такое имя уже есть!");
        }

        
    }
}
