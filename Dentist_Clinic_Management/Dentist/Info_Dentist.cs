using Dentist_Clinic_Management.DAO_Dentist_Clinic_Management;
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
    public partial class Info_Dentist : Form
    {
        public Info_Dentist()
        {
            InitializeComponent();
            tb_Name.Text = AccountDAO.Instance.ID;
            tb_Birth.Text = AccountDAO.Instance.GetOtherName(AccountDAO.Instance.ID);
            tb_Address.Text = AccountDAO.Instance.GetCM(AccountDAO.Instance.ID);
        }

        private void bt_Beck_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
