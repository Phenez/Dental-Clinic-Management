namespace Dentist_Clinic_Management.Dentist
{
    partial class Info_Dentist
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
            picLogo = new PictureBox();
            bt_Beck = new Button();
            label1 = new Label();
            label2 = new Label();
            lb_rg_datebirth = new Label();
            lb_rg_Name = new Label();
            panel3 = new Panel();
            tb_Birth = new TextBox();
            pictureBox2 = new PictureBox();
            pn_rg_Addr = new Panel();
            tb_Address = new TextBox();
            pc_Lg_Un = new PictureBox();
            pn_rg_Name = new Panel();
            tb_Name = new TextBox();
            pc_rg_name = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pn_rg_Addr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Lg_Un).BeginInit();
            pn_rg_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(picLogo);
            panel1.Controls.Add(bt_Beck);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lb_rg_datebirth);
            panel1.Controls.Add(lb_rg_Name);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pn_rg_Addr);
            panel1.Controls.Add(pn_rg_Name);
            panel1.Location = new Point(11, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 597);
            panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Untitled_removebg_preview;
            picLogo.Location = new Point(32, 86);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(482, 385);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 40;
            picLogo.TabStop = false;
            // 
            // bt_Beck
            // 
            bt_Beck.BackColor = Color.FromArgb(8, 48, 107);
            bt_Beck.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Beck.ForeColor = Color.White;
            bt_Beck.Location = new Point(905, 483);
            bt_Beck.Name = "bt_Beck";
            bt_Beck.Size = new Size(151, 57);
            bt_Beck.TabIndex = 39;
            bt_Beck.TabStop = false;
            bt_Beck.Text = "Quay lại";
            bt_Beck.UseVisualStyleBackColor = false;
            bt_Beck.Click += bt_Beck_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(656, 67);
            label1.Name = "label1";
            label1.Size = new Size(226, 35);
            label1.TabIndex = 37;
            label1.Text = "Thông tin cá nhân";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(520, 384);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 33;
            label2.Text = "Chuyên môn";
            // 
            // lb_rg_datebirth
            // 
            lb_rg_datebirth.AutoSize = true;
            lb_rg_datebirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_datebirth.Location = new Point(520, 281);
            lb_rg_datebirth.Name = "lb_rg_datebirth";
            lb_rg_datebirth.Size = new Size(79, 30);
            lb_rg_datebirth.TabIndex = 31;
            lb_rg_datebirth.Text = "Họ tên";
            // 
            // lb_rg_Name
            // 
            lb_rg_Name.AutoSize = true;
            lb_rg_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_Name.Location = new Point(520, 182);
            lb_rg_Name.Name = "lb_rg_Name";
            lb_rg_Name.Size = new Size(105, 30);
            lb_rg_Name.TabIndex = 29;
            lb_rg_Name.Text = "Mã nha sĩ";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tb_Birth);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(670, 271);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 43);
            panel3.TabIndex = 32;
            // 
            // tb_Birth
            // 
            tb_Birth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Birth.Location = new Point(54, 3);
            tb_Birth.Name = "tb_Birth";
            tb_Birth.ReadOnly = true;
            tb_Birth.Size = new Size(331, 36);
            tb_Birth.TabIndex = 13;
            tb_Birth.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.doctor;
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
            pn_rg_Addr.Location = new Point(670, 373);
            pn_rg_Addr.Name = "pn_rg_Addr";
            pn_rg_Addr.Size = new Size(391, 43);
            pn_rg_Addr.TabIndex = 34;
            // 
            // tb_Address
            // 
            tb_Address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Address.Location = new Point(54, 3);
            tb_Address.Name = "tb_Address";
            tb_Address.ReadOnly = true;
            tb_Address.Size = new Size(331, 36);
            tb_Address.TabIndex = 12;
            tb_Address.TabStop = false;
            // 
            // pc_Lg_Un
            // 
            pc_Lg_Un.Image = Properties.Resources.stethoscope;
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
            pn_rg_Name.Location = new Point(670, 172);
            pn_rg_Name.Name = "pn_rg_Name";
            pn_rg_Name.Size = new Size(391, 43);
            pn_rg_Name.TabIndex = 30;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(54, 3);
            tb_Name.Name = "tb_Name";
            tb_Name.ReadOnly = true;
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
            // Info_Dentist
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 619);
            ControlBox = false;
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Info_Dentist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pn_rg_Addr.ResumeLayout(false);
            pn_rg_Addr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Lg_Un).EndInit();
            pn_rg_Name.ResumeLayout(false);
            pn_rg_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_Beck;
        private Label label1;
        private Label label2;
        private Label lb_rg_datebirth;
        private Label lb_rg_Name;
        private Panel panel3;
        private TextBox tb_Birth;
        private PictureBox pictureBox2;
        private Panel pn_rg_Addr;
        private TextBox tb_Address;
        private PictureBox pc_Lg_Un;
        private Panel pn_rg_Name;
        private TextBox tb_Name;
        private PictureBox pc_rg_name;
        private PictureBox picLogo;
    }
}