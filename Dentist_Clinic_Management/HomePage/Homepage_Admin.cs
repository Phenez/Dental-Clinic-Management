using Dentist_Clinic_Management.DAO_Dentist_Clinic_Management;
using Dentist_Clinic_Management.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.HomePage
{
    public partial class Homepage_Admin : Form
    {
        public Homepage_Admin()
        {
            InitializeComponent();
            tex_role.Text = AccountDAO.Instance.GetOtherName(AccountDAO.Instance.ID);
        }


        private void bt_accountmanager_Click(object sender, EventArgs e)
        {
            Users.UserList_Admin user_Records = new Users.UserList_Admin();
            this.Hide();
            user_Records.ShowDialog();
            this.Show();
        }

        private void but_medicine_Click(object sender, EventArgs e)
        {
            Medicine.MedList_Admin patient_Records = new Medicine.MedList_Admin();
            this.Hide();
            patient_Records.ShowDialog();
            this.Show();

        }
        private void but_account_Click(object sender, EventArgs e)
        {
            AccountAdmin accountAdmin = new AccountAdmin();
            accountAdmin.ShowDialog();
        }

        private void tex_role_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
