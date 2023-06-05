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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRentAdmin.Feature
{
    public partial class ManUser : Form
    {
        List<Label> labels = new List<Label>();
        List<User> users = new List<User>();
        List<String> listfilter = new List<string>() { "user_id", "name", "username", "level" };
        int tableindex = 1;
        public ManUser()
        {
            InitializeComponent();
        }

        private void ManUser_Load(object sender, EventArgs e)
        {
            getAllUser();
        
            }

        private void addLabel()
        {
  
        }

        private User getAllUser()
        {
            var labels = (label1, label2, label3, label4, label5);
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBRentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM users";
            cmd.Connection = conn;

            User user = new User();

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    user.Id = reader.GetInt32(0);
                    user.name = reader.GetString(1);
                    user.username = reader.GetString(2);
                    user.password = reader.GetString(3);
                    user.level = reader.GetInt32(4);
                    users.Add(user);

                    var labelss = Controls.Find("label" + tableindex, true).FirstOrDefault() as Label;
                    var pictboxs = Controls.Find("pictureBox" + tableindex,true).FirstOrDefault() as PictureBox;
                    var panelss = Controls.Find("panel" + tableindex, true).FirstOrDefault() as Panel;

                    var imagespath = Path.Combine(Application.StartupPath, "Images", "Profile.jpg");
                    if (labelss != null)
                    {
                        labelss.Text = user.name;
                        pictboxs.Image = Image.FromFile(imagespath);
                        panelss.Show();
                    }
                    tableindex++;
                }
                conn.Close();
                return null;
            }
        }

        private User getFilter(String filter, string value)
        {
            var labels = (label1, label2, label3, label4, label5);
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBRentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"SELECT * FROM users WHERE {filter} LIKE '%{value}%'";
            cmd.Connection = conn;

            User user = new User();

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    user.Id = reader.GetInt32(0);
                    user.name = reader.GetString(1);
                    user.username = reader.GetString(2);
                    user.password = reader.GetString(3);
                    user.level = reader.GetInt32(4);
                    users.Add(user);

                    var labelss = Controls.Find("label" + tableindex, true).FirstOrDefault() as Label;
                    var pictboxs = Controls.Find("pictureBox" + tableindex, true).FirstOrDefault() as PictureBox;
                    var panelss = Controls.Find("panel" + tableindex, true).FirstOrDefault() as Panel;

                    var imagespath = Path.Combine(Application.StartupPath, "Images", "Profile.jpg");
                    if (labelss != null)
                    {
                        labelss.Text = user.name;
                        pictboxs.Image = Image.FromFile(imagespath);
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
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void Pannel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser(1);
            updateUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser(2);
            updateUser.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser(1002);
            updateUser.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser(1004);
            updateUser.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NotifyResetUser notifyDel = new NotifyResetUser(1);
            notifyDel.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NotifyResetUser notifyDel = new NotifyResetUser(2);
            notifyDel.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void clearUp()
        {
            for(int i = 1; i < 10;)
            {
                var labelss = Controls.Find("label" + tableindex, true).FirstOrDefault() as Label;
                labelss.Text = string.Empty;
                i++;
            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            clearUp();
            var fil = listfilter[comboBox1.SelectedIndex];
            getFilter(fil, textBox1.Text);
        }
    }
}
