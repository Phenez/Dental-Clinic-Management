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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dentist_Clinic_Management.Staff
{

    public partial class Appointment_Staff : Form
    {


        public Appointment_Staff()
        {
            InitializeComponent();

        }
        DateTime date_chosse;
        void LoadListDentist(DateTime date)
        {
            cb_dentist.DataSource = AppointDAO.Instance.GetListDentist(date);
            cb_dentist.DisplayMember = "Hoten";
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_dentist.Text))
            {
                Warming_Admin.Failed failed = new Warming_Admin.Failed();
                failed.Show();
            }
            else {
                DateTime date1 = dateTimePicker1.Value;
                DateTime date2 = dateTimePicker2.Value;
                AppointDAO.Instance.Date = new DateTime(date1.Year, date1.Month, date1.Day, date2.Hour, date2.Minute, 0);
                AppointDAO.Instance.Dentist = cb_dentist.Text;
                AppointDAO.Instance.ID_D = AppointDAO.Instance.GetIDDentist(cb_dentist.Text);
                AppointDAO.Instance.name = textBox1.Text;
                AppointDAO.Instance.phone = textBox2.Text;
                string name = AppointDAO.Instance.name;
                string phone = AppointDAO.Instance.phone;
                string id3 = AccountDAO.Instance.ID;
                DateTime book = DateTime.Now;
                DateTime date = AppointDAO.Instance.Date;
                string id2 = AppointDAO.Instance.ID_D;
                if (AppointDAO.Instance.Insert_Appoint_S(name, phone, id3, book, date, id2))
                {
                    Form f = new AppointmentInfo_Staff();
                    f.ShowDialog();
                }
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AppointDAO.Instance.Day = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            DateTime tmp1 = dateTimePicker1.Value;
            DateTime tmp2 = dateTimePicker2.Value;
            date_chosse = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, tmp2.Hour, tmp2.Minute, 0);

            LoadListDentist(date_chosse);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            AppointDAO.Instance.Hour = dateTimePicker2.Value.ToString("HH:mm");
            DateTime tmp1 = dateTimePicker1.Value;
            DateTime tmp2 = dateTimePicker2.Value;
            date_chosse = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, tmp2.Hour, tmp2.Minute, 0);
            LoadListDentist(date_chosse);
        }
    }
}