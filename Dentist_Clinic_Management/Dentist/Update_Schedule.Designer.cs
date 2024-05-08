namespace Dentist_Clinic_Management.Dentist
{
    partial class Update_Schedule
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
            comboBox1 = new ComboBox();
            tb_Dentist = new ComboBox();
            button4 = new Button();
            lb_Success2 = new Label();
            button2 = new Button();
            dateTimePicker4 = new DateTimePicker();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker3 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tb_Choose = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            lb_Success = new Label();
            label1 = new Label();
            label2 = new Label();
            lb_rg_datebirth = new Label();
            button1 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(tb_Dentist);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(lb_Success2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dateTimePicker4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(dateTimePicker3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(tb_Choose);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lb_Success);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lb_rg_datebirth);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 628);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.DropDownHeight = 140;
            comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy", "Chủ nhật" });
            comboBox1.Location = new Point(738, 459);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(332, 38);
            comboBox1.TabIndex = 122;
            // 
            // tb_Dentist
            // 
            tb_Dentist.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Dentist.FormattingEnabled = true;
            tb_Dentist.Items.AddRange(new object[] { "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy", "Chủ nhật" });
            tb_Dentist.Location = new Point(707, 89);
            tb_Dentist.Name = "tb_Dentist";
            tb_Dentist.Size = new Size(363, 38);
            tb_Dentist.TabIndex = 121;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(8, 48, 107);
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(407, 82);
            button4.Name = "button4";
            button4.Size = new Size(106, 48);
            button4.TabIndex = 120;
            button4.Text = "Xem";
            button4.UseVisualStyleBackColor = false;
            // 
            // lb_Success2
            // 
            lb_Success2.AutoSize = true;
            lb_Success2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Success2.Location = new Point(707, 590);
            lb_Success2.Name = "lb_Success2";
            lb_Success2.Size = new Size(268, 30);
            lb_Success2.TabIndex = 119;
            lb_Success2.Text = "Thêm lịch hẹn thành công!";
            lb_Success2.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(8, 48, 107);
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(892, 524);
            button2.Name = "button2";
            button2.Size = new Size(178, 60);
            button2.TabIndex = 118;
            button2.Text = "Thêm lịch hẹn";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker4.CustomFormat = "MM/yyyy";
            dateTimePicker4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(178, 86);
            dateTimePicker4.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dateTimePicker4.MinDate = new DateTime(2024, 1, 3, 0, 0, 0, 0);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(203, 36);
            dateTimePicker4.TabIndex = 116;
            dateTimePicker4.Value = new DateTime(2024, 1, 3, 12, 19, 52, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 92);
            label3.Name = "label3";
            label3.Size = new Size(130, 30);
            label3.TabIndex = 117;
            label3.Text = "Lịch cá nhân";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(474, 428);
            dataGridView1.TabIndex = 115;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.CustomFormat = "mm:HH";
            dateTimePicker3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(974, 156);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(96, 36);
            dateTimePicker3.TabIndex = 113;
            dateTimePicker3.Value = new DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(835, 163);
            label7.Name = "label7";
            label7.Size = new Size(129, 30);
            label7.TabIndex = 114;
            label7.Text = "Giờ kết thúc";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.CustomFormat = "mm:HH";
            dateTimePicker2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(707, 156);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(96, 36);
            dateTimePicker2.TabIndex = 111;
            dateTimePicker2.Value = new DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(568, 163);
            label6.Name = "label6";
            label6.Size = new Size(125, 30);
            label6.TabIndex = 112;
            label6.Text = "Giờ bắt đầu";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CustomFormat = "mm:HH";
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(742, 394);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(328, 36);
            dateTimePicker1.TabIndex = 106;
            dateTimePicker1.Value = new DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // tb_Choose
            // 
            tb_Choose.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Choose.CustomFormat = "dd/MM/yyyy";
            tb_Choose.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Choose.Format = DateTimePickerFormat.Custom;
            tb_Choose.Location = new Point(742, 334);
            tb_Choose.Name = "tb_Choose";
            tb_Choose.Size = new Size(328, 36);
            tb_Choose.TabIndex = 106;
            tb_Choose.Value = new DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(568, 401);
            label5.Name = "label5";
            label5.Size = new Size(88, 30);
            label5.TabIndex = 110;
            label5.Text = "Giờ hẹn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(568, 340);
            label4.Name = "label4";
            label4.Size = new Size(106, 30);
            label4.TabIndex = 108;
            label4.Text = "Ngày hẹn";
            // 
            // lb_Success
            // 
            lb_Success.AutoSize = true;
            lb_Success.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Success.Location = new Point(738, 280);
            lb_Success.Name = "lb_Success";
            lb_Success.Size = new Size(219, 30);
            lb_Success.TabIndex = 90;
            lb_Success.Text = "Cập nhật thành công!";
            lb_Success.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(504, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 35);
            label1.TabIndex = 89;
            label1.Text = "Lịch cá nhân";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(568, 467);
            label2.Name = "label2";
            label2.Size = new Size(155, 30);
            label2.TabIndex = 87;
            label2.Text = "Tên bệnh nhân";
            // 
            // lb_rg_datebirth
            // 
            lb_rg_datebirth.AutoSize = true;
            lb_rg_datebirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_datebirth.Location = new Point(568, 91);
            lb_rg_datebirth.Name = "lb_rg_datebirth";
            lb_rg_datebirth.Size = new Size(50, 30);
            lb_rg_datebirth.TabIndex = 86;
            lb_rg_datebirth.Text = "Thứ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 48, 107);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(892, 209);
            button1.Name = "button1";
            button1.Size = new Size(178, 60);
            button1.TabIndex = 84;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(8, 48, 107);
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(601, 524);
            button3.Name = "button3";
            button3.Size = new Size(178, 60);
            button3.TabIndex = 83;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Update_Schedule
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 652);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "Update_Schedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lb_Success;
        private Label label1;
        private Label label2;
        private Label lb_rg_datebirth;
        private Button button1;
        private Button button3;
        private Label label4;
        private DateTimePicker tb_Choose;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DateTimePicker dateTimePicker4;
        private Label label3;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker3;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private Label lb_Success2;
        private Button button2;
        private Button button4;
        private ComboBox tb_Dentist;
        private ComboBox comboBox1;
    }
}