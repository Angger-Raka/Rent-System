using CarRentAdmin.DBRentSystemDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentAdmin.Feature
{
    public partial class ListKatalog : Form
    {
        int listcount = 8;
        public ListKatalog()
        {
            InitializeComponent();
        }

        private void ListKatalog_Load(object sender, EventArgs e)
        {
            
        }
        private void resetKatalog()
        {
            carsTableAdapter carsadapter = new carsTableAdapter();
            DataTable table = carsadapter.GetDataByCars().Columns["brand"].Table;
           
        }
    }
}
