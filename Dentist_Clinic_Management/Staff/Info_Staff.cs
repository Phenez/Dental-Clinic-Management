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

namespace Dentist_Clinic_Management.Staff
{
    public partial class Info_Staff : Form
    {
        public Info_Staff()
        {
            InitializeComponent();
            lab_incorrect.Hide();
            label5.Hide();
            tb_Name.Text = AccountDAO.Instance.ID;
            textBox1.Text = AccountDAO.Instance.GetOtherName(AccountDAO.Instance.ID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != AccountDAO.Instance.Pass)
            {
                lab_incorrect.Show();
                return;
            }
            string query = string.Format("update NguoiDung set MatKhau = '{0}' where MaNguoiDung = '{1}'", textBox2.Text, AccountDAO.Instance.ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
                label5.Show();
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}