namespace Dentist_Clinic_Management.Staff
{
    partial class Appointment_Staff
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
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            cb_dentist = new ComboBox();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            panel8 = new Panel();
            pictureBox7 = new PictureBox();
            textBox1 = new TextBox();
            panel9 = new Panel();
            textBox2 = new TextBox();
            pictureBox8 = new PictureBox();
            btnDone = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(btnDone);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(10, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 512);
            panel1.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(13, 192);
            label10.Name = "label10";
            label10.Size = new Size(185, 31);
            label10.TabIndex = 22;
            label10.Text = "Thông tin khám";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(13, 75);
            label9.Name = "label9";
            label9.Size = new Size(239, 31);
            label9.TabIndex = 21;
            label9.Text = "Thông tin bệnh nhân";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 358);
            label1.Name = "label1";
            label1.Size = new Size(78, 31);
            label1.TabIndex = 20;
            label1.Text = "Nha sĩ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 247);
            label4.Name = "label4";
            label4.Size = new Size(130, 31);
            label4.TabIndex = 19;
            label4.Text = "Ngày khám";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 303);
            label5.Name = "label5";
            label5.Size = new Size(112, 31);
            label5.TabIndex = 18;
            label5.Text = "Giờ khám";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(142, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(284, 45);
            panel3.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.CalendarTitleBackColor = Color.White;
            dateTimePicker1.CalendarTitleForeColor = Color.White;
            dateTimePicker1.CalendarTrailingForeColor = Color.White;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(56, 2);
            dateTimePicker1.MinDate = new DateTime(2023, 12, 21, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 38);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.TabStop = false;
            dateTimePicker1.Tag = "";
            dateTimePicker1.Value = new DateTime(2023, 12, 21, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar__2_;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(cb_dentist);
            panel6.Controls.Add(pictureBox2);
            panel6.Location = new Point(142, 349);
            panel6.Name = "panel6";
            panel6.Size = new Size(284, 45);
            panel6.TabIndex = 17;
            // 
            // cb_dentist
            // 
            cb_dentist.BackColor = Color.White;
            cb_dentist.DropDownHeight = 125;
            cb_dentist.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_dentist.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cb_dentist.IntegralHeight = false;
            cb_dentist.Items.AddRange(new object[] { "Trần Huỳnh", "Lê Bích Trâm", "Phan Nhã Tiền", "Nguyễn Văn An", "Trần Thị Bích", "Lê Hoàng Cẩm", "Phạm Duy Diễm", "Hồ Thị Hằng", "Nguyễn Thị Kiều", "Lê Anh Dũng", "Đỗ Thị Mai", "Nguyễn Thị Mỹ", "Nguyễn Quang Nam", "Vũ Thị Ngọc", "Trần Thị Oanh", "Nguyễn Văn Phước", "Nguyễn Thị Quỳnh", "Phạm Thị Trang", "Nguyễn Văn Tuấn", "Nguyễn Thị Vân", "Lê Thị Yến" });
            cb_dentist.Location = new Point(54, 2);
            cb_dentist.Name = "cb_dentist";
            cb_dentist.Size = new Size(222, 39);
            cb_dentist.TabIndex = 15;
            cb_dentist.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.doctor;
            pictureBox2.Location = new Point(4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(dateTimePicker2);
            panel7.Controls.Add(pictureBox6);
            panel7.Location = new Point(142, 295);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 45);
            panel7.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.White;
            dateTimePicker2.CalendarMonthBackground = Color.White;
            dateTimePicker2.CalendarTitleBackColor = Color.White;
            dateTimePicker2.CalendarTitleForeColor = Color.White;
            dateTimePicker2.CalendarTrailingForeColor = Color.White;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(55, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(222, 38);
            dateTimePicker2.TabIndex = 17;
            dateTimePicker2.TabStop = false;
            dateTimePicker2.Value = new DateTime(2023, 12, 21, 7, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.clock__1_;
            pictureBox6.Location = new Point(4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(46, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(466, 131);
            label6.Name = "label6";
            label6.Size = new Size(54, 31);
            label6.TabIndex = 8;
            label6.Text = "SĐT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 131);
            label7.Name = "label7";
            label7.Size = new Size(111, 31);
            label7.TabIndex = 2;
            label7.Text = "Họ và tên";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(pictureBox7);
            panel8.Controls.Add(textBox1);
            panel8.Location = new Point(142, 122);
            panel8.Name = "panel8";
            panel8.Size = new Size(284, 45);
            panel8.TabIndex = 3;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.user;
            pictureBox7.Location = new Point(4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(46, 36);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(55, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Họ và tên";
            textBox1.Size = new Size(222, 31);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(textBox2);
            panel9.Controls.Add(pictureBox8);
            panel9.Location = new Point(535, 122);
            panel9.Name = "panel9";
            panel9.Size = new Size(284, 45);
            panel9.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(55, 6);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Số điện thoại";
            textBox2.Size = new Size(222, 31);
            textBox2.TabIndex = 10;
            textBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.free_add_user_2653368_2202940;
            pictureBox8.Location = new Point(4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(46, 36);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.Navy;
            btnDone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.ForeColor = Color.White;
            btnDone.Location = new Point(634, 427);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(151, 60);
            btnDone.TabIndex = 14;
            btnDone.TabStop = false;
            btnDone.Text = "Hoàn thành";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(305, 25);
            label8.Name = "label8";
            label8.Size = new Size(246, 41);
            label8.TabIndex = 1;
            label8.Text = "ĐẶT LỊCH KHÁM";
            // 
            // Appointment_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(856, 554);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Appointment_Staff";
            RightToLeftLayout = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label10;
        private Label label9;
        private Label label1;
        private Label label4;
        private Label label5;
        private Panel panel3;
        public DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Panel panel6;
        private ComboBox cb_dentist;
        private PictureBox pictureBox2;
        private Panel panel7;
        private DateTimePicker dateTimePicker2;
        private PictureBox pictureBox6;
        private Label label6;
        private Label label7;
        private Panel panel8;
        private PictureBox pictureBox7;
        private TextBox textBox1;
        private Panel panel9;
        private TextBox textBox2;
        private PictureBox pictureBox8;
        private Button btnDone;
        private Label label8;
    }
}