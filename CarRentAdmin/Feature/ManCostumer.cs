using CarRentAdmin.models;
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

namespace CarRentAdmin.Feature
{
    public partial class ManCostumer : Form
    {
        List<pelanggan> listPelanggan = new List<pelanggan>();
        int tableindex = 1;
        public ManCostumer()
        {
            InitializeComponent();
        }

        private void ManCostumer_Load(object sender, EventArgs e)
        {
            getAllUser();
        }
        private pelanggan getAllUser()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBRentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM customers";
            cmd.Connection = conn;

            pelanggan user = new pelanggan();

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    user.id = reader.GetInt32(0);
                    user.NoIden = reader.GetString(1);
                    user.JenisIden = reader.GetInt32(2);
                    user.Alamat = reader.GetString(3);
                    user.gender = reader.GetInt32(4);
                    user.phone = reader.GetString(5);

                    listPelanggan.Add(user);
                    var labelss = Controls.Find("label" + tableindex, true).FirstOrDefault() as Label;
                    var returnn = Controls.Find("LbReturn" + tableindex, true).FirstOrDefault() as Label;
                    var pictboxs = Controls.Find("pictureBox" + tableindex, true).FirstOrDefault() as PictureBox;
                    var panelss = Controls.Find("panel" + tableindex, true).FirstOrDefault() as Panel;

                    var imagespath = Path.Combine(Application.StartupPath, "Images", "Profile.jpg");
                    if (labelss != null)
                    {
                        labelss.Text = "Pelangggan ID : " + user.NoIden.ToString();
                        returnn.Text = "Alamat : " + user.Alamat.ToString();
                        pictboxs.Image = Image.FromFile(imagespath);
                        panelss.Show();

                    }
                    tableindex++;
                }
                conn.Close();
                return null;
            }
        }
    }
}
