using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class MainForm : Form
    {
        DB db = new DB();

        public MainForm()
        {
            InitializeComponent();
        }



        private void butSignIn_Click(object sender, EventArgs e)
        {
            DBUser user = db.DBUser.FirstOrDefault(u => u.Login == login.Text && u.Password == pass.Text);
            if (user != null)
            {
                FocusForm2(user.Name,user.Id);
            }
            else MessageBox.Show("Нет такого!");
        }

        private void FocusForm2(string userName, int userId)
        {
            UserForm2 form2 = new UserForm2(userName, userId);
            form2.Visible = true;
            form2.Focus();
        }

        private void butReg_Click(object sender, EventArgs e)
        {
            RegForm form3 = new RegForm();
            form3.Visible = true;
            form3.Focus();
        }
    }
}
