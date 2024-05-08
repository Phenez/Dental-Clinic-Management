using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management;
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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            LoadListCustomer();
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadListCustomer()
        {
            data_list_customer.DataSource = PatientDAO.Instance.GetPatientList();
        }

        private void but_Add_cus_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string pass = tb_pass.Text;
            DateTime dob = tb_dob.Value;
            string addr = tb_diachi.Text;
            string sdt = tb_sdt.Text;
            if (PatientDAO.Instance.InsertPatient(id, name, pass, dob, addr, sdt))
                LoadListCustomer();
        }

        private void but_Seen_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
        }
    }
}
