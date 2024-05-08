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

namespace Dentist_Clinic_Management.Medicine
{
    public partial class UpdateMedicine : Form
    {

        public UpdateMedicine()
        {
            InitializeComponent();
            LoadListMedicine();
            AddMedicineBiding();
        }
        void LoadListMedicine()
        {
            data_list_medi.DataSource = MedicineDAO.Instance.GetListMedicine();
        }
        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void AddMedicineBiding()
        {
            tb_id.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "IDThuoc"));
            tb_name.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Ten_Thuoc"));
            tb_detail.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Chi_Dinh"));
            tb_cost.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Don_Gia"));
            tb_unit.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "DonVi_Tinh"));
            tb_avail.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Luong_Ton_Kho"));
            tb_expired.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Ngay_HetHan"));
        }
        private void but_Update_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string detail = tb_detail.Text;
            string unit = tb_unit.Text;
            double cost = double.Parse(tb_cost.Text);
            int available = int.Parse(tb_avail.Text);
            DateTime enddate = tb_expired.Value;
            if (MedicineDAO.Instance.UpdateMedicine(id, name, detail, unit, cost, available, enddate))
            {
                LoadListMedicine();
            }
            else
            {
            }

        }

        private void but_Seen_Click(object sender, EventArgs e)
        {
            LoadListMedicine();
        }

        private void pic_Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
