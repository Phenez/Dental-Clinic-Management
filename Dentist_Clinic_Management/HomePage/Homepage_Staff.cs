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

namespace Dentist_Clinic_Management.HomePage
{
    public partial class Homepage_Staff : Form
    {
        public Homepage_Staff()
        {
            InitializeComponent();
            textBox1.Text = AccountDAO.Instance.GetOtherName(AccountDAO.Instance.ID);
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnShowForm.Controls.Add(childForm);
            pnShowForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void C_bt_ViewProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.Info_Staff());
        }

        private void C_bt_AddAppointment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.Appointment_Staff());
        }

        private void C_bt_ViewMedicine_Click(object sender, EventArgs e)
        {
        }

        private void C_bt_PatientRecord_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.PatientRecord_Staff());
        }
        private void C_bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void C_pc_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff.Med_List_Seen med_List_Seen = new Staff.Med_List_Seen();
            this.Hide();
            med_List_Seen.ShowDialog();
            this.Show();
        }
    }
}