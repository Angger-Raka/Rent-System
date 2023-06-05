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
    public partial class ErrOption : Form
    {
        bool isAdmin;
        public ErrOption(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }

        private void ErrOption_Load(object sender, EventArgs e)
        {
            if(isAdmin)
            {
                TbErr.Text = "Kesalahan password lama salah";
            }
            else
            {
                TbErr.Text = "Kesalahan passwor baru tidak cocok";
            }
        }
    }
}
