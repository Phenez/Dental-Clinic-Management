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
    public partial class Update_Client : Form
    {
        BindingSource RecList = new BindingSource();
        public Update_Client()
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
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaKH"));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "BenhNhan"));
            tb_Date.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "NgayGioKham"));
            tb_Use.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DichVuKham"));
            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "PhiKham"));
        }
       
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Dentist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_Success_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text;
            string name = textBox2.Text;
            string use = tb_Use.Text;
            double phi = double.Parse(textBox1.Text);
            if(ClientDAO.Instance.Update_Rec(id, name, use, phi))
            {
                LoadListRec();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
