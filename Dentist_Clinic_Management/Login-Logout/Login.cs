using Dentist_Clinic_Management.DAO_Dentist_Clinic_Management;
using Dentist_Clinic_Management.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Login_Logout
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        bool Login_Success(string user, string pass, string role)
        {
            return AccountDAO.Instance.login(user, pass, role);
        }

        bool Have_Lock(string user, string pass, string role)
        {
            return AccountDAO.Instance.account_lock(user, pass, role);
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pc_lg_Hide_Click(object sender, EventArgs e)
        {
            tb_Hp_Login_Password.UseSystemPasswordChar = false;
            pt_lg_Unhide.Visible = true;
            pc_lg_Hide.Visible = false;
        }

        private void pt_lg_Unhide_Click(object sender, EventArgs e)
        {
            tb_Hp_Login_Password.UseSystemPasswordChar = true;
            pc_lg_Hide.Visible = true;
            pt_lg_Unhide.Visible = false;
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void bt_Lg_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Hp_Login_Username.Text;
            string password = tb_Hp_Login_Password.Text;

            AccountDAO.Instance.Pass = password;

            string role = "2";
            if (role == "2")
            {
                if (Have_Lock(username, password, role))
                {
                    Warming_Admin.Lock_Account lock_ = new Warming_Admin.Lock_Account();
                    lock_.ShowDialog();
                }
                else if (Login_Success(username, password, role))
                {
                    AccountDAO.Instance.ID = username;
                    AccountDAO.Instance.Pass = password;
                    HomePage.Homepage_Dentist homepage_Dentist = new HomePage.Homepage_Dentist();
                    this.Hide();
                    homepage_Dentist.ShowDialog();
                    this.Show();
                }
                else role = "1";

            }
            if (role == "1")
            {
                if (Have_Lock(username, password, role))
                {
                    Warming_Admin.Lock_Account lock_ = new Warming_Admin.Lock_Account();
                    lock_.ShowDialog();
                }
                else if (Login_Success(username, password, role))
                {
                    AccountDAO.Instance.ID = username;
                    AccountDAO.Instance.Pass = password;
                    HomePage.Homepage_Staff homepage_Staff = new HomePage.Homepage_Staff();
                    this.Hide();
                    homepage_Staff.ShowDialog();
                    this.Show();
                }
                else
                {
                    role = "3";
                }
            }
            if (role == "3")
            {
                if (Have_Lock(username, password, role))
                {
                    Warming_Admin.Lock_Account lock_ = new Warming_Admin.Lock_Account();
                    lock_.ShowDialog();
                }
                else if (Login_Success(username, password, role))
                {
                    AccountDAO.Instance.ID = ClientDAO.Instance.GetClientID(username, password);
                    AccountDAO.Instance.Pass = password;
                    ClientDAO.Instance.Phone = username;
                    HomePage.Homepage_Client homepage_Client = new HomePage.Homepage_Client();
                    this.Hide();
                    homepage_Client.ShowDialog();
                    this.Show();
                }
                else
                {
                    role = "0";
                }
            }
            if (role == "0")
            {
                if (Have_Lock(username, password, role))
                {
                    Warming_Admin.Lock_Account lock_ = new Warming_Admin.Lock_Account();
                    lock_.ShowDialog();
                }
                else if (Login_Success(username, password, role))
                {
                    AccountDAO.Instance.ID = username;
                    AccountDAO.Instance.Pass = password;
                    HomePage.Homepage_Admin homepage_Admin = new HomePage.Homepage_Admin();
                    this.Hide();
                    homepage_Admin.ShowDialog();
                    this.Show();
                }
                else { role = "5"; }
            }
            if (role == "5")
            {
                Warming_Admin.Login_Failed failed = new Warming_Admin.Login_Failed();
                failed.ShowDialog();
            }
        }

        private void Login_Appoint_Click(object sender, EventArgs e)
        {

        }

        private void bt_Login_am_Click(object sender, EventArgs e)
        {
            Appointment_NoAccount appointment_NoAccount = new Appointment_NoAccount();
            this.Hide();
            appointment_NoAccount.ShowDialog();
            this.Show();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void lb_Lg_Info_Click(object sender, EventArgs e)
        {

        }

        private void lb_Lg_Info2_Click(object sender, EventArgs e)
        {

        }

        private void pn_Hp_Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pc_Lg_Deco2_Click(object sender, EventArgs e)
        {

        }

        private void pc_Lg_Deco1_Click(object sender, EventArgs e)
        {

        }

        private void tb_Hp_Login_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
