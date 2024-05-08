using Dentist_Clinic_Management.DAO_Dentist_Clinic_Management;
using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management;
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
    public partial class Homepage_Dentist : Form
    {
        BindingSource appointListt = new BindingSource();
        public Homepage_Dentist()
        {
            InitializeComponent();
            Load();
            textBox1.Text = AccountDAO.Instance.GetOtherName(AccountDAO.Instance.ID);
            tb_Birth.Text = AccountDAO.Instance.GetOtherName(AccountDAO.Instance.ID);
        }
        void Load()
        {
            data_Appoint.DataSource = appointListt;
            LoadListAppoint();
            AddAppointBiding();
        }
        void LoadListAppoint()
        {
            appointListt.DataSource = DentistDAO.Instance.GetFullList(AccountDAO.Instance.ID);
        }
        void AddAppointBiding()
        {
            tb_Name.DataBindings.Add(new Binding("Text", data_Appoint.DataSource, "BenhNhan"));
            tb_Date.DataBindings.Add(new Binding("Text", data_Appoint.DataSource, "NgayGioHen", true, DataSourceUpdateMode.OnPropertyChanged, "", "dd/MM/yyyy"));
            tb_Clock.DataBindings.Add(new Binding("Text", data_Appoint.DataSource, "NgayGioHen", true, DataSourceUpdateMode.OnPropertyChanged, "", "HH:mm:ss"));
            tb_Address.DataBindings.Add(new Binding("Text", data_Appoint.DataSource, "NhanVien"));
            tb_Phone.DataBindings.Add(new Binding("Text", data_Appoint.DataSource, "NgayDatLich", true, DataSourceUpdateMode.OnPropertyChanged, "", "dd/MM/yyyy"));
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadListAppoint();
        }

        private void tb_Birth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Clock_TextChanged(object sender, EventArgs e)
        {

        }

        private void C_bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void C_pc_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void C_bt_View_Click(object sender, EventArgs e)
        {
            Dentist.Info_Dentist info_Dentist = new Dentist.Info_Dentist();
            info_Dentist.ShowDialog();
        }

        private void C_bt_Update_Click(object sender, EventArgs e)
        {
            Dentist.Update_Info_Client update_Info_Client = new Dentist.Update_Info_Client();
            update_Info_Client.ShowDialog();
        }

        private void C_bt_View_Cld_Click(object sender, EventArgs e)
        {
            Dentist.Update_Schedule update_Schedule = new Dentist.Update_Schedule();
            update_Schedule.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            appointListt.DataSource = DentistDAO.Instance.GetListAppo(tb_DateTime.Value.Date, AccountDAO.Instance.ID);
        }
    }
}
