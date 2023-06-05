using CarRentAdmin.Feature;
using CarRentAdmin.Helper;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentAdmin
{
    public partial class Login : Form
    {

        int numrand;
        int attemp = 4;
        public Login()
        {
            InitializeComponent();
        }

        class person
        {
            public int id;
            public int level;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = TbUser.Text;
            string pass = TbPass.Text;
            try
            {
                if (user == "" || pass == "" || TbCaptcha.Text == "")
                {
                    MessageBox.Show("kesalahan ada pada kolom yang belum terisi", "Kesalaha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (TbCaptcha.Text != numrand.ToString())
                    {
                        attemp = attemp - 1;
                        MessageBox.Show($"Captcha Salah silahkan diulangi lagi. Kesempatan {attemp}", "PERINGATAN!");
                        if (attemp == 0) Application.Exit();
                        getCaptcha();
                    }
                    else
                    {
                        var result = getLogin(user, pass);
                        if (result.id == 0)
                        {
                            NotifyErrLogin errLogin = new NotifyErrLogin();
                            errLogin.ShowDialog();
                            TbUser.Text = string.Empty;
                            TbPass.Text = string.Empty;
                            getCaptcha();
                        }
                        else if (result.level == 2)
                        {
                            MessageBox.Show("Terindikasi Akun Karyawan Silahkan Login ke Web");
                        }
                        else if (result.level == 1)
                        {
                            MainAdmin admin = new MainAdmin(result.id);
                            admin.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private person getLogin(string username, string password)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBRentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT user_id, level FROM users WHERE (username=@User) AND (password=@Pass)";
            cmd.Parameters.AddWithValue("User", username);
            cmd.Parameters.AddWithValue("Pass", password);
            cmd.Connection = conn;

            var user = new person();

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    user.id = reader.GetInt32(0);
                    user.level = reader.GetInt32(1);
                }
                conn.Close();
                return user;
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            getCaptcha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Katalog katalog = new Katalog();
            katalog.Show();
        }

        private void getCaptcha()
        {
            Random rand = new Random();
            numrand = rand.Next(1000, 10000);
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Font font = new Font("Microsoft Sans Serif", 40);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawString(numrand.ToString(), font, Brushes.Black, new Point(0, 0));
            pictureBox1.Image = bitmap;
        }


    }
}
