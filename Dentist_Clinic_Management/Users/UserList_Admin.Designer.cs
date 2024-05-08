namespace Dentist_Clinic_Management.Users
{
    partial class UserList_Admin
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
            tab_dataList = new TabControl();
            tab_customer = new TabPage();
            data_list_customer = new DataGridView();
            panel1 = new Panel();
            tb_sdt = new TextBox();
            tb_diachi = new TextBox();
            tb_dob = new TextBox();
            panel3 = new Panel();
            but_Add_cus = new Button();
            but_del_cus = new Button();
            but_Update_cus = new Button();
            tb_role_cus = new TextBox();
            tb_pass_cus = new TextBox();
            tb_account_cus = new TextBox();
            lab_sdt = new Label();
            lab_diachi = new Label();
            lab_ngaysinh = new Label();
            tb_name_cus = new TextBox();
            tb_id_cus = new TextBox();
            lab_role_cus = new Label();
            lab_pass_cus = new Label();
            lab_account_cus = new Label();
            lab_name_cus = new Label();
            lab_id_cus = new Label();
            but_Seen_cus = new Button();
            but_find_cus = new Button();
            text_name_cli_cus = new TextBox();
            tab_dentist = new TabPage();
            data_list_dentist = new DataGridView();
            but_Seen_den = new Button();
            but_find_den = new Button();
            text_name_cli_den = new TextBox();
            panel2 = new Panel();
            tb_specilize = new TextBox();
            panel4 = new Panel();
            but_Add_den = new Button();
            but_del_den = new Button();
            but_Update_den = new Button();
            tb_role_den = new TextBox();
            tb_pass_den = new TextBox();
            tb_account_den = new TextBox();
            lab_specilize = new Label();
            tb_name_den = new TextBox();
            tb_id_den = new TextBox();
            lab_role_den = new Label();
            lab_pass_den = new Label();
            lab_account_den = new Label();
            lab_name_den = new Label();
            lab_id_den = new Label();
            tab_staff = new TabPage();
            data_list_staff = new DataGridView();
            but_Seen_sta = new Button();
            but_find_sta = new Button();
            text_name_cli_sta = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            but_Add_sta = new Button();
            but_del_sta = new Button();
            but_Update_sta = new Button();
            tb_role_sta = new TextBox();
            tb_pass_sta = new TextBox();
            tb_account_sta = new TextBox();
            tb_name_sta = new TextBox();
            tb_id_sta = new TextBox();
            lab_role_sta = new Label();
            lab_pass_sta = new Label();
            lab_account_sta = new Label();
            lab_name_sta = new Label();
            lab_id_sta = new Label();
            pic_Back = new PictureBox();
            lab_main = new Label();
            main_panel.SuspendLayout();
            tab_dataList.SuspendLayout();
            tab_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_customer).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tab_dentist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_dentist).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tab_staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_staff).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).BeginInit();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(tab_dataList);
            main_panel.Controls.Add(pic_Back);
            main_panel.Controls.Add(lab_main);
            main_panel.Location = new Point(12, 11);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1124, 611);
            main_panel.TabIndex = 11;
            // 
            // tab_dataList
            // 
            tab_dataList.Controls.Add(tab_customer);
            tab_dataList.Controls.Add(tab_dentist);
            tab_dataList.Controls.Add(tab_staff);
            tab_dataList.Location = new Point(17, 54);
            tab_dataList.Name = "tab_dataList";
            tab_dataList.SelectedIndex = 0;
            tab_dataList.Size = new Size(1104, 557);
            tab_dataList.TabIndex = 11;
            // 
            // tab_customer
            // 
            tab_customer.Controls.Add(data_list_customer);
            tab_customer.Controls.Add(panel1);
            tab_customer.Controls.Add(but_Seen_cus);
            tab_customer.Controls.Add(but_find_cus);
            tab_customer.Controls.Add(text_name_cli_cus);
            tab_customer.Location = new Point(4, 28);
            tab_customer.Name = "tab_customer";
            tab_customer.Padding = new Padding(3);
            tab_customer.Size = new Size(1096, 525);
            tab_customer.TabIndex = 0;
            tab_customer.Text = "Khách hàng";
            tab_customer.UseVisualStyleBackColor = true;
            // 
            // data_list_customer
            // 
            data_list_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_customer.Location = new Point(6, 66);
            data_list_customer.Name = "data_list_customer";
            data_list_customer.RowHeadersWidth = 51;
            data_list_customer.RowTemplate.Height = 29;
            data_list_customer.Size = new Size(472, 401);
            data_list_customer.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(tb_sdt);
            panel1.Controls.Add(tb_diachi);
            panel1.Controls.Add(tb_dob);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tb_role_cus);
            panel1.Controls.Add(tb_pass_cus);
            panel1.Controls.Add(tb_account_cus);
            panel1.Controls.Add(lab_sdt);
            panel1.Controls.Add(lab_diachi);
            panel1.Controls.Add(lab_ngaysinh);
            panel1.Controls.Add(tb_name_cus);
            panel1.Controls.Add(tb_id_cus);
            panel1.Controls.Add(lab_role_cus);
            panel1.Controls.Add(lab_pass_cus);
            panel1.Controls.Add(lab_account_cus);
            panel1.Controls.Add(lab_name_cus);
            panel1.Controls.Add(lab_id_cus);
            panel1.Location = new Point(484, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 504);
            panel1.TabIndex = 7;
            // 
            // tb_sdt
            // 
            tb_sdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_sdt.Location = new Point(187, 362);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.ReadOnly = true;
            tb_sdt.Size = new Size(384, 36);
            tb_sdt.TabIndex = 8;
            tb_sdt.TabStop = false;
            // 
            // tb_diachi
            // 
            tb_diachi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_diachi.Location = new Point(187, 315);
            tb_diachi.Name = "tb_diachi";
            tb_diachi.ReadOnly = true;
            tb_diachi.Size = new Size(384, 36);
            tb_diachi.TabIndex = 8;
            tb_diachi.TabStop = false;
            // 
            // tb_dob
            // 
            tb_dob.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_dob.Location = new Point(187, 267);
            tb_dob.Name = "tb_dob";
            tb_dob.ReadOnly = true;
            tb_dob.Size = new Size(384, 36);
            tb_dob.TabIndex = 8;
            tb_dob.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(but_Add_cus);
            panel3.Controls.Add(but_del_cus);
            panel3.Controls.Add(but_Update_cus);
            panel3.Location = new Point(0, 455);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 53);
            panel3.TabIndex = 7;
            // 
            // but_Add_cus
            // 
            but_Add_cus.BackColor = Color.FromArgb(7, 47, 128);
            but_Add_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Add_cus.ForeColor = Color.White;
            but_Add_cus.Location = new Point(3, 0);
            but_Add_cus.Name = "but_Add_cus";
            but_Add_cus.Size = new Size(125, 50);
            but_Add_cus.TabIndex = 5;
            but_Add_cus.TabStop = false;
            but_Add_cus.Text = "Thêm";
            but_Add_cus.UseVisualStyleBackColor = false;
            but_Add_cus.Click += but_Add_cus_Click;
            // 
            // but_del_cus
            // 
            but_del_cus.BackColor = Color.FromArgb(7, 47, 128);
            but_del_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_del_cus.ForeColor = Color.White;
            but_del_cus.Location = new Point(462, 0);
            but_del_cus.Name = "but_del_cus";
            but_del_cus.Size = new Size(125, 50);
            but_del_cus.TabIndex = 19;
            but_del_cus.TabStop = false;
            but_del_cus.Text = "Xóa";
            but_del_cus.UseVisualStyleBackColor = false;
            but_del_cus.Click += but_del_cus_Click;
            // 
            // but_Update_cus
            // 
            but_Update_cus.BackColor = Color.FromArgb(7, 47, 128);
            but_Update_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Update_cus.ForeColor = Color.White;
            but_Update_cus.Location = new Point(225, 0);
            but_Update_cus.Name = "but_Update_cus";
            but_Update_cus.Size = new Size(125, 50);
            but_Update_cus.TabIndex = 6;
            but_Update_cus.TabStop = false;
            but_Update_cus.Text = "Cập nhật";
            but_Update_cus.UseVisualStyleBackColor = false;
            but_Update_cus.Click += but_Update_cus_Click;
            // 
            // tb_role_cus
            // 
            tb_role_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_role_cus.Location = new Point(187, 218);
            tb_role_cus.Multiline = true;
            tb_role_cus.Name = "tb_role_cus";
            tb_role_cus.ReadOnly = true;
            tb_role_cus.Size = new Size(384, 32);
            tb_role_cus.TabIndex = 14;
            tb_role_cus.TabStop = false;
            // 
            // tb_pass_cus
            // 
            tb_pass_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_pass_cus.Location = new Point(187, 166);
            tb_pass_cus.Multiline = true;
            tb_pass_cus.Name = "tb_pass_cus";
            tb_pass_cus.ReadOnly = true;
            tb_pass_cus.Size = new Size(384, 32);
            tb_pass_cus.TabIndex = 14;
            tb_pass_cus.TabStop = false;
            // 
            // tb_account_cus
            // 
            tb_account_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_account_cus.Location = new Point(187, 118);
            tb_account_cus.Name = "tb_account_cus";
            tb_account_cus.ReadOnly = true;
            tb_account_cus.Size = new Size(384, 36);
            tb_account_cus.TabIndex = 13;
            tb_account_cus.TabStop = false;
            // 
            // lab_sdt
            // 
            lab_sdt.AutoSize = true;
            lab_sdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_sdt.Location = new Point(7, 369);
            lab_sdt.Name = "lab_sdt";
            lab_sdt.Size = new Size(51, 30);
            lab_sdt.TabIndex = 0;
            lab_sdt.Text = "SDT";
            // 
            // lab_diachi
            // 
            lab_diachi.AutoSize = true;
            lab_diachi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_diachi.Location = new Point(7, 322);
            lab_diachi.Name = "lab_diachi";
            lab_diachi.Size = new Size(77, 30);
            lab_diachi.TabIndex = 0;
            lab_diachi.Text = "Địa chỉ";
            // 
            // lab_ngaysinh
            // 
            lab_ngaysinh.AutoSize = true;
            lab_ngaysinh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_ngaysinh.Location = new Point(7, 274);
            lab_ngaysinh.Name = "lab_ngaysinh";
            lab_ngaysinh.Size = new Size(108, 30);
            lab_ngaysinh.TabIndex = 0;
            lab_ngaysinh.Text = "Ngày sinh";
            // 
            // tb_name_cus
            // 
            tb_name_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name_cus.Location = new Point(187, 66);
            tb_name_cus.Name = "tb_name_cus";
            tb_name_cus.ReadOnly = true;
            tb_name_cus.Size = new Size(384, 36);
            tb_name_cus.TabIndex = 10;
            tb_name_cus.TabStop = false;
            // 
            // tb_id_cus
            // 
            tb_id_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id_cus.Location = new Point(187, 19);
            tb_id_cus.Name = "tb_id_cus";
            tb_id_cus.ReadOnly = true;
            tb_id_cus.Size = new Size(384, 36);
            tb_id_cus.TabIndex = 8;
            tb_id_cus.TabStop = false;
            // 
            // lab_role_cus
            // 
            lab_role_cus.AutoSize = true;
            lab_role_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_role_cus.Location = new Point(7, 220);
            lab_role_cus.Name = "lab_role_cus";
            lab_role_cus.Size = new Size(75, 30);
            lab_role_cus.TabIndex = 7;
            lab_role_cus.Text = "Vai trò";
            // 
            // lab_pass_cus
            // 
            lab_pass_cus.AutoSize = true;
            lab_pass_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_pass_cus.Location = new Point(5, 168);
            lab_pass_cus.Name = "lab_pass_cus";
            lab_pass_cus.Size = new Size(103, 30);
            lab_pass_cus.TabIndex = 6;
            lab_pass_cus.Text = "Mật khẩu";
            // 
            // lab_account_cus
            // 
            lab_account_cus.AutoSize = true;
            lab_account_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_account_cus.Location = new Point(7, 121);
            lab_account_cus.Name = "lab_account_cus";
            lab_account_cus.Size = new Size(156, 30);
            lab_account_cus.TabIndex = 5;
            lab_account_cus.Text = "Tên đăng nhập";
            // 
            // lab_name_cus
            // 
            lab_name_cus.AutoSize = true;
            lab_name_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_name_cus.Location = new Point(7, 69);
            lab_name_cus.Name = "lab_name_cus";
            lab_name_cus.Size = new Size(165, 30);
            lab_name_cus.TabIndex = 1;
            lab_name_cus.Text = "Tên người dùng";
            // 
            // lab_id_cus
            // 
            lab_id_cus.AutoSize = true;
            lab_id_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_id_cus.Location = new Point(7, 22);
            lab_id_cus.Name = "lab_id_cus";
            lab_id_cus.Size = new Size(162, 30);
            lab_id_cus.TabIndex = 0;
            lab_id_cus.Text = "Mã người dùng";
            // 
            // but_Seen_cus
            // 
            but_Seen_cus.BackColor = Color.FromArgb(7, 47, 128);
            but_Seen_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Seen_cus.ForeColor = Color.White;
            but_Seen_cus.Location = new Point(305, 473);
            but_Seen_cus.Name = "but_Seen_cus";
            but_Seen_cus.Size = new Size(173, 50);
            but_Seen_cus.TabIndex = 4;
            but_Seen_cus.TabStop = false;
            but_Seen_cus.Text = "Xem tất cả";
            but_Seen_cus.UseVisualStyleBackColor = false;
            but_Seen_cus.Click += but_Seen_cus_Click;
            // 
            // but_find_cus
            // 
            but_find_cus.BackColor = Color.FromArgb(7, 47, 128);
            but_find_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_find_cus.ForeColor = Color.White;
            but_find_cus.Location = new Point(302, 10);
            but_find_cus.Name = "but_find_cus";
            but_find_cus.Size = new Size(173, 50);
            but_find_cus.TabIndex = 1;
            but_find_cus.TabStop = false;
            but_find_cus.Text = "Tìm kiếm";
            but_find_cus.UseVisualStyleBackColor = false;
            but_find_cus.Click += but_find_cus_Click;
            // 
            // text_name_cli_cus
            // 
            text_name_cli_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_cli_cus.Location = new Point(6, 18);
            text_name_cli_cus.Name = "text_name_cli_cus";
            text_name_cli_cus.PlaceholderText = "Nhập tên tài khoản";
            text_name_cli_cus.Size = new Size(290, 36);
            text_name_cli_cus.TabIndex = 0;
            text_name_cli_cus.TabStop = false;
            // 
            // tab_dentist
            // 
            tab_dentist.Controls.Add(data_list_dentist);
            tab_dentist.Controls.Add(but_Seen_den);
            tab_dentist.Controls.Add(but_find_den);
            tab_dentist.Controls.Add(text_name_cli_den);
            tab_dentist.Controls.Add(panel2);
            tab_dentist.Location = new Point(4, 28);
            tab_dentist.Name = "tab_dentist";
            tab_dentist.Padding = new Padding(3);
            tab_dentist.Size = new Size(1096, 525);
            tab_dentist.TabIndex = 1;
            tab_dentist.Text = "Nha sĩ";
            tab_dentist.UseVisualStyleBackColor = true;
            // 
            // data_list_dentist
            // 
            data_list_dentist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_dentist.Location = new Point(6, 66);
            data_list_dentist.Name = "data_list_dentist";
            data_list_dentist.RowHeadersWidth = 51;
            data_list_dentist.RowTemplate.Height = 29;
            data_list_dentist.Size = new Size(472, 401);
            data_list_dentist.TabIndex = 11;
            // 
            // but_Seen_den
            // 
            but_Seen_den.BackColor = Color.FromArgb(7, 47, 128);
            but_Seen_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Seen_den.ForeColor = Color.White;
            but_Seen_den.Location = new Point(305, 473);
            but_Seen_den.Name = "but_Seen_den";
            but_Seen_den.Size = new Size(173, 50);
            but_Seen_den.TabIndex = 12;
            but_Seen_den.TabStop = false;
            but_Seen_den.Text = "Xem tất cả";
            but_Seen_den.UseVisualStyleBackColor = false;
            but_Seen_den.Click += but_Seen_den_Click;
            // 
            // but_find_den
            // 
            but_find_den.BackColor = Color.FromArgb(7, 47, 128);
            but_find_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_find_den.ForeColor = Color.White;
            but_find_den.Location = new Point(302, 10);
            but_find_den.Name = "but_find_den";
            but_find_den.Size = new Size(173, 50);
            but_find_den.TabIndex = 10;
            but_find_den.TabStop = false;
            but_find_den.Text = "Tìm kiếm";
            but_find_den.UseVisualStyleBackColor = false;
            but_find_den.Click += but_find_den_Click;
            // 
            // text_name_cli_den
            // 
            text_name_cli_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_cli_den.Location = new Point(6, 18);
            text_name_cli_den.Name = "text_name_cli_den";
            text_name_cli_den.PlaceholderText = "Nhập tên tài khoản";
            text_name_cli_den.Size = new Size(290, 36);
            text_name_cli_den.TabIndex = 9;
            text_name_cli_den.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tb_specilize);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(tb_role_den);
            panel2.Controls.Add(tb_pass_den);
            panel2.Controls.Add(tb_account_den);
            panel2.Controls.Add(lab_specilize);
            panel2.Controls.Add(tb_name_den);
            panel2.Controls.Add(tb_id_den);
            panel2.Controls.Add(lab_role_den);
            panel2.Controls.Add(lab_pass_den);
            panel2.Controls.Add(lab_account_den);
            panel2.Controls.Add(lab_name_den);
            panel2.Controls.Add(lab_id_den);
            panel2.Location = new Point(484, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 504);
            panel2.TabIndex = 8;
            // 
            // tb_specilize
            // 
            tb_specilize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_specilize.Location = new Point(187, 267);
            tb_specilize.Name = "tb_specilize";
            tb_specilize.ReadOnly = true;
            tb_specilize.Size = new Size(384, 36);
            tb_specilize.TabIndex = 8;
            tb_specilize.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(but_Add_den);
            panel4.Controls.Add(but_del_den);
            panel4.Controls.Add(but_Update_den);
            panel4.Location = new Point(0, 455);
            panel4.Name = "panel4";
            panel4.Size = new Size(590, 53);
            panel4.TabIndex = 7;
            // 
            // but_Add_den
            // 
            but_Add_den.BackColor = Color.FromArgb(7, 47, 128);
            but_Add_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Add_den.ForeColor = Color.White;
            but_Add_den.Location = new Point(3, 0);
            but_Add_den.Name = "but_Add_den";
            but_Add_den.Size = new Size(125, 50);
            but_Add_den.TabIndex = 5;
            but_Add_den.TabStop = false;
            but_Add_den.Text = "Thêm";
            but_Add_den.UseVisualStyleBackColor = false;
            but_Add_den.Click += but_Add_den_Click;
            // 
            // but_del_den
            // 
            but_del_den.BackColor = Color.FromArgb(7, 47, 128);
            but_del_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_del_den.ForeColor = Color.White;
            but_del_den.Location = new Point(462, 0);
            but_del_den.Name = "but_del_den";
            but_del_den.Size = new Size(125, 50);
            but_del_den.TabIndex = 19;
            but_del_den.TabStop = false;
            but_del_den.Text = "Xóa";
            but_del_den.UseVisualStyleBackColor = false;
            but_del_den.Click += but_del_den_Click;
            // 
            // but_Update_den
            // 
            but_Update_den.BackColor = Color.FromArgb(7, 47, 128);
            but_Update_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Update_den.ForeColor = Color.White;
            but_Update_den.Location = new Point(225, 0);
            but_Update_den.Name = "but_Update_den";
            but_Update_den.Size = new Size(125, 50);
            but_Update_den.TabIndex = 6;
            but_Update_den.TabStop = false;
            but_Update_den.Text = "Cập nhật";
            but_Update_den.UseVisualStyleBackColor = false;
            but_Update_den.Click += but_Update_den_Click;
            // 
            // tb_role_den
            // 
            tb_role_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_role_den.Location = new Point(187, 218);
            tb_role_den.Multiline = true;
            tb_role_den.Name = "tb_role_den";
            tb_role_den.ReadOnly = true;
            tb_role_den.Size = new Size(384, 32);
            tb_role_den.TabIndex = 14;
            tb_role_den.TabStop = false;
            // 
            // tb_pass_den
            // 
            tb_pass_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_pass_den.Location = new Point(187, 166);
            tb_pass_den.Multiline = true;
            tb_pass_den.Name = "tb_pass_den";
            tb_pass_den.ReadOnly = true;
            tb_pass_den.Size = new Size(384, 32);
            tb_pass_den.TabIndex = 14;
            tb_pass_den.TabStop = false;
            // 
            // tb_account_den
            // 
            tb_account_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_account_den.Location = new Point(187, 118);
            tb_account_den.Name = "tb_account_den";
            tb_account_den.ReadOnly = true;
            tb_account_den.Size = new Size(384, 36);
            tb_account_den.TabIndex = 13;
            tb_account_den.TabStop = false;
            // 
            // lab_specilize
            // 
            lab_specilize.AutoSize = true;
            lab_specilize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_specilize.Location = new Point(7, 274);
            lab_specilize.Name = "lab_specilize";
            lab_specilize.Size = new Size(136, 30);
            lab_specilize.TabIndex = 0;
            lab_specilize.Text = "Chuyên môn";
            // 
            // tb_name_den
            // 
            tb_name_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name_den.Location = new Point(187, 66);
            tb_name_den.Name = "tb_name_den";
            tb_name_den.ReadOnly = true;
            tb_name_den.Size = new Size(384, 36);
            tb_name_den.TabIndex = 10;
            tb_name_den.TabStop = false;
            // 
            // tb_id_den
            // 
            tb_id_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id_den.Location = new Point(187, 19);
            tb_id_den.Name = "tb_id_den";
            tb_id_den.ReadOnly = true;
            tb_id_den.Size = new Size(384, 36);
            tb_id_den.TabIndex = 8;
            tb_id_den.TabStop = false;
            // 
            // lab_role_den
            // 
            lab_role_den.AutoSize = true;
            lab_role_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_role_den.Location = new Point(7, 220);
            lab_role_den.Name = "lab_role_den";
            lab_role_den.Size = new Size(75, 30);
            lab_role_den.TabIndex = 7;
            lab_role_den.Text = "Vai trò";
            // 
            // lab_pass_den
            // 
            lab_pass_den.AutoSize = true;
            lab_pass_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_pass_den.Location = new Point(5, 168);
            lab_pass_den.Name = "lab_pass_den";
            lab_pass_den.Size = new Size(103, 30);
            lab_pass_den.TabIndex = 6;
            lab_pass_den.Text = "Mật khẩu";
            // 
            // lab_account_den
            // 
            lab_account_den.AutoSize = true;
            lab_account_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_account_den.Location = new Point(7, 121);
            lab_account_den.Name = "lab_account_den";
            lab_account_den.Size = new Size(156, 30);
            lab_account_den.TabIndex = 5;
            lab_account_den.Text = "Tên đăng nhập";
            // 
            // lab_name_den
            // 
            lab_name_den.AutoSize = true;
            lab_name_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_name_den.Location = new Point(7, 69);
            lab_name_den.Name = "lab_name_den";
            lab_name_den.Size = new Size(165, 30);
            lab_name_den.TabIndex = 1;
            lab_name_den.Text = "Tên người dùng";
            // 
            // lab_id_den
            // 
            lab_id_den.AutoSize = true;
            lab_id_den.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_id_den.Location = new Point(7, 22);
            lab_id_den.Name = "lab_id_den";
            lab_id_den.Size = new Size(162, 30);
            lab_id_den.TabIndex = 0;
            lab_id_den.Text = "Mã người dùng";
            // 
            // tab_staff
            // 
            tab_staff.Controls.Add(data_list_staff);
            tab_staff.Controls.Add(but_Seen_sta);
            tab_staff.Controls.Add(but_find_sta);
            tab_staff.Controls.Add(text_name_cli_sta);
            tab_staff.Controls.Add(panel5);
            tab_staff.Location = new Point(4, 28);
            tab_staff.Name = "tab_staff";
            tab_staff.Padding = new Padding(3);
            tab_staff.Size = new Size(1096, 525);
            tab_staff.TabIndex = 2;
            tab_staff.Text = "Nhân viên";
            tab_staff.UseVisualStyleBackColor = true;
            // 
            // data_list_staff
            // 
            data_list_staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_staff.Location = new Point(6, 66);
            data_list_staff.Name = "data_list_staff";
            data_list_staff.RowHeadersWidth = 51;
            data_list_staff.RowTemplate.Height = 29;
            data_list_staff.Size = new Size(472, 401);
            data_list_staff.TabIndex = 15;
            // 
            // but_Seen_sta
            // 
            but_Seen_sta.BackColor = Color.FromArgb(7, 47, 128);
            but_Seen_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Seen_sta.ForeColor = Color.White;
            but_Seen_sta.Location = new Point(305, 473);
            but_Seen_sta.Name = "but_Seen_sta";
            but_Seen_sta.Size = new Size(173, 50);
            but_Seen_sta.TabIndex = 16;
            but_Seen_sta.TabStop = false;
            but_Seen_sta.Text = "Xem tất cả";
            but_Seen_sta.UseVisualStyleBackColor = false;
            but_Seen_sta.Click += but_Seen_sta_Click;
            // 
            // but_find_sta
            // 
            but_find_sta.BackColor = Color.FromArgb(7, 47, 128);
            but_find_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_find_sta.ForeColor = Color.White;
            but_find_sta.Location = new Point(302, 10);
            but_find_sta.Name = "but_find_sta";
            but_find_sta.Size = new Size(173, 50);
            but_find_sta.TabIndex = 14;
            but_find_sta.TabStop = false;
            but_find_sta.Text = "Tìm kiếm";
            but_find_sta.UseVisualStyleBackColor = false;
            but_find_sta.Click += but_find_sta_Click;
            // 
            // text_name_cli_sta
            // 
            text_name_cli_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_cli_sta.Location = new Point(6, 18);
            text_name_cli_sta.Name = "text_name_cli_sta";
            text_name_cli_sta.PlaceholderText = "Nhập tên tài khoản";
            text_name_cli_sta.Size = new Size(290, 36);
            text_name_cli_sta.TabIndex = 13;
            text_name_cli_sta.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(tb_role_sta);
            panel5.Controls.Add(tb_pass_sta);
            panel5.Controls.Add(tb_account_sta);
            panel5.Controls.Add(tb_name_sta);
            panel5.Controls.Add(tb_id_sta);
            panel5.Controls.Add(lab_role_sta);
            panel5.Controls.Add(lab_pass_sta);
            panel5.Controls.Add(lab_account_sta);
            panel5.Controls.Add(lab_name_sta);
            panel5.Controls.Add(lab_id_sta);
            panel5.Location = new Point(484, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(590, 504);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Controls.Add(but_Add_sta);
            panel6.Controls.Add(but_del_sta);
            panel6.Controls.Add(but_Update_sta);
            panel6.Location = new Point(0, 455);
            panel6.Name = "panel6";
            panel6.Size = new Size(590, 53);
            panel6.TabIndex = 7;
            // 
            // but_Add_sta
            // 
            but_Add_sta.BackColor = Color.FromArgb(7, 47, 128);
            but_Add_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Add_sta.ForeColor = Color.White;
            but_Add_sta.Location = new Point(3, 0);
            but_Add_sta.Name = "but_Add_sta";
            but_Add_sta.Size = new Size(125, 50);
            but_Add_sta.TabIndex = 5;
            but_Add_sta.TabStop = false;
            but_Add_sta.Text = "Thêm";
            but_Add_sta.UseVisualStyleBackColor = false;
            but_Add_sta.Click += but_Add_sta_Click;
            // 
            // but_del_sta
            // 
            but_del_sta.BackColor = Color.FromArgb(7, 47, 128);
            but_del_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_del_sta.ForeColor = Color.White;
            but_del_sta.Location = new Point(462, 0);
            but_del_sta.Name = "but_del_sta";
            but_del_sta.Size = new Size(125, 50);
            but_del_sta.TabIndex = 19;
            but_del_sta.TabStop = false;
            but_del_sta.Text = "Xóa";
            but_del_sta.UseVisualStyleBackColor = false;
            but_del_sta.Click += but_del_sta_Click;
            // 
            // but_Update_sta
            // 
            but_Update_sta.BackColor = Color.FromArgb(7, 47, 128);
            but_Update_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Update_sta.ForeColor = Color.White;
            but_Update_sta.Location = new Point(225, 0);
            but_Update_sta.Name = "but_Update_sta";
            but_Update_sta.Size = new Size(125, 50);
            but_Update_sta.TabIndex = 6;
            but_Update_sta.TabStop = false;
            but_Update_sta.Text = "Cập nhật";
            but_Update_sta.UseVisualStyleBackColor = false;
            but_Update_sta.Click += but_Update_sta_Click;
            // 
            // tb_role_sta
            // 
            tb_role_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_role_sta.Location = new Point(187, 218);
            tb_role_sta.Multiline = true;
            tb_role_sta.Name = "tb_role_sta";
            tb_role_sta.ReadOnly = true;
            tb_role_sta.Size = new Size(384, 32);
            tb_role_sta.TabIndex = 14;
            tb_role_sta.TabStop = false;
            // 
            // tb_pass_sta
            // 
            tb_pass_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_pass_sta.Location = new Point(187, 166);
            tb_pass_sta.Multiline = true;
            tb_pass_sta.Name = "tb_pass_sta";
            tb_pass_sta.ReadOnly = true;
            tb_pass_sta.Size = new Size(384, 32);
            tb_pass_sta.TabIndex = 14;
            tb_pass_sta.TabStop = false;
            // 
            // tb_account_sta
            // 
            tb_account_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_account_sta.Location = new Point(187, 118);
            tb_account_sta.Name = "tb_account_sta";
            tb_account_sta.ReadOnly = true;
            tb_account_sta.Size = new Size(384, 36);
            tb_account_sta.TabIndex = 13;
            tb_account_sta.TabStop = false;
            // 
            // tb_name_sta
            // 
            tb_name_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name_sta.Location = new Point(187, 66);
            tb_name_sta.Name = "tb_name_sta";
            tb_name_sta.ReadOnly = true;
            tb_name_sta.Size = new Size(384, 36);
            tb_name_sta.TabIndex = 10;
            tb_name_sta.TabStop = false;
            // 
            // tb_id_sta
            // 
            tb_id_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id_sta.Location = new Point(187, 19);
            tb_id_sta.Name = "tb_id_sta";
            tb_id_sta.ReadOnly = true;
            tb_id_sta.Size = new Size(384, 36);
            tb_id_sta.TabIndex = 8;
            tb_id_sta.TabStop = false;
            // 
            // lab_role_sta
            // 
            lab_role_sta.AutoSize = true;
            lab_role_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_role_sta.Location = new Point(7, 220);
            lab_role_sta.Name = "lab_role_sta";
            lab_role_sta.Size = new Size(75, 30);
            lab_role_sta.TabIndex = 7;
            lab_role_sta.Text = "Vai trò";
            // 
            // lab_pass_sta
            // 
            lab_pass_sta.AutoSize = true;
            lab_pass_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_pass_sta.Location = new Point(5, 168);
            lab_pass_sta.Name = "lab_pass_sta";
            lab_pass_sta.Size = new Size(103, 30);
            lab_pass_sta.TabIndex = 6;
            lab_pass_sta.Text = "Mật khẩu";
            // 
            // lab_account_sta
            // 
            lab_account_sta.AutoSize = true;
            lab_account_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_account_sta.Location = new Point(7, 121);
            lab_account_sta.Name = "lab_account_sta";
            lab_account_sta.Size = new Size(156, 30);
            lab_account_sta.TabIndex = 5;
            lab_account_sta.Text = "Tên đăng nhập";
            // 
            // lab_name_sta
            // 
            lab_name_sta.AutoSize = true;
            lab_name_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_name_sta.Location = new Point(7, 69);
            lab_name_sta.Name = "lab_name_sta";
            lab_name_sta.Size = new Size(165, 30);
            lab_name_sta.TabIndex = 1;
            lab_name_sta.Text = "Tên người dùng";
            // 
            // lab_id_sta
            // 
            lab_id_sta.AutoSize = true;
            lab_id_sta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_id_sta.Location = new Point(7, 22);
            lab_id_sta.Name = "lab_id_sta";
            lab_id_sta.Size = new Size(162, 30);
            lab_id_sta.TabIndex = 0;
            lab_id_sta.Text = "Mã người dùng";
            // 
            // pic_Back
            // 
            pic_Back.Image = Properties.Resources.previous;
            pic_Back.Location = new Point(17, 3);
            pic_Back.Name = "pic_Back";
            pic_Back.Size = new Size(50, 46);
            pic_Back.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Back.TabIndex = 10;
            pic_Back.TabStop = false;
            pic_Back.Click += pic_Back_Click;
            // 
            // lab_main
            // 
            lab_main.AutoSize = true;
            lab_main.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_main.ForeColor = Color.FromArgb(7, 47, 128);
            lab_main.Location = new Point(464, 3);
            lab_main.Name = "lab_main";
            lab_main.Size = new Size(220, 35);
            lab_main.TabIndex = 6;
            lab_main.Text = "Quản lý tài khoản";
            // 
            // UserList_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1148, 634);
            ControlBox = false;
            Controls.Add(main_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserList_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            tab_dataList.ResumeLayout(false);
            tab_customer.ResumeLayout(false);
            tab_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_customer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            tab_dentist.ResumeLayout(false);
            tab_dentist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_dentist).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            tab_staff.ResumeLayout(false);
            tab_staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_staff).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Back).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private PictureBox pic_Back;
        private Panel panel1;
        private Button but_del_cus;
        private Button but_Update_cus;
        private TextBox tb_pass_cus;
        private Button but_Add_cus;
        private TextBox tb_account_cus;
        private TextBox tb_name_cus;
        private TextBox tb_id_cus;
        private Label lab_role_cus;
        private Label lab_pass_cus;
        private Label lab_account_cus;
        private Label lab_name_cus;
        private Label lab_id_cus;
        private Label lab_main;
        private Button but_Seen_cus;
        private DataGridView data_list_customer;
        private Button but_find_cus;
        private TextBox text_name_cli_cus;
        private TextBox tb_dob;
        private Label lab_ngaysinh;
        private TextBox tb_role_cus;
        private Panel panel3;
        private TextBox tb_sdt;
        private TextBox tb_diachi;
        private Label lab_sdt;
        private Label lab_diachi;
        private TabControl tab_dataList;
        private TabPage tab_customer;
        private TabPage tab_dentist;
        private TabPage tab_staff;
        private Panel panel2;
        private TextBox tb_specilize;
        private Panel panel4;
        private Button but_Add_den;
        private Button but_del_den;
        private Button but_Update_den;
        private TextBox tb_role_den;
        private TextBox tb_pass_den;
        private TextBox tb_account_den;
        private Label lab_specilize;
        private TextBox tb_name_den;
        private TextBox tb_id_den;
        private Label lab_role_den;
        private Label lab_pass_den;
        private Label lab_account_den;
        private Label lab_name_den;
        private Label lab_id_den;
        private DataGridView data_list_dentist;
        private Button but_Seen_den;
        private Button but_find_den;
        private TextBox text_name_cli_den;
        private DataGridView data_list_staff;
        private Button but_Seen_sta;
        private Button but_find_sta;
        private TextBox text_name_cli_sta;
        private Panel panel5;
        private Panel panel6;
        private Button but_Add_sta;
        private Button but_del_sta;
        private Button but_Update_sta;
        private TextBox tb_role_sta;
        private TextBox tb_pass_sta;
        private TextBox tb_account_sta;
        private TextBox tb_name_sta;
        private TextBox tb_id_sta;
        private Label lab_role_sta;
        private Label lab_pass_sta;
        private Label lab_account_sta;
        private Label lab_name_sta;
        private Label lab_id_sta;
    }
}