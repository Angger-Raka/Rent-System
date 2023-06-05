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
    public partial class NotifyDeletePassword : Form
    {
        int id;
        public NotifyDeletePassword(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void NotifyDeletePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usersTableAdapter1.rsestuser("123", id, id);
            MessageBox.Show("Reset Berhasil Silahkan Di test terlebih dahulu");
            Application.Restart();
        }
    }
}
