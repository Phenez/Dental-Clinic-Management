using Dentist_Clinic_Management.DAO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Client
{
    public partial class Info_Client_Update : Form
    {
        public Info_Client_Update()
        {
            InitializeComponent();
            tb_Name.Text = AccountDAO.Instance.GetClientName(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Birth.Value = DateTime.ParseExact(ClientDAO.Instance.GetClientBirth(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass) + " 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            tb_Phone.Text = ClientDAO.Instance.GetClientPhone(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Address.Text = ClientDAO.Instance.GetClientAddr(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pc_lg_Hide_Click(object sender, EventArgs e)
        {
            tb_oldPass.UseSystemPasswordChar = false;
            Hide_1.Visible = false;
            Unhide_1.Visible = true;
        }

        private void Unhide_1_Click(object sender, EventArgs e)
        {
            tb_oldPass.UseSystemPasswordChar = true;
            Hide_1.Visible = true;
            Unhide_1.Visible = false;
        }

        private void Unhide_2_Click(object sender, EventArgs e)
        {
            tb_newPass.UseSystemPasswordChar = true;
            Hide_2.Visible = true;
            Unhide_2.Visible = false;
        }

        private void Hide_2_Click(object sender, EventArgs e)
        {
            tb_newPass.UseSystemPasswordChar = false;
            Hide_2.Visible = false;
            Unhide_2.Visible = true;
        }

        private void Unhide_3_Click(object sender, EventArgs e)
        {
            tb_anewPass.UseSystemPasswordChar = true;
            Hide_3.Visible = true;
            Unhide_3.Visible = false;
        }

        private void Hide_3_Click(object sender, EventArgs e)
        {
            tb_anewPass.UseSystemPasswordChar = false;
            Hide_3.Visible = false;
            Unhide_3.Visible = true;
        }

        private void bt_Beck_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_Birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            string id = ClientDAO.Instance.GetClientID(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            string name = tb_Name.Text;
            DateTime birth = tb_Birth.Value;
            string addr = tb_Address.Text;
            string phone = tb_Phone.Text;
            string pass = tb_newPass.Text;
            if (tb_oldPass.Text != AccountDAO.Instance.Pass || tb_newPass.Text != tb_anewPass.Text)
            {
                Warming_Admin.Failed failed = new Warming_Admin.Failed();
                failed.Show();
                
            }
            else if (ClientDAO.Instance.Update_Client(id, name, birth, addr, phone, pass))
            {
                ln_Success.Visible = true;
            }
           
        }
    }
}
