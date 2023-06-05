using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentAdmin.Helper
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int levelUser()
        {
            if (CbAdmin.Checked == true ) return 1;
            if(CbKaryawan.Checked == true) return 2;
            return 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            BtnErr.Text = string.Empty;
            string Nama = TbName.Text;
            string user = TbUser.Text;
            string pass = TbPass.Text;

            try
            {
                if (Nama == "" || user == "" || pass == "")
                {
                    BtnErr.Text = "Form Harap Diisi";
                }
                else
                {
                    if(CbAdmin.Checked == false && CbKaryawan.Checked == false)
                    {
                        BtnErr.Text = "Checkbox tidak boleh kosong";
                    }
                    else
                    {
                        var level = levelUser();
                        usersTableAdapter1.InsertUser(Nama, user, pass, level);
                        MessageBox.Show("User Berhasil Ditambahkan");
                        this.Close();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
