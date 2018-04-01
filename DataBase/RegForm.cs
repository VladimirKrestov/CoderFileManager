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
    public partial class RegForm : Form
    {
        DB db = new DB();
        public RegForm()
        {
            InitializeComponent();
        }

        private void butNewReg_Click(object sender, EventArgs e)
        {
            DBUser u = new DBUser();
            u.Login = textBoxNewLogin.Text;
            u.Password = textBoxNewPass.Text;
            u.Name = textBoxNewName.Text;
            db.DBUser.Add(u);
            db.SaveChanges();
            Close();
        }
    }
}
