using CarRentAdmin.models;
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

namespace CarRentAdmin.Helper
{
    public partial class UpdateUser : Form
    {
        int id;
        public UpdateUser(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void getalldatauser()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBRentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM users WHERE (user_id=@id)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("id", id);

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    TbNama.Text = reader.GetString(1);
                    TbUser.Text = reader.GetString(2);
                    TbPass.Text = reader.GetString(3);
                    getCheck(reader.GetInt32(4));
                }
            }
        }


        private void getCheck(int level)
        {
            if(level == 3)
            {
                CbAdmin.Checked = true;
                CbKaryawan.Checked = true;
            }
            if(level == 1) CbAdmin.Checked = true;
            if(level == 2) CbKaryawan.Checked = true;

        }
        private int checklevel()
        {
            if (CbKaryawan.Checked && CbAdmin.Checked) return 3;
            if (CbAdmin.Checked) return 1;
            if(CbKaryawan.Checked) return 2;
            return 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string user = TbUser.Text;
            string nama = TbNama.Text;
            string pass = TbPass.Text;
            bool isAdmin = CbAdmin.Checked;
            bool isKaryawan = CbKaryawan.Checked;
            var value = checklevel();

            try
            {
                if (user == "" || pass == "" || nama == "")
                {
                    MessageBox.Show("Form Harap diisi");
                }
                else
                {
                    if (isAdmin == false && isKaryawan == false)
                    {
                        MessageBox.Show("Checkbox tidak boleh tidak diisi");
                    }
                    else
                    {
                        usersTableAdapter1.UpdateUser(nama, user, pass, value, id, id);
                        MessageBox.Show("data berhasil ditambahkan");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private User GetUser(int id, string name, string username, string password, int level)
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE users SET id=@ID,";

            try
            {

            }catch {
            
            }
            return null;
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            getalldatauser();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotifyDeletePassword delet = new NotifyDeletePassword(id);
            delet.Show();
        }
    }
}
