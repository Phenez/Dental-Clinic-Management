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

namespace Dentist_Clinic_Management.HomePage
{
    public partial class Homepage_Client : Form
    {

        public Homepage_Client()
        {
            InitializeComponent();
            textBox1.Text = AccountDAO.Instance.GetClientName(ClientDAO.Instance.Phone, AccountDAO.Instance.Pass);
        }
        DateTime date_chosse;
        void LoadListDentist(DateTime date)
        {
            cb_dentist.DataSource = AppointDAO.Instance.GetListDentist(date);
            cb_dentist.DisplayMember = "Hoten";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            pc_Thank2.Visible = false;
        }

        private void C_pc_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void C_bt_View_Click(object sender, EventArgs e)
        {
            Client.Info_Client info_Client = new Client.Info_Client();
            this.Hide();
            info_Client.ShowDialog();
            this.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void lbRate1_Click(object sender, EventArgs e)
        {

        }

        private void lbRate6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool Error_Send = false;

            if (Error_Send == false)
            {
                C_lb_Thanks3.Visible = true;
                C_bt_add.Visible = true;
                C_bt_Send.Visible = false;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void C_bt_add_Click(object sender, EventArgs e)
        {
            C_lb_Thanks3.Visible = false;
            C_bt_add.Visible = false;
            C_bt_Send.Visible = true;
        }

        private void C_pn_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_rg_Name_Click(object sender, EventArgs e)
        {

        }

        private void C_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }

        private void label108_Click(object sender, EventArgs e)
        {

        }

        private void label109_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void label112_Click(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void label114_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label117_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void label94_Click(object sender, EventArgs e)
        {

        }

        private void label95_Click(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void label107_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbRate2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void C_lb_Thanks3_Click(object sender, EventArgs e)
        {

        }

        private void tbRate2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbRate3_Click(object sender, EventArgs e)
        {

        }

        private void tbRate1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbRate4_Click(object sender, EventArgs e)
        {

        }

        private void cbRate3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbRate2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ptRate1_Click(object sender, EventArgs e)
        {

        }

        private void cbRate1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ptRate3_Click(object sender, EventArgs e)
        {

        }

        private void lbRate5_Click(object sender, EventArgs e)
        {

        }

        private void ptRate2_Click(object sender, EventArgs e)
        {

        }

        private void C_pn_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void C_bt_View_Cld_Click(object sender, EventArgs e)
        {
            Client.Info_Appointment info_Appointment = new Client.Info_Appointment();
            this.Hide();
            info_Appointment.ShowDialog();
            this.Show();
        }

        private void C_bt_Update_Click(object sender, EventArgs e)
        {
            Client.Info_Client_Update info_Client_update = new Client.Info_Client_Update();
            this.Hide();
            info_Client_update.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void C_pt_account_Click(object sender, EventArgs e)
        {

        }

        private void lb_Lg_Info2_Click(object sender, EventArgs e)
        {

        }

        private void C_pt_logo_Click(object sender, EventArgs e)
        {

        }

        private void lb_Lg_Info_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_rg_phone_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void lb_rg_datebirth_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTime_rg_ValueChanged(object sender, EventArgs e)
        {
            AppointDAO.Instance.Day = C_dateTime_rg.Value.ToString("dd/MM/yyyy");
            DateTime tmp1 = C_dateTime_rg.Value;
            DateTime tmp2 = C_Hour.Value;
            date_chosse = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, tmp2.Hour, tmp2.Minute, 0);

            LoadListDentist(date_chosse);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pn_rg_Addr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pc_Lg_Un_Click(object sender, EventArgs e)
        {

        }

        private void tb_rg_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void pn_rg_Name_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pc_rg_name_Click(object sender, EventArgs e)
        {

        }

        private void tb_rg_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pn_rg_Phone_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pc_Hp_Login_Un_Click(object sender, EventArgs e)
        {

        }

        private void tb_rg_Phone_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AppointDAO.Instance.Hour = C_Hour.Value.ToString("HH:mm");
            DateTime tmp1 = C_dateTime_rg.Value;
            DateTime tmp2 = C_Hour.Value;
            date_chosse = new DateTime(tmp1.Year, tmp1.Month, tmp1.Day, tmp2.Hour, tmp2.Minute, 0);
            LoadListDentist(date_chosse);
        }

        private void bt_rg_Exit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_dentist.Text))
            {
               Warming_Admin.Failed failed = new Warming_Admin.Failed();
                failed.Show();
            }
            else
            {
                DateTime date1 = C_dateTime_rg.Value;
                DateTime date2 = C_Hour.Value;
                AppointDAO.Instance.Date = new DateTime(date1.Year, date1.Month, date1.Day, date2.Hour, date2.Minute, 0);
                AppointDAO.Instance.Dentist = cb_dentist.Text;
                AppointDAO.Instance.ID_D = AppointDAO.Instance.GetIDDentist(cb_dentist.Text);
                Client.Confirm_Appointment confirm_Appointment = new Client.Confirm_Appointment();
                this.Hide();
                confirm_Appointment.ShowDialog();
                this.Show();
            }
        }

        private void Homepage_Client_Load(object sender, EventArgs e)
        {

        }

        private void cb_dentist_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
