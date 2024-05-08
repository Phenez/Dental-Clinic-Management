using Dentist_Clinic_Management.DAO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Users
{
    public partial class AccountAdmin : Form
    {
        public AccountAdmin()
        {
            InitializeComponent();
            Load();
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Load()
        {
            tb_account.Text = AccountDAO.Instance.ID;
            tb_pass.Text = AccountDAO.Instance.Pass;
        }

        private void but_changepass_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }
    }
}
