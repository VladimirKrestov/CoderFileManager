using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public UserForm2(string userName, int userId)
        {
            InitializeComponent();
            this.userId = userId;
            label2.Text = userName;
            string sconn = "Data Source=1-ПК;Initial Catalog=DataBase2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            SqlConnection sc = new SqlConnection(sconn);
            sc.Open();
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("Select * from [DbFile]", sc);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["UserId"]) == userId)
                {
                    listBoxSelect.Items.Add(dr["FileName"]);
                    listBoxDelete.Items.Add(dr["FileName"]);
                }
            }
        }

        private void butOpenFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Все файлы| *.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string sconn = "Data Source=1-ПК;Initial Catalog=DataBase2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
                SqlConnection sc = new SqlConnection(sconn);
                sc.Open();
                SqlDataReader dr = null;
                SqlCommand cmd = new SqlCommand("Select * from [DbFile]", sc);
                dr = cmd.ExecuteReader();
                //string codeFile = dr.CodetFile;
                Decod decodeCode = new Decod();
                decodeCode.Decoding(dlg.FileName, Path.GetFileName(dlg.FileName));
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Все файлы| *.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Cod codeFile = new Cod(dlg.FileName, Path.GetFileName(dlg.FileName), userId);

            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            string sconn = "Data Source=1-ПК;Initial Catalog=DataBase2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            SqlConnection sc = new SqlConnection(sconn);
            sc.Open();
            //DbFile dfile = db.DbFile.FirstOrDefault(f => f == listBoxDelete.SelectedItem);//////////////////////////////////
            //int iD = dfile.Id;//////////////////////////////////////////////////////////////////////////////////////////////
            SqlCommand cmd = new SqlCommand("DELETE FROM [DbFile] WHERE [Id] = @Id", sc);
            cmd.Parameters.AddWithValue("Id", 5);
            cmd.ExecuteNonQuery();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            listBoxSelect.Items.Clear();
            string sconn = "Data Source=1-ПК;Initial Catalog=DataBase2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            SqlConnection sc = new SqlConnection(sconn);
            sc.Open();
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("Select * from [DbFile]", sc);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["UserId"]) == userId)
                {
                    listBoxSelect.Items.Add(dr["FileName"]);
                    listBoxDelete.Items.Add(dr["FileName"]);
                }
            }
        }

        private void butUpdateDelete_Click(object sender, EventArgs e)
        {
            listBoxDelete.Items.Clear();
            string sconn = "Data Source=1-ПК;Initial Catalog=DataBase2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            SqlConnection sc = new SqlConnection(sconn);
            sc.Open();
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("Select * from [DbFile]", sc);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["UserId"]) == userId)
                {
                    listBoxDelete.Items.Add(dr["FileName"]);
                    listBoxSelect.Items.Add(dr["FileName"]);
                }
            }
        }
    }
}
