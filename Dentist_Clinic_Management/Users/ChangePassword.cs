using Dentist_Clinic_Management.DAO_Dentist_Clinic_Management;
using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Users
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            lab_incorrect.Hide();
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_confirm_Click(object sender, EventArgs e)
        {
            if (tb_newpass.Text!=tb_reenter.Text)
            {
                lab_incorrect.Show();
                return;
            }
            string query = string.Format("update NguoiDung set MatKhau = '{0}' where MaNguoiDung = '{1}'", tb_newpass.Text, AccountDAO.Instance.ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
                this.Close();
        }
    }
}