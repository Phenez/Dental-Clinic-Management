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

namespace Dentist_Clinic_Management.Staff
{
    public partial class AppointmentInfo_Staff : Form
    {
        public AppointmentInfo_Staff()
        {
            InitializeComponent();
            tb_Name.Text = AppointDAO.Instance.name;
            tb_Phone.Text = AppointDAO.Instance.phone;
            tb_Date.Text = AppointDAO.Instance.Day;
            tb_Clock.Text = AppointDAO.Instance.Hour;
            tb_Dentist.Text = AppointDAO.Instance.Dentist;
        }
        private void bt_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {

            lab_incorrect.Visible = true;

        }
    }
}