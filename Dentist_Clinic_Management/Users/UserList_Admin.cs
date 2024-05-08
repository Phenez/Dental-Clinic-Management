using Dentist_Clinic_Management.Medicine;
using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management;
using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Users
{
    public partial class UserList_Admin : Form
    {
        BindingSource customerList = new BindingSource();
        BindingSource dentistList = new BindingSource();
        BindingSource staffList = new BindingSource();
        public UserList_Admin()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            data_list_customer.DataSource = customerList;
            data_list_dentist.DataSource = dentistList;
            data_list_staff.DataSource = staffList;
            LoadLists();
            AddBindings();
        }
        void LoadLists()
        {
            customerList.DataSource = PatientDAO.Instance.GetPatientList();
            dentistList.DataSource = DentistDAO.Instance.GetDentistList();
            staffList.DataSource = StaffDAO.Instance.GetStaffList();
        }
        void AddBindings()
        {
            AddCustomerBinding();
            AddDentistBinding();
            AddStaffBinding();
        }
        void AddCustomerBinding()
        {
            tb_id_cus.DataBindings.Add(new Binding("Text", data_list_customer.DataSource, "Ma_KH"));
            tb_name_cus.DataBindings.Add(new Binding("Text", data_list_customer.DataSource, "Ho_Ten"));
            tb_account_cus.DataBindings.Add(new Binding("Text", data_list_customer.DataSource, "Sdt"));
            tb_pass_cus.DataBindings.Add(new Binding("Text", data_list_customer.DataSource, "Mat_Khau"));
            tb_role_cus.DataBindings.Add(new Binding("Text", data_list_customer.DataSource, "Vai_Tro"));
            tb_dob.DataBindings.Add(new Binding("Text", data_list_customer.DataSource, "dateoB"));
            tb_diachi.DataBindings.Add(new Binding("Text", data_list_customer.DataSource, "Dia_Chi"));
            tb_sdt.DataBindings.Add(new Binding("Text", data_list_customer.DataSource, "Sdt"));
        }
        void AddDentistBinding()
        {
            tb_id_den.DataBindings.Add(new Binding("Text", data_list_dentist.DataSource, "Ma_NS"));
            tb_name_den.DataBindings.Add(new Binding("Text", data_list_dentist.DataSource, "Ho_Ten"));
            tb_account_den.DataBindings.Add(new Binding("Text", data_list_dentist.DataSource, "Ma_NS"));
            tb_pass_den.DataBindings.Add(new Binding("Text", data_list_dentist.DataSource, "Mat_Khau"));
            tb_role_den.DataBindings.Add(new Binding("Text", data_list_dentist.DataSource, "Vai_Tro"));
            tb_specilize.DataBindings.Add(new Binding("Text", data_list_dentist.DataSource, "Chuyen_Mon"));
        }
        void AddStaffBinding()
        {
            tb_id_sta.DataBindings.Add(new Binding("Text", data_list_staff.DataSource, "Ma_NguoiDung"));
            tb_name_sta.DataBindings.Add(new Binding("Text", data_list_staff.DataSource, "Ho_Ten"));
            tb_account_sta.DataBindings.Add(new Binding("Text", data_list_staff.DataSource, "Ma_NguoiDung"));
            tb_pass_sta.DataBindings.Add(new Binding("Text", data_list_staff.DataSource, "Mat_Khau"));
            tb_role_sta.DataBindings.Add(new Binding("Text", data_list_staff.DataSource, "Vai_Tro"));
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_find_cus_Click(object sender, EventArgs e)
        {
            customerList.DataSource = PatientDAO.Instance.SearchPatient(text_name_cli_cus.Text);
        }

        private void but_Seen_cus_Click(object sender, EventArgs e)
        {
            customerList.DataSource = PatientDAO.Instance.GetPatientList();
        }
        private void but_Seen_den_Click(object sender, EventArgs e)
        {
            dentistList.DataSource = DentistDAO.Instance.GetDentistList();
        }
        private void but_Seen_sta_Click(object sender, EventArgs e)
        {
            staffList.DataSource = StaffDAO.Instance.GetStaffList();
        }
        private void but_find_den_Click(object sender, EventArgs e)
        {
            dentistList.DataSource = DentistDAO.Instance.SearchDentist(text_name_cli_den.Text);
        }

        private void but_find_sta_Click(object sender, EventArgs e)
        {
            staffList.DataSource = StaffDAO.Instance.SearchStaff(text_name_cli_sta.Text);
        }

        private void but_Add_cus_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            this.Hide();
            addCustomer.ShowDialog();
            this.Show();
        }

        private void but_Add_den_Click(object sender, EventArgs e)
        {
            AddDentist addDentist = new AddDentist();
            this.Hide();
            addDentist.ShowDialog();
            this.Show();
        }

        private void but_Add_sta_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            this.Hide();
            addStaff.ShowDialog();
            this.Show();
        }

        private void but_Update_cus_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            this.Hide();
            updateCustomer.ShowDialog();
            this.Show();
        }

        private void but_Update_den_Click(object sender, EventArgs e)
        {
            UpdateDentist updateDentist = new UpdateDentist();
            this.Hide();
            updateDentist.ShowDialog();
            this.Show();
        }

        private void but_Update_sta_Click(object sender, EventArgs e)
        {
            UpdateStaff updateStaff = new UpdateStaff();
            this.Hide();
            updateStaff.ShowDialog();
            this.Show();
        }
        private void but_del_cus_Click(object sender, EventArgs e)
        {
            string id = tb_id_cus.Text;
            if (PatientDAO.Instance.DeletePatient(id))
                customerList.DataSource = PatientDAO.Instance.GetPatientList();
        }
        private void but_del_den_Click(object sender, EventArgs e)
        {
            string id = tb_id_den.Text;
            if (DentistDAO.Instance.DeleteDentist(id))
                dentistList.DataSource = DentistDAO.Instance.GetDentistList();
        }
        private void but_del_sta_Click(object sender, EventArgs e)
        {
            string id = tb_id_sta.Text;
            if (StaffDAO.Instance.DeleteStaff(id))
                staffList.DataSource = StaffDAO.Instance.GetStaffList();
        }    
    }
}