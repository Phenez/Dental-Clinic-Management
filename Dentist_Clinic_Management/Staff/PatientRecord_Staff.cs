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

namespace Dentist_Clinic_Management.Staff
{

    public partial class PatientRecord_Staff : Form
    {
        BindingSource RecList = new BindingSource();
        public PatientRecord_Staff()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dataGridView1.DataSource = RecList;
            LoadListRec();
            AddRecBiding();
        }
        void LoadListRec()
        {
            RecList.DataSource = AppointDAO.Instance.GetListRec();
        }
        void AddRecBiding()
        {
            textBox5.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "BenhNhan"));
            textBox9.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "NgayGioKham"));
            textBox8.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DichVuKham"));
            textBox7.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "PhiKham"));
            textBox6.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenThuoc"));
            textBox10.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoLuong"));
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            lb_success.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phone = txbPhoneNum.Text;
            RecList.DataSource = AppointDAO.Instance.FindListRec(phone);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadListRec();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
        }
    }
}