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

namespace Dentist_Clinic_Management.Dentist
{
    public partial class Info_Dentist_Update : Form
    {
        public Info_Dentist_Update()
        {
            InitializeComponent();
            lb_failed.Hide();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            string id = AccountDAO.Instance.ID;
            string name = tb_Name.Text;
            string specialize = tb_specialize.Text;
            string pass = tb_newPass.Text;
            if (tb_oldPass.Text != AccountDAO.Instance.Pass || pass != tb_reenter.Text)
            {
                lb_failed.Show();
            }
            else if (DentistDAO.Instance.UpdateDentist(id, name, pass, specialize))
            {
                this.Close();
            }
        }
    }
}
