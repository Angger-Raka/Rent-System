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
    public partial class ManJenisIden : Form
    {
        List<JenisIden> ListJenis = new List<JenisIden>();
        int tableindex = 1;
        public ManJenisIden()
        {
            InitializeComponent();
        }

        private void ManJenisIden_Load(object sender, EventArgs e)
        {
            getAllUser();
        }

        private JenisIden getAllUser()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBRentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM identity_type";
            cmd.Connection = conn;

            JenisIden user = new JenisIden();

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    user.id = reader.GetInt32(0);
                    user.name = reader.GetString(1);

                    ListJenis.Add(user);
                    var labelss = Controls.Find("label" + tableindex, true).FirstOrDefault() as Label;
                    var returnn = Controls.Find("LbReturn" + tableindex, true).FirstOrDefault() as Label;
                    var pictboxs = Controls.Find("pictureBox" + tableindex, true).FirstOrDefault() as PictureBox;
                    var panelss = Controls.Find("panel" + tableindex, true).FirstOrDefault() as Panel;

                    var imagespath = Path.Combine(Application.StartupPath, "Images", "Profile.jpg");
                    if (labelss != null)
                    {
                        labelss.Text = "ID : " + user.id.ToString();
                        returnn.Text = "Nama : " + user.name.ToString();
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
