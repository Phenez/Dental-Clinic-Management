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
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
            LoadListMedicine();
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadListMedicine()
        {
            data_list_patient.DataSource = MedicineDAO.Instance.GetListMedicine();
        }
        private void but_Add_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string detail = tb_detail.Text;
            string unit = tb_unit.Text;
            double cost = double.Parse(tb_cost.Text);
            int available = int.Parse(tb_avail.Text);
            DateTime enddate = tb_expired.Value;
            if (MedicineDAO.Instance.InsertMedicine(id, name, detail, unit, cost, available, enddate))
            {
                LoadListMedicine();
                //label1.Visible = false;
            }
            else
            {
                //label1.Visible = true;
            }

        }

        private void but_Seen_Click(object sender, EventArgs e)
        {
            LoadListMedicine();
        }
    }
}
