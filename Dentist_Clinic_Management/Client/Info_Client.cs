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

namespace Dentist_Clinic_Management.Client
{
    public partial class Info_Client : Form
    {
        public Info_Client()
        {
            InitializeComponent();
            tb_Name.Text = AccountDAO.Instance.GetClientName(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Birth.Text = ClientDAO.Instance.GetClientBirth(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Phone.Text = ClientDAO.Instance.GetClientPhone(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Address.Text = ClientDAO.Instance.GetClientAddr(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            Info_Client_Update info_Client_Update = new Info_Client_Update();
            this.Hide();
            info_Client_Update.ShowDialog();
            this.Show();
        }

        private void bt_Beck_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
