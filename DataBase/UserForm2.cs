using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class UserForm2 : Form
    {
        int userId;
        DB db = new DB();
        public static string addFileName;

       
        public UserForm2(string userName, int userId)
        {
            this.userId = userId;

            InitializeComponent();
            label2.Text = userName;
            IEnumerable<DbFile> files = db.DbFile.Where(f => f.UserId == userId);
            foreach (DbFile file in files)
            {
                listBoxUserFiles.Items.Add(file.FileName);
            }
        }

        private void butOpenFile_Click(object sender, EventArgs e)
        {
            DbFile dFile = db.DbFile.FirstOrDefault(f => f.FileName == listBoxUserFiles.SelectedItem.ToString());
            if (dFile != null)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Все файлы| *.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Decoding decodeCode = new Decoding(dlg.FileName, Path.GetFileName(dlg.FileName), dFile.CodetFile);
                }
                Process.Start(dlg.FileName);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Все файлы| *.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                AddNameForm form4 = new AddNameForm(dlg.FileName, Path.GetFileName(dlg.FileName), userId, this);
                form4.Visible = true;
                form4.Focus();
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DbFile dFile = db.DbFile.FirstOrDefault(f => f.FileName == listBoxUserFiles.SelectedItem.ToString());
            db.DbFile.Remove(dFile);
            db.SaveChanges();
            UpdateEvent();
        }

        public void UpdateEvent()
        {
            listBoxUserFiles.Items.Clear();
            IEnumerable<DbFile> files = db.DbFile.Where(f => f.UserId == userId);
            foreach (DbFile file in files)
            {
                listBoxUserFiles.Items.Add(file.FileName);
            }
        }
    }
}
