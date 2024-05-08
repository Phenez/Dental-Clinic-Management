namespace Dentist_Clinic_Management.HomePage
{
    partial class Homepage_Staff
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
            C_pn_header = new Panel();
            lb_Lg_Info2 = new Label();
            lb_Lg_Info = new Label();
            C_pt_logo = new PictureBox();
            C_bt_Exit = new Button();
            C_pc_Exit = new PictureBox();
            C_pn_Menu = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            C_bt_PatientRecord = new Button();
            C_bt_AddAppointment = new Button();
            C_bt_ViewProfile = new Button();
            C_pt_account = new PictureBox();
            pnShowForm = new Panel();
            C_pn_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)C_pt_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)C_pc_Exit).BeginInit();
            C_pn_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)C_pt_account).BeginInit();
            SuspendLayout();
            // 
            // C_pn_header
            // 
            C_pn_header.BackColor = Color.FromArgb(8, 48, 107);
            C_pn_header.Controls.Add(lb_Lg_Info2);
            C_pn_header.Controls.Add(lb_Lg_Info);
            C_pn_header.Controls.Add(C_pt_logo);
            C_pn_header.Controls.Add(C_bt_Exit);
            C_pn_header.Controls.Add(C_pc_Exit);
            C_pn_header.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            C_pn_header.Location = new Point(12, 12);
            C_pn_header.Name = "C_pn_header";
            C_pn_header.Size = new Size(1111, 102);
            C_pn_header.TabIndex = 9;
            // 
            // lb_Lg_Info2
            // 
            lb_Lg_Info2.AutoSize = true;
            lb_Lg_Info2.BackColor = Color.FromArgb(8, 48, 107);
            lb_Lg_Info2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Lg_Info2.ForeColor = Color.White;
            lb_Lg_Info2.Location = new Point(110, 49);
            lb_Lg_Info2.Name = "lb_Lg_Info2";
            lb_Lg_Info2.Size = new Size(274, 30);
            lb_Lg_Info2.TabIndex = 9;
            lb_Lg_Info2.Text = "DASHBOARD - Nhân viên";
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
            // C_pn_Menu
            // 
            C_pn_Menu.BackColor = Color.FromArgb(8, 48, 107);
            C_pn_Menu.Controls.Add(button1);
            C_pn_Menu.Controls.Add(textBox1);
            C_pn_Menu.Controls.Add(C_bt_PatientRecord);
            C_pn_Menu.Controls.Add(C_bt_AddAppointment);
            C_pn_Menu.Controls.Add(C_bt_ViewProfile);
            C_pn_Menu.Controls.Add(C_pt_account);
            C_pn_Menu.Location = new Point(12, 112);
            C_pn_Menu.Name = "C_pn_Menu";
            C_pn_Menu.Size = new Size(253, 528);
            C_pn_Menu.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(191, 215, 251);
            button1.FlatAppearance.BorderColor = Color.FromArgb(191, 215, 251);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(20, 379);
            button1.Name = "button1";
            button1.Size = new Size(217, 47);
            button1.TabIndex = 10;
            button1.Text = "Danh sách thuốc";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(8, 48, 107);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(0, 154);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(247, 25);
            textBox1.TabIndex = 9;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // C_bt_PatientRecord
            // 
            C_bt_PatientRecord.BackColor = Color.FromArgb(191, 215, 251);
            C_bt_PatientRecord.FlatAppearance.BorderColor = Color.FromArgb(191, 215, 251);
            C_bt_PatientRecord.FlatStyle = FlatStyle.Flat;
            C_bt_PatientRecord.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            C_bt_PatientRecord.Location = new Point(20, 304);
            C_bt_PatientRecord.Name = "C_bt_PatientRecord";
            C_bt_PatientRecord.Size = new Size(217, 47);
            C_bt_PatientRecord.TabIndex = 8;
            C_bt_PatientRecord.Text = "Hồ sơ bệnh nhân";
            C_bt_PatientRecord.UseVisualStyleBackColor = false;
            C_bt_PatientRecord.Click += C_bt_PatientRecord_Click;
            // 
            // C_bt_AddAppointment
            // 
            C_bt_AddAppointment.BackColor = Color.FromArgb(191, 215, 251);
            C_bt_AddAppointment.FlatAppearance.BorderColor = Color.FromArgb(191, 215, 251);
            C_bt_AddAppointment.FlatStyle = FlatStyle.Flat;
            C_bt_AddAppointment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            C_bt_AddAppointment.Location = new Point(20, 233);
            C_bt_AddAppointment.Name = "C_bt_AddAppointment";
            C_bt_AddAppointment.Size = new Size(217, 47);
            C_bt_AddAppointment.TabIndex = 6;
            C_bt_AddAppointment.Text = "Đặt lịch khám";
            C_bt_AddAppointment.UseVisualStyleBackColor = false;
            C_bt_AddAppointment.Click += C_bt_AddAppointment_Click;
            // 
            // C_bt_ViewProfile
            // 
            C_bt_ViewProfile.BackColor = Color.FromArgb(191, 215, 251);
            C_bt_ViewProfile.FlatAppearance.BorderColor = Color.FromArgb(191, 215, 251);
            C_bt_ViewProfile.FlatStyle = FlatStyle.Flat;
            C_bt_ViewProfile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            C_bt_ViewProfile.Location = new Point(20, 452);
            C_bt_ViewProfile.Name = "C_bt_ViewProfile";
            C_bt_ViewProfile.Size = new Size(217, 47);
            C_bt_ViewProfile.TabIndex = 0;
            C_bt_ViewProfile.Text = "Thông tin cá nhân";
            C_bt_ViewProfile.UseVisualStyleBackColor = false;
            C_bt_ViewProfile.Click += C_bt_ViewProfile_Click;
            // 
            // C_pt_account
            // 
            C_pt_account.BackColor = Color.FromArgb(8, 48, 107);
            C_pt_account.Image = Properties.Resources.doctor__1_;
            C_pt_account.Location = new Point(57, 8);
            C_pt_account.Name = "C_pt_account";
            C_pt_account.Size = new Size(140, 141);
            C_pt_account.SizeMode = PictureBoxSizeMode.Zoom;
            C_pt_account.TabIndex = 4;
            C_pt_account.TabStop = false;
            // 
            // pnShowForm
            // 
            pnShowForm.BackColor = Color.White;
            pnShowForm.Location = new Point(265, 112);
            pnShowForm.Name = "pnShowForm";
            pnShowForm.Size = new Size(858, 528);
            pnShowForm.TabIndex = 12;
            // 
            // Homepage_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1135, 652);
            ControlBox = false;
            Controls.Add(pnShowForm);
            Controls.Add(C_pn_Menu);
            Controls.Add(C_pn_header);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Homepage_Staff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            C_pn_header.ResumeLayout(false);
            C_pn_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)C_pt_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)C_pc_Exit).EndInit();
            C_pn_Menu.ResumeLayout(false);
            C_pn_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)C_pt_account).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel C_pn_header;
        private Label lb_Lg_Info2;
        private Label lb_Lg_Info;
        private PictureBox C_pt_logo;
        private Button C_bt_Exit;
        private PictureBox C_pc_Exit;
        private Panel C_pn_Menu;
        private Button C_bt_AddAppointment;
        private Button C_bt_ViewProfile;
        private PictureBox C_pt_account;
        private Button C_bt_PatientRecord;
        private Panel pnShowForm;
        private TextBox textBox1;
        private Button button1;
    }
}