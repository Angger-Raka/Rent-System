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
    public partial class HistoryTransaksi : Form
    {
        List<transaksi> transaksisList = new List<transaksi>();
        int tableindex = 1;
        public HistoryTransaksi()
        {
            InitializeComponent();
        }

        private void HistoryTransaksi_Load(object sender, EventArgs e)
        {
            getAllUser();
        }



        private transaksi getAllUser()
        {
            var labels = (label1, label2, label3, label4, label5);
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBRentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM transactions";
            cmd.Connection = conn;

            transaksi user = new transaksi();

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    user.id = reader.GetInt32(0);
                    user.user_id = reader.GetInt32(1);
                    user.customer_id = reader.GetInt32(2);
                    user.car_id = reader.GetInt32(3);
                    user.rent_date = reader.GetDateTime(4);
                    user.return_date = reader.GetDateTime(5);
                    transaksisList.Add(user);
                    var labelss = Controls.Find("label" + tableindex, true).FirstOrDefault() as Label;
                    var returnn = Controls.Find("LbReturn" + tableindex, true).FirstOrDefault() as Label;
                    var pictboxs = Controls.Find("pictureBox" + tableindex, true).FirstOrDefault() as PictureBox;
                    var panelss = Controls.Find("panel" + tableindex, true).FirstOrDefault() as Panel;

                    var imagespath = Path.Combine(Application.StartupPath, "Images", "Profile.jpg");
                    if (labelss != null)
                    {
                        labelss.Text = "Rent : " +user.rent_date.ToString();
                        returnn.Text = "Return : " + user.return_date.ToString();
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
