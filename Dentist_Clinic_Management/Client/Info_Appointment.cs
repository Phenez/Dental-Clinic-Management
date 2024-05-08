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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dentist_Clinic_Management.Client
{
    public partial class Info_Appointment : Form
    {
        BindingSource appointListt = new BindingSource();
        public Info_Appointment()
        {
            InitializeComponent();
            Load();
            tb_Birth.Text = ClientDAO.Instance.GetClientBirth(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Phone.Text = ClientDAO.Instance.GetClientPhone(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
            tb_Address.Text = ClientDAO.Instance.GetClientAddr(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
        }
         void Load()
        {
            data_list_patient.DataSource = appointListt;
            LoadListAppoint();
            AddAppointBiding();
        }
        void LoadListAppoint()
        {
            appointListt.DataSource = AppointDAO.Instance.GetListAppoint(ClientDAO.Instance.GetClientID(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass));
        }
        void AddAppointBiding()
        {
            tb_Name.DataBindings.Add(new Binding("Text", data_list_patient.DataSource, "TrangThaiHen"));
            tb_Date.DataBindings.Add(new Binding("Text", data_list_patient.DataSource, "NgayGioHen", true, DataSourceUpdateMode.OnPropertyChanged, "", "dd/MM/yyyy"));
            tb_Clock.DataBindings.Add(new Binding("Text", data_list_patient.DataSource, "NgayGioHen", true, DataSourceUpdateMode.OnPropertyChanged, "", "HH:mm:ss"));
            tb_Dentist.DataBindings.Add(new Binding("Text", data_list_patient.DataSource, "NhaSi"));
            
        }
        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.ParseExact(tb_Date.Text + " " + tb_Clock.Text, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            if (AppointDAO.Instance.CancelAppoint(ClientDAO.Instance.GetClientID(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass), date)) 
            {
                ln_Success.Visible = true;
                LoadListAppoint();
            }
           
        }

        private void bt_Beck_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
