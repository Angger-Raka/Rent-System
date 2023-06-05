using CarRentAdmin.Helper;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRentAdmin.Feature
{
    public partial class ManCars : Form
    {
        List<Car> carss = new List<Car>();
        int tableindex = 1;
        public ManCars()
        {
            InitializeComponent();
        }

        private void ManCars_Load(object sender, EventArgs e)
        {
            getAllCars();
        }

        private Car getAllCars()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBRentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM cars";
            cmd.Connection = conn;


            conn.Open();
            using(SqlDataReader reader = cmd.ExecuteReader())
            {

                
                while(reader.Read())
                {
                    Car car = new Car();
                    car.id = reader.GetInt32(0);
                    car.brand = reader.GetString(1);
                    car.plate = reader.GetString(2);
                    car.color = reader.GetString(3);
                    car.year = reader.GetDateTime(4);
                    car.status = reader.GetInt32(5);
                    car.car_seat_id = reader.GetString(6);
                    car.pathimages = reader.GetString(8);

                    carss.Add(car);

                    var labelss = Controls.Find("label" + tableindex, true).FirstOrDefault() as Label;
                    var pictboxs = Controls.Find("pictureBox" + tableindex, true).FirstOrDefault() as PictureBox;
                    var panelss = Controls.Find("panel" + tableindex, true).FirstOrDefault() as Panel;

                    if (labelss != null)
                    {
                        labelss.Text = car.brand;
                        pictboxs.Image = Image.FromFile(car.pathimages);
                        panelss.Show();
                    }
                    tableindex++;
                }
                conn.Close();
                return null;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCars addCars = new AddCars();
            addCars.Show();
        }
    }
}
