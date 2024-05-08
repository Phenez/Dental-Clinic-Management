namespace Dentist_Clinic_Management.Dentist
{
    partial class Add_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Client));
            button3 = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            lb_Success = new Label();
            label1 = new Label();
            lb_rg_phone = new Label();
            label2 = new Label();
            lb_rg_datebirth = new Label();
            lb_rg_Name = new Label();
            panel3 = new Panel();
            tb_Date = new DateTimePicker();
            pictureBox2 = new PictureBox();
            pn_rg_Addr = new Panel();
            tb_Address = new TextBox();
            pc_Lg_Un = new PictureBox();
            pn_rg_Name = new Panel();
            tb_Name = new TextBox();
            pc_rg_name = new PictureBox();
            pn_rg_Phone = new Panel();
            tb_Phone = new TextBox();
            pc_Hp_Login_Un = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pn_rg_Addr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Lg_Un).BeginInit();
            pn_rg_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).BeginInit();
            pn_rg_Phone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Hp_Login_Un).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(8, 48, 107);
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(554, 511);
            button3.Name = "button3";
            button3.Size = new Size(178, 57);
            button3.TabIndex = 3;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lb_Success);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lb_rg_phone);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lb_rg_datebirth);
            panel1.Controls.Add(lb_rg_Name);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pn_rg_Addr);
            panel1.Controls.Add(pn_rg_Name);
            panel1.Controls.Add(pn_rg_Phone);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 597);
            panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(467, 419);
            dataGridView1.TabIndex = 63;
            // 
            // lb_Success
            // 
            lb_Success.AutoSize = true;
            lb_Success.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Success.Location = new Point(833, 676);
            lb_Success.Name = "lb_Success";
            lb_Success.Size = new Size(188, 30);
            lb_Success.TabIndex = 47;
            lb_Success.Text = "Thêm thành công!";
            lb_Success.Visible = false;
            lb_Success.Click += lb_Success_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(612, 48);
            label1.Name = "label1";
            label1.Size = new Size(332, 35);
            label1.TabIndex = 46;
            label1.Text = "Thông tin hồ sơ bệnh nhân";
            label1.Click += label1_Click;
            // 
            // lb_rg_phone
            // 
            lb_rg_phone.AutoSize = true;
            lb_rg_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_phone.Location = new Point(518, 421);
            lb_rg_phone.Name = "lb_rg_phone";
            lb_rg_phone.Size = new Size(140, 30);
            lb_rg_phone.TabIndex = 44;
            lb_rg_phone.Text = "Số điện thoại";
            lb_rg_phone.Click += lb_rg_phone_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(518, 329);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 42;
            label2.Text = "Địa chỉ";
            label2.Click += label2_Click;
            // 
            // lb_rg_datebirth
            // 
            lb_rg_datebirth.AutoSize = true;
            lb_rg_datebirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_datebirth.Location = new Point(518, 242);
            lb_rg_datebirth.Name = "lb_rg_datebirth";
            lb_rg_datebirth.Size = new Size(108, 30);
            lb_rg_datebirth.TabIndex = 40;
            lb_rg_datebirth.Text = "Ngày sinh";
            lb_rg_datebirth.Click += lb_rg_datebirth_Click;
            // 
            // lb_rg_Name
            // 
            lb_rg_Name.AutoSize = true;
            lb_rg_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_Name.Location = new Point(518, 156);
            lb_rg_Name.Name = "lb_rg_Name";
            lb_rg_Name.Size = new Size(79, 30);
            lb_rg_Name.TabIndex = 38;
            lb_rg_Name.Text = "Họ tên";
            lb_rg_Name.Click += lb_rg_Name_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tb_Date);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(668, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 43);
            panel3.TabIndex = 41;
            panel3.Paint += panel3_Paint;
            // 
            // tb_Date
            // 
            tb_Date.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Date.CustomFormat = "dd/MM/yyyy";
            tb_Date.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Date.Format = DateTimePickerFormat.Custom;
            tb_Date.Location = new Point(54, 3);
            tb_Date.MaxDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            tb_Date.Name = "tb_Date";
            tb_Date.Size = new Size(331, 36);
            tb_Date.TabIndex = 10;
            tb_Date.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.calendar__2_;
            pictureBox2.Location = new Point(5, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pn_rg_Addr
            // 
            pn_rg_Addr.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Addr.Controls.Add(tb_Address);
            pn_rg_Addr.Controls.Add(pc_Lg_Un);
            pn_rg_Addr.Location = new Point(668, 320);
            pn_rg_Addr.Name = "pn_rg_Addr";
            pn_rg_Addr.Size = new Size(391, 43);
            pn_rg_Addr.TabIndex = 43;
            pn_rg_Addr.Paint += pn_rg_Addr_Paint;
            // 
            // tb_Address
            // 
            tb_Address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Address.Location = new Point(54, 3);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(331, 36);
            tb_Address.TabIndex = 12;
            tb_Address.TabStop = false;
            // 
            // pc_Lg_Un
            // 
            pc_Lg_Un.Image = Properties.Resources.placeholder;
            pc_Lg_Un.Location = new Point(5, 3);
            pc_Lg_Un.Name = "pc_Lg_Un";
            pc_Lg_Un.Size = new Size(46, 34);
            pc_Lg_Un.SizeMode = PictureBoxSizeMode.Zoom;
            pc_Lg_Un.TabIndex = 9;
            pc_Lg_Un.TabStop = false;
            // 
            // pn_rg_Name
            // 
            pn_rg_Name.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Name.Controls.Add(tb_Name);
            pn_rg_Name.Controls.Add(pc_rg_name);
            pn_rg_Name.Location = new Point(668, 145);
            pn_rg_Name.Name = "pn_rg_Name";
            pn_rg_Name.Size = new Size(391, 43);
            pn_rg_Name.TabIndex = 39;
            pn_rg_Name.Paint += pn_rg_Name_Paint;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(54, 3);
            tb_Name.Name = "tb_Name";
            tb_Name.RightToLeft = RightToLeft.No;
            tb_Name.Size = new Size(331, 36);
            tb_Name.TabIndex = 14;
            tb_Name.TabStop = false;
            // 
            // pc_rg_name
            // 
            pc_rg_name.Image = Properties.Resources.user;
            pc_rg_name.Location = new Point(5, 3);
            pc_rg_name.Name = "pc_rg_name";
            pc_rg_name.Size = new Size(46, 34);
            pc_rg_name.SizeMode = PictureBoxSizeMode.Zoom;
            pc_rg_name.TabIndex = 9;
            pc_rg_name.TabStop = false;
            // 
            // pn_rg_Phone
            // 
            pn_rg_Phone.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Phone.Controls.Add(tb_Phone);
            pn_rg_Phone.Controls.Add(pc_Hp_Login_Un);
            pn_rg_Phone.Location = new Point(668, 412);
            pn_rg_Phone.Name = "pn_rg_Phone";
            pn_rg_Phone.Size = new Size(391, 43);
            pn_rg_Phone.TabIndex = 45;
            pn_rg_Phone.Paint += pn_rg_Phone_Paint;
            // 
            // tb_Phone
            // 
            tb_Phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Phone.Location = new Point(54, 3);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.Size = new Size(331, 36);
            tb_Phone.TabIndex = 11;
            tb_Phone.TabStop = false;
            // 
            // pc_Hp_Login_Un
            // 
            pc_Hp_Login_Un.Image = (Image)resources.GetObject("pc_Hp_Login_Un.Image");
            pc_Hp_Login_Un.Location = new Point(5, 3);
            pc_Hp_Login_Un.Name = "pc_Hp_Login_Un";
            pc_Hp_Login_Un.Size = new Size(46, 34);
            pc_Hp_Login_Un.SizeMode = PictureBoxSizeMode.Zoom;
            pc_Hp_Login_Un.TabIndex = 9;
            pc_Hp_Login_Un.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 48, 107);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(876, 511);
            button1.Name = "button1";
            button1.Size = new Size(178, 57);
            button1.TabIndex = 4;
            button1.Text = "Thêm hồ sơ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Add_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 619);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Add_Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pn_rg_Addr.ResumeLayout(false);
            pn_rg_Addr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Lg_Un).EndInit();
            pn_rg_Name.ResumeLayout(false);
            pn_rg_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).EndInit();
            pn_rg_Phone.ResumeLayout(false);
            pn_rg_Phone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Hp_Login_Un).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Panel panel1;
        private Button button1;
        private Label lb_Success;
        private Label label1;
        private Label lb_rg_phone;
        private Label label2;
        private Label lb_rg_datebirth;
        private Label lb_rg_Name;
        private Panel panel3;
        private DateTimePicker tb_Date;
        private PictureBox pictureBox2;
        private Panel pn_rg_Addr;
        private TextBox tb_Address;
        private PictureBox pc_Lg_Un;
        private Panel pn_rg_Name;
        private TextBox tb_Name;
        private PictureBox pc_rg_name;
        private Panel pn_rg_Phone;
        private TextBox tb_Phone;
        private PictureBox pc_Hp_Login_Un;
        private DataGridView dataGridView1;
    }
}