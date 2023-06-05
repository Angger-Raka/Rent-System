using System;
using System.Windows.Forms;

namespace CarRentAdmin.Feature
{
    public partial class Option : Form
    {
        int id;
        public Option(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Option_Load(object sender, EventArgs e)
        {

        }

        private void clearform()
        {
            TbPassNew.Text = string.Empty;
            TbPassOld.Text = string.Empty;
            TbPassNewRepeat.Text = string.Empty;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            String newpass = TbPassNew.Text;
            String oldpass = TbPassOld.Text;
            String repeat = TbPassNewRepeat.Text;

            try
            {
                if (newpass == "" || oldpass == "" || repeat == "")
                {
                    MessageBox.Show("Form Harap Diisi Terlebih Dahulu");
                }
                else
                {
                    if (newpass != repeat)
                    {
                        MessageBox.Show("Password baru tidak sama");
                    }
                    else
                    {
                        var result = usersTableAdapter1.UpdateQuery(newpass, id, oldpass, id);
                        if (result == 0)
                        {
                            MessageBox.Show("Password Lama mu salah");
                            clearform();
                        }
                        MessageBox.Show("USer Berhasil Di update");
                        clearform();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
