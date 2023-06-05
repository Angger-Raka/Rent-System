using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentAdmin.Helper
{
    public partial class AddCars : Form
    {
        string pathUpload;
        string dst;
        bool isupload;
        public AddCars()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (isupload)
            {
                pathUpload = null;
                dst = null;
                pictureBox1.Image = null;
                isupload = false;
                LbStat.Text = "Upload image disini";

            }
            else
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG (*.jpg;*.png) | *.jpg;*.png";
                dlg.Title = "Upload Images";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pathUpload = dlg.FileName;
                    dst = Application.StartupPath + "Images" + dlg.SafeFileName;
                    pictureBox1.Image = Image.FromFile(pathUpload);
                    isupload=true;
                    LbStat.Text = string.Empty;
                }
            }
        }

        private void AddCars_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TbBrand.Text == "" || TbColor.Text == "" || TbDateYear.Text == "" || TbJumlah.Value == 0 || TbPlate.Text == "" || TbRental.Text == "" || TbStat.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("FORM HARUS DIISI");
            }
            else
            {
                try
                {
                   
                    MessageBox.Show("Data Berhasil Diinput");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.Source);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
