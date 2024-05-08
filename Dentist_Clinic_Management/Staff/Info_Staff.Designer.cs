namespace Dentist_Clinic_Management.Staff
{
    partial class Info_Staff
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
            label1 = new Label();
            lb_rg_Name = new Label();
            pn_rg_Name = new Panel();
            tb_Name = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            btnSave = new Button();
            C_pt_account = new PictureBox();
            label4 = new Label();
            panel3 = new Panel();
            textBox3 = new TextBox();
            lab_incorrect = new Label();
            label5 = new Label();
            pn_rg_Name.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)C_pt_account).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.7090912F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(283, 39);
            label1.Name = "label1";
            label1.Size = new Size(292, 37);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // lb_rg_Name
            // 
            lb_rg_Name.AutoSize = true;
            lb_rg_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_Name.Location = new Point(281, 149);
            lb_rg_Name.Name = "lb_rg_Name";
            lb_rg_Name.Size = new Size(152, 31);
            lb_rg_Name.TabIndex = 31;
            lb_rg_Name.Text = "Mã nhân viên";
            // 
            // pn_rg_Name
            // 
            pn_rg_Name.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Name.Controls.Add(tb_Name);
            pn_rg_Name.Location = new Point(445, 140);
            pn_rg_Name.Name = "pn_rg_Name";
            pn_rg_Name.Size = new Size(332, 45);
            pn_rg_Name.TabIndex = 32;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(3, 2);
            tb_Name.Name = "tb_Name";
            tb_Name.ReadOnly = true;
            tb_Name.RightToLeft = RightToLeft.No;
            tb_Name.Size = new Size(320, 38);
            tb_Name.TabIndex = 14;
            tb_Name.TabStop = false;
            tb_Name.TextChanged += tb_Name_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(281, 213);
            label2.Name = "label2";
            label2.Size = new Size(82, 31);
            label2.TabIndex = 33;
            label2.Text = "Họ tên";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(445, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 45);
            panel1.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(320, 38);
            textBox1.TabIndex = 14;
            textBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(281, 341);
            label3.Name = "label3";
            label3.Size = new Size(156, 31);
            label3.TabIndex = 35;
            label3.Text = "Mật khẩu mới";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(445, 332);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 45);
            panel2.TabIndex = 36;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(3, 2);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(320, 38);
            textBox2.TabIndex = 14;
            textBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(8, 48, 107);
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(626, 398);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 60);
            btnSave.TabIndex = 40;
            btnSave.TabStop = false;
            btnSave.Text = "Lưu thay đổi";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnBack_Click;
            // 
            // C_pt_account
            // 
            C_pt_account.BackColor = Color.FromArgb(8, 48, 107);
            C_pt_account.Image = Properties.Resources.doctor__1_;
            C_pt_account.Location = new Point(49, 140);
            C_pt_account.Name = "C_pt_account";
            C_pt_account.Size = new Size(192, 196);
            C_pt_account.SizeMode = PictureBoxSizeMode.Zoom;
            C_pt_account.TabIndex = 41;
            C_pt_account.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(281, 279);
            label4.Name = "label4";
            label4.Size = new Size(140, 31);
            label4.TabIndex = 42;
            label4.Text = "Mật khẩu cũ";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox3);
            panel3.Location = new Point(445, 270);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 45);
            panel3.TabIndex = 43;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(3, 2);
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = RightToLeft.No;
            textBox3.Size = new Size(320, 38);
            textBox3.TabIndex = 14;
            textBox3.TabStop = false;
            // 
            // lab_incorrect
            // 
            lab_incorrect.AutoSize = true;
            lab_incorrect.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_incorrect.ForeColor = Color.Red;
            lab_incorrect.Location = new Point(429, 412);
            lab_incorrect.Name = "lab_incorrect";
            lab_incorrect.Size = new Size(174, 31);
            lab_incorrect.TabIndex = 15;
            lab_incorrect.Text = "Mật khẩu cũ sai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(449, 461);
            label5.Name = "label5";
            label5.Size = new Size(329, 31);
            label5.TabIndex = 44;
            label5.Text = "Cập nhật mật khẩu thành công";
            // 
            // Info_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 505);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(lab_incorrect);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(C_pt_account);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(lb_rg_Name);
            Controls.Add(pn_rg_Name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Info_Staff";
            pn_rg_Name.ResumeLayout(false);
            pn_rg_Name.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)C_pt_account).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_rg_Name;
        private Panel pn_rg_Name;
        private TextBox tb_Name;
        private Label label2;
        private Panel panel1;
        private TextBox textBox1;
        private Label label3;
        private Panel panel2;
        private TextBox textBox2;
        private Button btnSave;
        private PictureBox C_pt_account;
        private Label label4;
        private Panel panel3;
        private TextBox textBox3;
        private Label lab_incorrect;
        private Label label5;
    }
}