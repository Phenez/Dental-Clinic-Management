namespace Dentist_Clinic_Management.Dentist
{
    partial class Update_Client
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
            panel1 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            tb_Use = new ComboBox();
            tb_Date = new DateTimePicker();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            lb_Success = new Label();
            label1 = new Label();
            lb_rg_phone = new Label();
            label2 = new Label();
            lb_rg_datebirth = new Label();
            pn_rg_Name = new Panel();
            tb_Name = new TextBox();
            pc_rg_name = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pn_rg_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(tb_Use);
            panel1.Controls.Add(tb_Date);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lb_Success);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lb_rg_phone);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lb_rg_datebirth);
            panel1.Controls.Add(pn_rg_Name);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 595);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(754, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 35);
            textBox2.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(580, 192);
            label3.Name = "label3";
            label3.Size = new Size(115, 30);
            label3.TabIndex = 63;
            label3.Text = "Bệnh nhân";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(754, 455);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 35);
            textBox1.TabIndex = 62;
            // 
            // tb_Use
            // 
            tb_Use.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Use.FormattingEnabled = true;
            tb_Use.Items.AddRange(new object[] { "Trám răng", "Cạo vôi", "Chụp X-Quang", "Tiểu phẫu", "Tẩy trắng răng", "Bọc răng sứ", "Niềng răng", "Nhổ răng", "Cấy ghép" });
            tb_Use.Location = new Point(754, 360);
            tb_Use.Name = "tb_Use";
            tb_Use.Size = new Size(335, 38);
            tb_Use.TabIndex = 11;
            // 
            // tb_Date
            // 
            tb_Date.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Date.CustomFormat = "dd/MM/yyyy";
            tb_Date.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Date.Format = DateTimePickerFormat.Custom;
            tb_Date.Location = new Point(754, 275);
            tb_Date.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            tb_Date.MinDate = new DateTime(2024, 1, 3, 0, 0, 0, 0);
            tb_Date.Name = "tb_Date";
            tb_Date.Size = new Size(335, 36);
            tb_Date.TabIndex = 10;
            tb_Date.Value = new DateTime(2024, 1, 3, 12, 19, 52, 0);
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(8, 48, 107);
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(412, 107);
            button2.Name = "button2";
            button2.Size = new Size(134, 43);
            button2.TabIndex = 61;
            button2.Text = "Tìm kiếm";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(517, 399);
            dataGridView1.TabIndex = 60;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lb_Success
            // 
            lb_Success.AutoSize = true;
            lb_Success.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Success.Location = new Point(873, 692);
            lb_Success.Name = "lb_Success";
            lb_Success.Size = new Size(219, 30);
            lb_Success.TabIndex = 59;
            lb_Success.Text = "Cập nhật thành công!";
            lb_Success.Visible = false;
            lb_Success.Click += lb_Success_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(397, 33);
            label1.Name = "label1";
            label1.Size = new Size(323, 35);
            label1.TabIndex = 58;
            label1.Text = "Cập nhật hồ sơ bệnh nhân";
            // 
            // lb_rg_phone
            // 
            lb_rg_phone.AutoSize = true;
            lb_rg_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_phone.Location = new Point(580, 368);
            lb_rg_phone.Name = "lb_rg_phone";
            lb_rg_phone.Size = new Size(140, 30);
            lb_rg_phone.TabIndex = 56;
            lb_rg_phone.Text = "Dịch vụ dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(580, 460);
            label2.Name = "label2";
            label2.Size = new Size(42, 30);
            label2.TabIndex = 54;
            label2.Text = "Phí";
            // 
            // lb_rg_datebirth
            // 
            lb_rg_datebirth.AutoSize = true;
            lb_rg_datebirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_datebirth.Location = new Point(580, 282);
            lb_rg_datebirth.Name = "lb_rg_datebirth";
            lb_rg_datebirth.Size = new Size(160, 30);
            lb_rg_datebirth.TabIndex = 52;
            lb_rg_datebirth.Text = "Ngày giờ khám";
            // 
            // pn_rg_Name
            // 
            pn_rg_Name.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Name.Controls.Add(tb_Name);
            pn_rg_Name.Controls.Add(pc_rg_name);
            pn_rg_Name.Location = new Point(27, 107);
            pn_rg_Name.Name = "pn_rg_Name";
            pn_rg_Name.Size = new Size(379, 43);
            pn_rg_Name.TabIndex = 51;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(54, 3);
            tb_Name.Name = "tb_Name";
            tb_Name.PlaceholderText = "Nhập họ tên bệnh nhân";
            tb_Name.RightToLeft = RightToLeft.No;
            tb_Name.Size = new Size(308, 36);
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 48, 107);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(911, 518);
            button1.Name = "button1";
            button1.Size = new Size(178, 57);
            button1.TabIndex = 49;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(8, 48, 107);
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(596, 518);
            button3.Name = "button3";
            button3.Size = new Size(178, 57);
            button3.TabIndex = 48;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(754, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(335, 35);
            textBox3.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(580, 120);
            label4.Name = "label4";
            label4.Size = new Size(142, 30);
            label4.TabIndex = 65;
            label4.Text = "ID bệnh nhân";
            // 
            // Update_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 619);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Update_Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pn_rg_Name.ResumeLayout(false);
            pn_rg_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lb_Success;
        private Label label1;
        private Label lb_rg_phone;
        private Label label2;
        private Label lb_rg_datebirth;
        private DateTimePicker tb_Date;
        private Panel pn_rg_Name;
        private TextBox tb_Name;
        private PictureBox pc_rg_name;
        private Button button1;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private ComboBox tb_Use;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label4;
    }
}