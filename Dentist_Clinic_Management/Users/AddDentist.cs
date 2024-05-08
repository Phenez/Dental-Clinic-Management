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

namespace Dentist_Clinic_Management.Users
{
    public partial class AddDentist : Form
    {
        public AddDentist()
        {
            InitializeComponent();
            LoadListDentist();
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadListDentist()
        {
            data_list_dentist.DataSource = DentistDAO.Instance.GetDentistList();
        }

        private void but_Add_den_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string pass = tb_pass.Text; ;
            string specialize = tb_specilize.Text;
            if (DentistDAO.Instance.InsertDentist(id, name, pass, specialize))
                LoadListDentist();
        }
        private void but_Seen_Click(object sender, EventArgs e)
        {
            LoadListDentist();
        }
    }
}
