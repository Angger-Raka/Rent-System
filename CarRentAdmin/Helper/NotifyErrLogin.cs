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
    public partial class NotifyErrLogin : Form
    {
        public NotifyErrLogin()
        {
            InitializeComponent();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
