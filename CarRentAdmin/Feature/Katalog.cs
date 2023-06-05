using CarRentAdmin.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRentAdmin.Feature
{
    public partial class Katalog : Form
    { 

        List<Car> cars = new List<Car>();
        public Katalog()
        {
            InitializeComponent();
        }

        private void Katalog_Load(object sender, EventArgs e)
        {
            getAllCars(textBox1.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAllCars(textBox1.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Car getAllCars(String Filter)
        {
            LbBrand.Text = null;
            LbColor.Text = null;
            LbPlate.Text = null;
            LbYear.Text = null;
            pictureBox1.Image = null; 
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBRentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"SELECT * FROM cars WHERE brand LIKE '%{Filter}%' ";
            cmd.Connection = conn;


            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {


                if (reader.Read())
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
                    cars.Add(car);
                }
                LbBrand.Text = reader.GetString(1) == "" ? "data Tidak Ada" : reader.GetString(1);
                LbColor.Text = reader.GetString(3) == "" ? "data Tidak Ada" : reader.GetString(3);
                LbPlate.Text = reader.GetString(2) == "" ? "data Tidak Ada" : reader.GetString(2);
                LbYear.Text = reader.GetDateTime(4) == null ? "data Tidak ada" : reader.GetDateTime(4).Year.ToString();
                pictureBox1.Image = Image.FromFile(reader.GetString(8));
                conn.Close();
                return null;
            }

        }
    }
}
