namespace Dentist_Clinic_Management.Staff
{
    partial class PatientRecord_Staff
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
            button2 = new Button();
            btnSearch = new Button();
            lb_Header = new Label();
            txbPhoneNum = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            label11 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            textBox9 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            lb_success = new Label();
            btnAddBill = new Button();
            label3 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            lb_Name = new Label();
            textBox1 = new TextBox();
            lb_Header2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(lb_Header);
            panel1.Controls.Add(txbPhoneNum);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 528);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(283, 479);
            button2.Name = "button2";
            button2.Size = new Size(133, 39);
            button2.TabIndex = 17;
            button2.TabStop = false;
            button2.Text = "Xem tất cả";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Navy;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(283, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 39);
            btnSearch.TabIndex = 16;
            btnSearch.TabStop = false;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lb_Header
            // 
            lb_Header.AutoSize = true;
            lb_Header.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Header.Location = new Point(57, 18);
            lb_Header.Name = "lb_Header";
            lb_Header.Size = new Size(337, 37);
            lb_Header.TabIndex = 3;
            lb_Header.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // txbPhoneNum
            // 
            txbPhoneNum.Font = new Font("Segoe UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point);
            txbPhoneNum.Location = new Point(25, 69);
            txbPhoneNum.Name = "txbPhoneNum";
            txbPhoneNum.PlaceholderText = "Số điện thoại";
            txbPhoneNum.Size = new Size(240, 29);
            txbPhoneNum.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(391, 349);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lb_success);
            panel2.Controls.Add(btnAddBill);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(lb_Name);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lb_Header2);
            panel2.Location = new Point(453, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 528);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(textBox9);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox8);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(-1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(375, 528);
            panel3.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(49, 377);
            label11.Name = "label11";
            label11.Size = new Size(96, 28);
            label11.TabIndex = 21;
            label11.Text = "Số lượng:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(151, 377);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(192, 27);
            textBox10.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(-1, 184);
            label10.Name = "label10";
            label10.Size = new Size(150, 28);
            label10.TabIndex = 19;
            label10.Text = "Ngày giờ khám:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(152, 185);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(192, 27);
            textBox9.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(115, 484);
            label5.Name = "label5";
            label5.Size = new Size(152, 28);
            label5.TabIndex = 17;
            label5.Text = "Tạo thành công.";
            label5.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(110, 428);
            button1.Name = "button1";
            button1.Size = new Size(151, 39);
            button1.TabIndex = 16;
            button1.TabStop = false;
            button1.Text = "Tạo hóa đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(76, 331);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 12;
            label6.Text = "Thuốc:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(152, 330);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(192, 27);
            textBox6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(52, 284);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 10;
            label7.Text = "Phí khám:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(152, 283);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(192, 27);
            textBox7.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 234);
            label8.Name = "label8";
            label8.Size = new Size(134, 28);
            label8.TabIndex = 8;
            label8.Text = "Dịch vụ khám:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(152, 233);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(192, 27);
            textBox8.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 142);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 6;
            label4.Text = "Họ tên:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(151, 142);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(192, 27);
            textBox5.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(27, 69);
            label9.Name = "label9";
            label9.Size = new Size(344, 37);
            label9.TabIndex = 4;
            label9.Text = "THÔNG TIN THANH TOÁN";
            // 
            // lb_success
            // 
            lb_success.AutoSize = true;
            lb_success.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            lb_success.Location = new Point(115, 439);
            lb_success.Name = "lb_success";
            lb_success.Size = new Size(152, 28);
            lb_success.TabIndex = 17;
            lb_success.Text = "Tạo thành công.";
            lb_success.Visible = false;
            // 
            // btnAddBill
            // 
            btnAddBill.BackColor = Color.Navy;
            btnAddBill.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBill.ForeColor = Color.White;
            btnAddBill.Location = new Point(110, 383);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(151, 39);
            btnAddBill.TabIndex = 16;
            btnAddBill.TabStop = false;
            btnAddBill.Text = "Tạo hóa đơn";
            btnAddBill.UseVisualStyleBackColor = false;
            btnAddBill.Click += btnAddBill_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(76, 351);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 12;
            label3.Text = "Thuốc:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 350);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 27);
            textBox4.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 304);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 10;
            label2.Text = "Phí khám:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 303);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 27);
            textBox3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 254);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 8;
            label1.Text = "Dịch vụ khám:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 253);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 27);
            textBox2.TabIndex = 7;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Name.Location = new Point(71, 163);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(75, 28);
            lb_Name.TabIndex = 6;
            lb_Name.Text = "Họ tên:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 5;
            // 
            // lb_Header2
            // 
            lb_Header2.AutoSize = true;
            lb_Header2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Header2.Location = new Point(27, 69);
            lb_Header2.Name = "lb_Header2";
            lb_Header2.Size = new Size(344, 37);
            lb_Header2.TabIndex = 4;
            lb_Header2.Text = "THÔNG TIN THANH TOÁN";
            // 
            // PatientRecord_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 533);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PatientRecord_Staff";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label lb_Header;
        private TextBox txbPhoneNum;
        private Label lb_Header2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private Label lb_Name;
        private Label label3;
        private TextBox textBox4;
        private Button btnSearch;
        private Button btnAddBill;
        private Label lb_success;
        private Panel panel3;
        private Label label10;
        private TextBox textBox9;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label4;
        private TextBox textBox5;
        private Label label9;
        private Label label11;
        private TextBox textBox10;
        private Button button2;
    }
}