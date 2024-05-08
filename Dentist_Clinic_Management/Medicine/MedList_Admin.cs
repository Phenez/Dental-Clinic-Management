using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management;
using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Medicine
{
    public partial class MedList_Admin : Form
    {
        BindingSource medicineListt = new BindingSource();
        public MedList_Admin()
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

        private void tb_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            AddMedicine add_Medicine = new AddMedicine();
            this.Hide();
            add_Medicine.ShowDialog();
            this.Show();
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            UpdateMedicine update_Mdc = new UpdateMedicine();
            this.Hide();
            update_Mdc.ShowDialog();
            this.Show();
        }

        private void but_Seen_Click(object sender, EventArgs e)
        {
            LoadListMedicine();
        }

        private void but_find_Click(object sender, EventArgs e)
        {
            medicineListt.DataSource = SearchMedicine(text_name_cli.Text);
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;

            if (MedicineDAO.Instance.DeleteMedicine(id))
            {
                LoadListMedicine();
            }
            else
            {
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
