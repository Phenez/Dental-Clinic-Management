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

namespace Dentist_Clinic_Management.Staff
{
    public partial class Med_List_Seen : Form
    {
        BindingSource medicineListt = new BindingSource();
        public Med_List_Seen()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            data_list_medi.DataSource = medicineListt;
            LoadListMedicine();
            AddMedicineBiding();
        }
        void LoadListMedicine()
        {
            medicineListt.DataSource = MedicineDAO.Instance.GetListMedicine();
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
        List<MedicineDTO> SearchMedicine(string name)
        {
            List<MedicineDTO> listMedicine = MedicineDAO.Instance.SearchMedicine(name);
            return listMedicine;
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_find_Click(object sender, EventArgs e)
        {
            medicineListt.DataSource = SearchMedicine(text_name_cli.Text);
        }

        private void but_Seen_Click(object sender, EventArgs e)
        {
            LoadListMedicine();
        }
    }
}
