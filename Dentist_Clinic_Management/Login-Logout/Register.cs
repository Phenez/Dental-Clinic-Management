using Dentist_Clinic_Management.DAO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Login_Logout
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void pt_lg_Unhide_Click(object sender, EventArgs e)
        {
            tb_rg_pw.UseSystemPasswordChar = true;
            pt_lg_Unhide.Visible = false;
            pc_lg_Hide.Visible = true;
        }

        private void pc_lg_Hide_Click(object sender, EventArgs e)
        {
            tb_rg_pw.UseSystemPasswordChar = false;
            pt_lg_Unhide.Visible = true;
            pc_lg_Hide.Visible = false;
        }

        private void bt_rg_Register_Click(object sender, EventArgs e)
        {
            string name = tb_rg_Name.Text;
            DateTime birth = dateTime_rg.Value;
            string addr = tb_rg_Address.Text;
            string phone = tb_rg_Phone.Text;
            string pass = tb_rg_pw.Text;
            if (tb_rg_pw.Text != tb_rg_pw_ag.Text)
            {
                Warming_Admin.Failed failed = new Warming_Admin.Failed();
                failed.Show();
            }
            else if (AccountDAO.Instance.Insert_Account(name, birth, addr, phone, pass))
            {
                ln_Rg_Success.Visible = true;
                bt_rg_Login.Visible = true;
            }
        }

        private void bt_rg_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTime_rg_ValueChanged(object sender, EventArgs e)
        {
            dateTime_rg.MaxDate = DateTime.Now;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pc_Lg_Deco2_Click(object sender, EventArgs e)
        {

        }

        private void bt_rgr_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tb_rg_pw_ag.UseSystemPasswordChar = false;
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tb_rg_pw_ag.UseSystemPasswordChar = true;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }
    }
}
