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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dentist_Clinic_Management.Dentist
{
    public partial class Add_Client : Form
    {
        BindingSource RecList = new BindingSource();
        public Add_Client()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dataGridView1.DataSource = RecList;
            LoadListRec();
        }
        void LoadListRec()
        {
            RecList.DataSource = AppointDAO.Instance.GetListRec();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;
            DateTime birth = tb_Date.Value;
            string addr = tb_Address.Text;
            string phone = tb_Phone.Text;
            if (ClientDAO.Instance.Insert_Account_D(name, birth, addr, phone))
            {
                LoadListRec();
            }
        }

        private void lb_Success_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_rg_phone_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lb_rg_datebirth_Click(object sender, EventArgs e)
        {

        }

        private void lb_rg_Name_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_rg_Addr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_rg_Name_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_rg_Phone_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
