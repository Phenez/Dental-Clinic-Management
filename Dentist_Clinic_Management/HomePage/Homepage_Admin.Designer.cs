namespace Dentist_Clinic_Management.HomePage
{
    partial class Homepage_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage_Admin));
            panel1 = new Panel();
            main_panel = new Panel();
            pan_menu = new Panel();
            but_account = new Button();
            but_medicine = new Button();
            tex_role = new TextBox();
            bt_accountmanager = new Button();
            pic_account = new PictureBox();
            pan_header = new Panel();
            lab_info2 = new Label();
            lab_info1 = new Label();
            pic_logo = new PictureBox();
            but_exit = new Button();
            pic_exit = new PictureBox();
            panel1.SuspendLayout();
            main_panel.SuspendLayout();
            pan_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_account).BeginInit();
            pan_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_exit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(main_panel);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 597);
            panel1.TabIndex = 0;
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(pan_menu);
            main_panel.Controls.Add(pan_header);
            main_panel.Location = new Point(-7, -7);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1124, 611);
            main_panel.TabIndex = 2;
            // 
            // pan_menu
            // 
            pan_menu.BackColor = Color.FromArgb(8, 48, 107);
            pan_menu.Controls.Add(but_account);
            pan_menu.Controls.Add(but_medicine);
            pan_menu.Controls.Add(tex_role);
            pan_menu.Controls.Add(bt_accountmanager);
            pan_menu.Controls.Add(pic_account);
            pan_menu.Location = new Point(0, 103);
            pan_menu.Name = "pan_menu";
            pan_menu.Size = new Size(271, 508);
            pan_menu.TabIndex = 10;
            // 
            // but_account
            // 
            but_account.BackColor = Color.FromArgb(191, 215, 251);
            but_account.FlatAppearance.BorderColor = Color.FromArgb(191, 215, 251);
            but_account.FlatStyle = FlatStyle.Flat;
            but_account.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_account.Location = new Point(22, 418);
            but_account.Name = "but_account";
            but_account.Size = new Size(235, 45);
            but_account.TabIndex = 8;
            but_account.TabStop = false;
            but_account.Text = "Thông tin tài khoản";
            but_account.UseVisualStyleBackColor = false;
            but_account.Click += but_account_Click;
            // 
            // but_medicine
            // 
            but_medicine.BackColor = Color.FromArgb(191, 215, 251);
            but_medicine.FlatAppearance.BorderColor = Color.FromArgb(191, 215, 251);
            but_medicine.FlatStyle = FlatStyle.Flat;
            but_medicine.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_medicine.Location = new Point(22, 334);
            but_medicine.Name = "but_medicine";
            but_medicine.Size = new Size(235, 45);
            but_medicine.TabIndex = 8;
            but_medicine.TabStop = false;
            but_medicine.Text = "Quản lý thuốc";
            but_medicine.UseVisualStyleBackColor = false;
            but_medicine.Click += but_medicine_Click;
            // 
            // tex_role
            // 
            tex_role.BackColor = Color.FromArgb(8, 48, 107);
            tex_role.BorderStyle = BorderStyle.None;
            tex_role.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tex_role.ForeColor = Color.White;
            tex_role.Location = new Point(22, 184);
            tex_role.Name = "tex_role";
            tex_role.ReadOnly = true;
            tex_role.Size = new Size(235, 29);
            tex_role.TabIndex = 0;
            tex_role.TabStop = false;
            tex_role.TextAlign = HorizontalAlignment.Center;
            tex_role.TextChanged += tex_role_TextChanged;
            // 
            // bt_accountmanager
            // 
            bt_accountmanager.BackColor = Color.FromArgb(191, 215, 251);
            bt_accountmanager.FlatAppearance.BorderColor = Color.FromArgb(191, 215, 251);
            bt_accountmanager.FlatStyle = FlatStyle.Flat;
            bt_accountmanager.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            bt_accountmanager.Location = new Point(22, 254);
            bt_accountmanager.Name = "bt_accountmanager";
            bt_accountmanager.Size = new Size(235, 45);
            bt_accountmanager.TabIndex = 0;
            bt_accountmanager.TabStop = false;
            bt_accountmanager.Text = "Quản lý tài khoản";
            bt_accountmanager.UseVisualStyleBackColor = false;
            bt_accountmanager.Click += bt_accountmanager_Click;
            // 
            // pic_account
            // 
            pic_account.BackColor = Color.FromArgb(8, 48, 107);
            pic_account.ErrorImage = (Image)resources.GetObject("pic_account.ErrorImage");
            pic_account.Image = Properties.Resources.admin;
            pic_account.InitialImage = (Image)resources.GetObject("pic_account.InitialImage");
            pic_account.Location = new Point(32, 8);
            pic_account.Name = "pic_account";
            pic_account.Size = new Size(193, 169);
            pic_account.SizeMode = PictureBoxSizeMode.Zoom;
            pic_account.TabIndex = 4;
            pic_account.TabStop = false;
            // 
            // pan_header
            // 
            pan_header.BackColor = Color.FromArgb(8, 48, 107);
            pan_header.Controls.Add(lab_info2);
            pan_header.Controls.Add(lab_info1);
            pan_header.Controls.Add(pic_logo);
            pan_header.Controls.Add(but_exit);
            pan_header.Controls.Add(pic_exit);
            pan_header.Location = new Point(0, 0);
            pan_header.Name = "pan_header";
            pan_header.Size = new Size(1124, 104);
            pan_header.TabIndex = 9;
            // 
            // lab_info2
            // 
            lab_info2.AutoSize = true;
            lab_info2.BackColor = Color.FromArgb(8, 48, 107);
            lab_info2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_info2.ForeColor = Color.White;
            lab_info2.Location = new Point(110, 49);
            lab_info2.Name = "lab_info2";
            lab_info2.Size = new Size(332, 30);
            lab_info2.TabIndex = 9;
            lab_info2.Text = "DASHBOARD - QUẢN TRỊ VIÊN";
            // 
            // lab_info1
            // 
            lab_info1.AutoSize = true;
            lab_info1.BackColor = Color.FromArgb(8, 48, 107);
            lab_info1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lab_info1.ForeColor = Color.White;
            lab_info1.Location = new Point(110, 14);
            lab_info1.Name = "lab_info1";
            lab_info1.Size = new Size(428, 30);
            lab_info1.TabIndex = 8;
            lab_info1.Text = "Hệ thống quản lý phòng khám nha khoa";
            // 
            // pic_logo
            // 
            pic_logo.BackColor = Color.FromArgb(8, 48, 107);
            pic_logo.Image = Properties.Resources.Dental_Logo_2;
            pic_logo.Location = new Point(8, 9);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(101, 76);
            pic_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logo.TabIndex = 7;
            pic_logo.TabStop = false;
            // 
            // but_exit
            // 
            but_exit.BackColor = Color.FromArgb(8, 48, 107);
            but_exit.FlatAppearance.BorderColor = Color.Navy;
            but_exit.FlatStyle = FlatStyle.Flat;
            but_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_exit.ForeColor = Color.White;
            but_exit.Location = new Point(898, 18);
            but_exit.Name = "but_exit";
            but_exit.Size = new Size(133, 46);
            but_exit.TabIndex = 6;
            but_exit.TabStop = false;
            but_exit.Text = "Đăng xuất";
            but_exit.UseVisualStyleBackColor = false;
            but_exit.Click += but_exit_Click;
            // 
            // pic_exit
            // 
            pic_exit.Image = Properties.Resources.logout_2;
            pic_exit.Location = new Point(1037, 18);
            pic_exit.Name = "pic_exit";
            pic_exit.Size = new Size(51, 47);
            pic_exit.SizeMode = PictureBoxSizeMode.Zoom;
            pic_exit.TabIndex = 5;
            pic_exit.TabStop = false;
            pic_exit.Click += pic_exit_Click;
            // 
            // Homepage_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1135, 619);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Homepage_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            main_panel.ResumeLayout(false);
            pan_menu.ResumeLayout(false);
            pan_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_account).EndInit();
            pan_header.ResumeLayout(false);
            pan_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel main_panel;
        private Panel pan_menu;
        private Button but_medicine;
        private TextBox tex_role;
        private Button bt_accountmanager;
        private PictureBox pic_account;
        private Panel pan_header;
        private Label lab_info2;
        private Label lab_info1;
        private PictureBox pic_logo;
        private Button but_exit;
        private PictureBox pic_exit;
        private Button but_account;
    }
}