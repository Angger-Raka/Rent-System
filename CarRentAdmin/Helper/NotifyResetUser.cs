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
    public partial class NotifyResetUser : Form
    {
        int id;
        public NotifyResetUser(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void NotifyResetUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usersTableAdapter1.DeletUser(id);
            MessageBox.Show("User Berhasil Di Hapus");
            this.Close();
        }
    }
}
