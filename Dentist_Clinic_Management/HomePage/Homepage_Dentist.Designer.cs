namespace Dentist_Clinic_Management.HomePage
{
    partial class Homepage_Dentist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            main_panel = new Panel();
            panel1 = new Panel();
            tb_Clock = new TextBox();
            tb_Date = new TextBox();
            tb_Phone = new TextBox();
            tb_Address = new TextBox();
            tb_Birth = new TextBox();
            tb_Name = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lb_rg_phone = new Label();
            label2 = new Label();
            lb_rg_datebirth = new Label();
            lb_rg_Name = new Label();
            bt_ViewAll = new Button();
            button1 = new Button();
            lb_DateTime = new Label();
            tb_DateTime = new DateTimePicker();
            lb_ViewAppoint = new Label();
            data_Appoint = new DataGridView();
            C_pn_Menu = new Panel();
            C_bt_View_Cld = new Button();
            C_bt_Update = new Button();
            textBox1 = new TextBox();
            C_bt_View = new Button();
            C_pt_account = new PictureBox();
            C_pn_header = new Panel();
            lb_Lg_Info2 = new Label();
            lb_Lg_Info = new Label();
            C_pt_logo = new PictureBox();
            C_bt_Exit = new Button();
            C_pc_Exit = new PictureBox();
            main_panel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Appoint).BeginInit();
            C_pn_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)C_pt_account).BeginInit();
            C_pn_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)C_pt_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)C_pc_Exit).BeginInit();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(panel1);
            main_panel.Controls.Add(C_pn_Menu);
            main_panel.Controls.Add(C_pn_header);
            main_panel.Location = new Point(12, 12);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1111, 628);
            main_panel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tb_Clock);
            panel1.Controls.Add(tb_Date);
            panel1.Controls.Add(tb_Phone);
            panel1.Controls.Add(tb_Address);
            panel1.Controls.Add(tb_Birth);
            panel1.Controls.Add(tb_Name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lb_rg_phone);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lb_rg_datebirth);
            panel1.Controls.Add(lb_rg_Name);
            panel1.Controls.Add(bt_ViewAll);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lb_DateTime);
            panel1.Controls.Add(tb_DateTime);
            panel1.Controls.Add(lb_ViewAppoint);
            panel1.Controls.Add(data_Appoint);
            panel1.Location = new Point(259, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 517);
            panel1.TabIndex = 11;
            // 
            // tb_Clock
            // 
            tb_Clock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Clock.Location = new Point(512, 445);
            tb_Clock.Name = "tb_Clock";
            tb_Clock.ReadOnly = true;
            tb_Clock.Size = new Size(331, 36);
            tb_Clock.TabIndex = 11;
            tb_Clock.TabStop = false;
            tb_Clock.TextChanged += tb_Clock_TextChanged;
            // 
            // tb_Date
            // 
            tb_Date.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Date.Location = new Point(512, 393);
            tb_Date.Name = "tb_Date";
            tb_Date.ReadOnly = true;
            tb_Date.Size = new Size(331, 36);
            tb_Date.TabIndex = 10;
            tb_Date.TabStop = false;
            // 
            // tb_Phone
            // 
            tb_Phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Phone.Location = new Point(512, 340);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.ReadOnly = true;
            tb_Phone.Size = new Size(331, 36);
            tb_Phone.TabIndex = 11;
            tb_Phone.TabStop = false;
            tb_Phone.TextChanged += tb_Phone_TextChanged;
            // 
            // tb_Address
            // 
            tb_Address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Address.Location = new Point(512, 287);
            tb_Address.Name = "tb_Address";
            tb_Address.ReadOnly = true;
            tb_Address.Size = new Size(331, 36);
            tb_Address.TabIndex = 12;
            tb_Address.TabStop = false;
            // 
            // tb_Birth
            // 
            tb_Birth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Birth.Location = new Point(512, 232);
            tb_Birth.Name = "tb_Birth";
            tb_Birth.ReadOnly = true;
            tb_Birth.Size = new Size(331, 36);
            tb_Birth.TabIndex = 13;
            tb_Birth.TabStop = false;
            tb_Birth.TextChanged += tb_Birth_TextChanged;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(512, 174);
            tb_Name.Name = "tb_Name";
            tb_Name.ReadOnly = true;
            tb_Name.RightToLeft = RightToLeft.No;
            tb_Name.Size = new Size(331, 36);
            tb_Name.TabIndex = 14;
            tb_Name.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(363, 396);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 36;
            label3.Text = "Ngày khám";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(363, 448);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 35;
            label4.Text = "Giờ khám";
            // 
            // lb_rg_phone
            // 
            lb_rg_phone.AutoSize = true;
            lb_rg_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_phone.Location = new Point(363, 347);
            lb_rg_phone.Name = "lb_rg_phone";
            lb_rg_phone.Size = new Size(139, 30);
            lb_rg_phone.TabIndex = 30;
            lb_rg_phone.Text = "Ngày đặt lịch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(363, 290);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 28;
            label2.Text = "Nhân viên";
            // 
            // lb_rg_datebirth
            // 
            lb_rg_datebirth.AutoSize = true;
            lb_rg_datebirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_datebirth.Location = new Point(361, 235);
            lb_rg_datebirth.Name = "lb_rg_datebirth";
            lb_rg_datebirth.Size = new Size(72, 30);
            lb_rg_datebirth.TabIndex = 26;
            lb_rg_datebirth.Text = "Nha sĩ";
            // 
            // lb_rg_Name
            // 
            lb_rg_Name.AutoSize = true;
            lb_rg_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_Name.Location = new Point(363, 177);
            lb_rg_Name.Name = "lb_rg_Name";
            lb_rg_Name.Size = new Size(115, 30);
            lb_rg_Name.TabIndex = 24;
            lb_rg_Name.Text = "Bệnh nhân";
            // 
            // bt_ViewAll
            // 
            bt_ViewAll.BackColor = Color.FromArgb(8, 48, 107);
            bt_ViewAll.ForeColor = Color.White;
            bt_ViewAll.Location = new Point(18, 93);
            bt_ViewAll.Name = "bt_ViewAll";
            bt_ViewAll.Size = new Size(136, 45);
            bt_ViewAll.TabIndex = 5;
            bt_ViewAll.TabStop = false;
            bt_ViewAll.Text = "Xem tất cả";
            bt_ViewAll.UseVisualStyleBackColor = false;
            bt_ViewAll.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 48, 107);
            button1.ForeColor = Color.White;
            button1.Location = new Point(707, 93);
            button1.Name = "button1";
            button1.Size = new Size(136, 45);
            button1.TabIndex = 4;
            button1.TabStop = false;
            button1.Text = "Xem";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lb_DateTime
            // 
            lb_DateTime.AutoSize = true;
            lb_DateTime.Location = new Point(363, 103);
            lb_DateTime.Name = "lb_DateTime";
            lb_DateTime.Size = new Size(117, 30);
            lb_DateTime.TabIndex = 3;
            lb_DateTime.Text = "Chọn ngày";
            // 
            // tb_DateTime
            // 
            tb_DateTime.CustomFormat = "dd/MM/yyyy";
            tb_DateTime.Format = DateTimePickerFormat.Custom;
            tb_DateTime.Location = new Point(492, 97);
            tb_DateTime.Name = "tb_DateTime";
            tb_DateTime.Size = new Size(203, 36);
            tb_DateTime.TabIndex = 2;
            tb_DateTime.TabStop = false;
            tb_DateTime.Value = new DateTime(2023, 12, 22, 14, 20, 13, 0);
            // 
            // lb_ViewAppoint
            // 
            lb_ViewAppoint.AutoSize = true;
            lb_ViewAppoint.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ViewAppoint.ForeColor = Color.FromArgb(8, 48, 107);
            lb_ViewAppoint.Location = new Point(315, 22);
            lb_ViewAppoint.Name = "lb_ViewAppoint";
            lb_ViewAppoint.Size = new Size(145, 30);
            lb_ViewAppoint.TabIndex = 1;
            lb_ViewAppoint.Text = "Xem lịch hẹn";
            // 
            // data_Appoint
            // 
            data_Appoint.BackgroundColor = Color.White;
            data_Appoint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_Appoint.Location = new Point(18, 174);
            data_Appoint.Name = "data_Appoint";
            data_Appoint.RowHeadersWidth = 51;
            data_Appoint.RowTemplate.Height = 29;
            data_Appoint.Size = new Size(338, 309);
            data_Appoint.TabIndex = 0;
            data_Appoint.CellContentClick += dataGridView1_CellContentClick;
            // 
            // C_pn_Menu
            // 
            C_pn_Menu.BackColor = Color.FromArgb(8, 48, 107);
            C_pn_Menu.Controls.Add(C_bt_View_Cld);
            C_pn_Menu.Controls.Add(C_bt_Update);
            C_pn_Menu.Controls.Add(textBox1);
            C_pn_Menu.Controls.Add(C_bt_View);
            C_pn_Menu.Controls.Add(C_pt_account);
            C_pn_Menu.Location = new Point(0, 100);
            C_pn_Menu.Name = "C_pn_Menu";
            C_pn_Menu.Size = new Size(253, 528);
            C_pn_Menu.TabIndex = 10;
            // 
            // C_bt_View_Cld
            // 
            C_bt_View_Cld.BackColor = Color.FromArgb(191, 215, 251);
            C_bt_View_Cld.FlatAppearance.BorderColor = Color.FromArgb(191, 215, 251);
            C_bt_View_Cld.FlatStyle = FlatStyle.Flat;
            C_bt_View_Cld.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            C_bt_View_Cld.Location = new Point(19, 407);
            C_bt_View_Cld.Name = "C_bt_View_Cld";
            C_bt_View_Cld.Size = new Size(217, 47);
            C_bt_View_Cld.TabIndex = 7;
            C_bt_View_Cld.Text = "Lịch cá nhân";
            C_bt_View_Cld.UseVisualStyleBackColor = false;
            C_bt_View_Cld.Click += C_bt_View_Cld_Click;
            // 
            // C_bt_Update
            // 
            C_bt_Update.BackColor = Color.FromArgb(191, 215, 251);
            C_bt_Update.FlatAppearance.BorderColor = Color.FromArgb(191, 215, 251);
            C_bt_Update.FlatStyle = FlatStyle.Flat;
            C_bt_Update.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            C_bt_Update.Location = new Point(19, 323);
            C_bt_Update.Name = "C_bt_Update";
            C_bt_Update.Size = new Size(217, 47);
            C_bt_Update.TabIndex = 6;
            C_bt_Update.Text = "Hồ sơ bệnh nhân";
            C_bt_Update.UseVisualStyleBackColor = false;
            C_bt_Update.Click += C_bt_Update_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(8, 48, 107);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(3, 184);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(247, 25);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // C_bt_View
            // 
            C_bt_View.BackColor = Color.FromArgb(191, 215, 251);
            C_bt_View.FlatAppearance.BorderColor = Color.FromArgb(191, 215, 251);
            C_bt_View.FlatStyle = FlatStyle.Flat;
            C_bt_View.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            C_bt_View.Location = new Point(19, 241);
            C_bt_View.Name = "C_bt_View";
            C_bt_View.Size = new Size(217, 47);
            C_bt_View.TabIndex = 0;
            C_bt_View.Text = "Thông tin cá nhân";
            C_bt_View.UseVisualStyleBackColor = false;
            C_bt_View.Click += C_bt_View_Click;
            // 
            // C_pt_account
            // 
            C_pt_account.BackColor = Color.FromArgb(8, 48, 107);
            C_pt_account.Image = Properties.Resources.doctor__1_;
            C_pt_account.Location = new Point(30, 0);
            C_pt_account.Name = "C_pt_account";
            C_pt_account.Size = new Size(193, 178);
            C_pt_account.SizeMode = PictureBoxSizeMode.Zoom;
            C_pt_account.TabIndex = 4;
            C_pt_account.TabStop = false;
            // 
            // C_pn_header
            // 
            C_pn_header.BackColor = Color.FromArgb(8, 48, 107);
            C_pn_header.Controls.Add(lb_Lg_Info2);
            C_pn_header.Controls.Add(lb_Lg_Info);
            C_pn_header.Controls.Add(C_pt_logo);
            C_pn_header.Controls.Add(C_bt_Exit);
            C_pn_header.Controls.Add(C_pc_Exit);
            C_pn_header.Location = new Point(0, 0);
            C_pn_header.Name = "C_pn_header";
            C_pn_header.Size = new Size(1111, 102);
            C_pn_header.TabIndex = 8;
            // 
            // lb_Lg_Info2
            // 
            lb_Lg_Info2.AutoSize = true;
            lb_Lg_Info2.BackColor = Color.FromArgb(8, 48, 107);
            lb_Lg_Info2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Lg_Info2.ForeColor = Color.White;
            lb_Lg_Info2.Location = new Point(110, 49);
            lb_Lg_Info2.Name = "lb_Lg_Info2";
            lb_Lg_Info2.Size = new Size(260, 30);
            lb_Lg_Info2.TabIndex = 9;
            lb_Lg_Info2.Text = "DASHBOARD - DENTIST";
            // 
            // lb_Lg_Info
            // 
            lb_Lg_Info.AutoSize = true;
            lb_Lg_Info.BackColor = Color.FromArgb(8, 48, 107);
            lb_Lg_Info.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Lg_Info.ForeColor = Color.White;
            lb_Lg_Info.Location = new Point(110, 12);
            lb_Lg_Info.Name = "lb_Lg_Info";
            lb_Lg_Info.Size = new Size(437, 30);
            lb_Lg_Info.TabIndex = 8;
            lb_Lg_Info.Text = "Phòng khám nha khoa Khoa học tự nhiên";
            // 
            // C_pt_logo
            // 
            C_pt_logo.BackColor = Color.FromArgb(8, 48, 107);
            C_pt_logo.Image = Properties.Resources.Dental_Logo_2;
            C_pt_logo.Location = new Point(3, 3);
            C_pt_logo.Name = "C_pt_logo";
            C_pt_logo.Size = new Size(101, 80);
            C_pt_logo.SizeMode = PictureBoxSizeMode.Zoom;
            C_pt_logo.TabIndex = 7;
            C_pt_logo.TabStop = false;
            // 
            // C_bt_Exit
            // 
            C_bt_Exit.BackColor = Color.FromArgb(8, 48, 107);
            C_bt_Exit.FlatAppearance.BorderColor = Color.Navy;
            C_bt_Exit.FlatStyle = FlatStyle.Flat;
            C_bt_Exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            C_bt_Exit.ForeColor = Color.White;
            C_bt_Exit.Location = new Point(898, 19);
            C_bt_Exit.Name = "C_bt_Exit";
            C_bt_Exit.Size = new Size(133, 48);
            C_bt_Exit.TabIndex = 6;
            C_bt_Exit.TabStop = false;
            C_bt_Exit.Text = "Đăng xuất";
            C_bt_Exit.UseVisualStyleBackColor = false;
            C_bt_Exit.Click += C_bt_Exit_Click;
            // 
            // C_pc_Exit
            // 
            C_pc_Exit.Image = Properties.Resources.logout_2;
            C_pc_Exit.Location = new Point(1037, 19);
            C_pc_Exit.Name = "C_pc_Exit";
            C_pc_Exit.Size = new Size(51, 49);
            C_pc_Exit.SizeMode = PictureBoxSizeMode.Zoom;
            C_pc_Exit.TabIndex = 5;
            C_pc_Exit.TabStop = false;
            C_pc_Exit.Click += C_pc_Exit_Click;
            // 
            // Homepage_Dentist
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1135, 652);
            ControlBox = false;
            Controls.Add(main_panel);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "Homepage_Dentist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            main_panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_Appoint).EndInit();
            C_pn_Menu.ResumeLayout(false);
            C_pn_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)C_pt_account).EndInit();
            C_pn_header.ResumeLayout(false);
            C_pn_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)C_pt_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)C_pc_Exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private Panel C_pn_header;
        private Button C_bt_Exit;
        private PictureBox C_pc_Exit;
        private Label lb_Lg_Info2;
        private Label lb_Lg_Info;
        private PictureBox C_pt_logo;
        private Panel C_pn_Menu;
        private Button C_bt_View_Cld;
        private Button C_bt_Update;
        private TextBox textBox1;
        private Button C_bt_View;
        private PictureBox C_pt_account;
        private Panel panel1;
        private Button bt_ViewAll;
        private Button button1;
        private Label lb_DateTime;
        private DateTimePicker tb_DateTime;
        private Label lb_ViewAppoint;
        private DataGridView data_Appoint;
        private TextBox tb_Name;
        private Label label3;
        private Label label4;
        private TextBox tb_Date;
        private TextBox tb_Clock;
        private Label lb_rg_phone;
        private Label label2;
        private Label lb_rg_datebirth;
        private Label lb_rg_Name;
        private TextBox tb_Birth;
        private TextBox tb_Address;
        private TextBox tb_Phone;
    }
}