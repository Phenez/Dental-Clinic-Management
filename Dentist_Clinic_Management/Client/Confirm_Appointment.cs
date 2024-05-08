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
    public partial class Confirm_Appointment : Form
    {
        public Confirm_Appointment()
        {
            InitializeComponent();
            tb_Name.Text = AccountDAO.Instance.GetClientName(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Birth.Text = ClientDAO.Instance.GetClientBirth(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Phone.Text = ClientDAO.Instance.GetClientPhone(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Address.Text = ClientDAO.Instance.GetClientAddr(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Date.Text = AppointDAO.Instance.Day;
            tb_Clock.Text = AppointDAO.Instance.Hour;
            tb_Dentist.Text = AppointDAO.Instance.Dentist;
        }

       
        private void tb_rg_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_rg_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Clock_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            string id1 = ClientDAO.Instance.GetClientID(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            DateTime datea = AppointDAO.Instance.Date;
            string id2 = AppointDAO.Instance.ID_D;
            DateTime book = DateTime.Now;
            if (AppointDAO.Instance.Insert_Appoint(id1, datea, id2, book))
            {
                ln_Success.Visible = true;
            }
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
