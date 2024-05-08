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
    public partial class Appointment_NoAccount : Form
    {

        public Appointment_NoAccount()
        {
            InitializeComponent();
        }
        DateTime date_chosse;
        void LoadListDentist(DateTime date)
        {
            tb_dentist.DataSource = AppointDAO.Instance.GetListDentist(date);
            tb_dentist.DisplayMember = "Hoten";
        }
        private void bt_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void bt_rg_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool Trung(string phone)
        {
            return AppointDAO.Instance.PhoneFine(phone);
        }
        private void bt_rg_Register_Click(object sender, EventArgs e)
        {
            bool Error_Register = false;
            string name = tb_name.Text;
            DateTime birth = tb_birth.Value;
            string addr = tb_addr.Text;
            string phone = tb_phone.Text;
            string id2 = AppointDAO.Instance.GetIDDentist(tb_dentist.Text);
            DateTime date = date_chosse;
            if (Trung(phone))
            {
                Warming_Admin.Failed failed = new Warming_Admin.Failed();
                failed.Show();
            }
            else
            {
                if (AppointDAO.Instance.Insert_Appoint_NoAcc(name, birth, addr, phone, id2, date))
                {
                    ln_Success.Visible = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tb_date_ValueChanged(object sender, EventArgs e)
        {
            AppointDAO.Instance.Day = tb_date.Value.ToString("dd/MM/yyyy");
            DateTime tmp1 = tb_date.Value;
            DateTime tmp2 = tb_time.Value;
            date_chosse = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, tmp2.Hour, tmp2.Minute, 0);

            LoadListDentist(date_chosse);
        }

        private void tb_time_ValueChanged(object sender, EventArgs e)
        {
            AppointDAO.Instance.Hour = tb_date.Value.ToString("HH:mm");
            DateTime tmp1 = tb_date.Value;
            DateTime tmp2 = tb_time.Value;
            date_chosse = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, tmp2.Hour, tmp2.Minute, 0);
            LoadListDentist(date_chosse);
        }
    }
}
