using CarRentAdmin.Feature;
using CarRentAdmin.Helper;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CarRentAdmin
{
    public partial class MainAdmin : Form
    {

        Form formchild;
        int user_id;
        public MainAdmin(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAdd(Form form)
        {
            panel3.Show();
            panel4.Show();
            if (formchild != null)
            {
                formchild.Close();
            }
            form.TopLevel = false;
            formchild = form;
            form.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(formchild);
            PanelDesktop.Tag = formchild;
            form.BringToFront();
            form.Show();
        }

        private void BtnManUser_Click(object sender, EventArgs e)
        {
            FormAdd(new ManUser());
            TbTitle.Text = "Manajemen User";
        }

        private void BtnManMobil_Click(object sender, EventArgs e)
        {
            FormAdd(new ManCars());
            TbTitle.Text = "Manajemen Mobil";
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Hide();
       
            var test = customersTableAdapter1.getCostumerCount();
            LbMember.Text = getConnect("customers").ToString();
            LbTransaksi.Text = getConnect("transactions").ToString();
            LbEmployee.Text = getConnect("users").ToString();
            DataSet data = new DataSet();
            data.Tables.Add(LbMember.Text, "Customer");
            data.Tables.Add(LbTransaksi.Text, "Transaksi");
            data.Tables.Add(LbEmployee.Text, "Karyawan");
            chart1.Series.Add("Customer");
            chart1.Series.Add("Transaksi");
            chart1.Series.Add("Karyawan");
            chart1.DataSource = data;
            chart1.DataBind();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            formchild.Close();
            panel3.Hide();
            panel4.Hide();
        }

        private void BtnOption_Click(object sender, EventArgs e)
        {
            FormAdd(new Option(user_id));
            TbTitle.Text = "Pengaturan Akun";
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            NotifyLogout logout = new NotifyLogout();
            logout.Show();
        }

        private int getConnect(string konteks)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBRentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {konteks}", conn);

            conn.Open();
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    return (int)read.GetInt32(0);
                }
                return 0;
            }
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            FormAdd(new HistoryTransaksi());
            TbTitle.Text = "History Transaksi";
        }

        private void Form_close_click(object sender, FormClosingEventArgs e)
        {

        }

        private void BtnManCustomer_Click(object sender, EventArgs e)
        {
            FormAdd(new ManCostumer());
            TbTitle.Text = "Manajemen Pelanggan";
        }

        private void BtnManIden_Click(object sender, EventArgs e)
        {
            FormAdd(new ManJenisIden());
            TbTitle.Text = "Manajemen Jenis Identitas";
        }

        private void PanelDesktop_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
