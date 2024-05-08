namespace Dentist_Clinic_Management.Dentist
{
    partial class Info_Dentist_Update
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
            lb_failed = new Label();
            pictureBox5 = new PictureBox();
            bt_Back = new Button();
            bt_Ok = new Button();
            lb_mainUpdate = new Label();
            lb_anewPass = new Label();
            lb_oldPass = new Label();
            lb_newPass = new Label();
            lb_Name = new Label();
            tb_Name = new TextBox();
            tb_specialize = new TextBox();
            lab_specialize = new Label();
            tb_oldPass = new TextBox();
            tb_newPass = new TextBox();
            tb_reenter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lb_failed
            // 
            lb_failed.AutoSize = true;
            lb_failed.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_failed.ForeColor = Color.Red;
            lb_failed.Location = new Point(661, 496);
            lb_failed.Name = "lb_failed";
            lb_failed.Size = new Size(183, 30);
            lb_failed.TabIndex = 65;
            lb_failed.Text = "Cập nhật thất bại!";
            lb_failed.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Untitled_removebg_preview;
            pictureBox5.Location = new Point(12, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(442, 386);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 51;
            pictureBox5.TabStop = false;
            // 
            // bt_Back
            // 
            bt_Back.BackColor = Color.FromArgb(8, 48, 107);
            bt_Back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Back.ForeColor = Color.White;
            bt_Back.Location = new Point(549, 436);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(151, 57);
            bt_Back.TabIndex = 64;
            bt_Back.TabStop = false;
            bt_Back.Text = "Quay lại";
            bt_Back.UseVisualStyleBackColor = false;
            bt_Back.Click += bt_Back_Click;
            // 
            // bt_Ok
            // 
            bt_Ok.BackColor = Color.FromArgb(8, 48, 107);
            bt_Ok.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Ok.ForeColor = Color.White;
            bt_Ok.Location = new Point(836, 436);
            bt_Ok.Name = "bt_Ok";
            bt_Ok.Size = new Size(151, 57);
            bt_Ok.TabIndex = 63;
            bt_Ok.TabStop = false;
            bt_Ok.Text = "Xác nhận";
            bt_Ok.UseVisualStyleBackColor = false;
            bt_Ok.Click += bt_Ok_Click;
            // 
            // lb_mainUpdate
            // 
            lb_mainUpdate.AutoSize = true;
            lb_mainUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_mainUpdate.ForeColor = Color.FromArgb(8, 48, 107);
            lb_mainUpdate.Location = new Point(475, -69);
            lb_mainUpdate.Name = "lb_mainUpdate";
            lb_mainUpdate.Size = new Size(294, 30);
            lb_mainUpdate.TabIndex = 62;
            lb_mainUpdate.Text = "Cập nhật thông tin cá nhân";
            // 
            // lb_anewPass
            // 
            lb_anewPass.AutoSize = true;
            lb_anewPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_anewPass.Location = new Point(469, 240);
            lb_anewPass.Name = "lb_anewPass";
            lb_anewPass.Size = new Size(187, 30);
            lb_anewPass.TabIndex = 61;
            lb_anewPass.Text = "Nhập lại mật khẩu";
            // 
            // lb_oldPass
            // 
            lb_oldPass.AutoSize = true;
            lb_oldPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_oldPass.Location = new Point(469, 125);
            lb_oldPass.Name = "lb_oldPass";
            lb_oldPass.Size = new Size(131, 30);
            lb_oldPass.TabIndex = 60;
            lb_oldPass.Text = "Mật khẩu cũ";
            // 
            // lb_newPass
            // 
            lb_newPass.AutoSize = true;
            lb_newPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_newPass.Location = new Point(469, 180);
            lb_newPass.Name = "lb_newPass";
            lb_newPass.Size = new Size(146, 30);
            lb_newPass.TabIndex = 59;
            lb_newPass.Text = "Mật khẩu mới";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Name.Location = new Point(469, 21);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(107, 30);
            lb_Name.TabIndex = 47;
            lb_Name.Text = "Họ và tên";
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(672, 14);
            tb_Name.Name = "tb_Name";
            tb_Name.RightToLeft = RightToLeft.No;
            tb_Name.Size = new Size(391, 36);
            tb_Name.TabIndex = 14;
            tb_Name.TabStop = false;
            // 
            // tb_specialize
            // 
            tb_specialize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_specialize.Location = new Point(672, 66);
            tb_specialize.Name = "tb_specialize";
            tb_specialize.RightToLeft = RightToLeft.No;
            tb_specialize.Size = new Size(391, 36);
            tb_specialize.TabIndex = 14;
            tb_specialize.TabStop = false;
            // 
            // lab_specialize
            // 
            lab_specialize.AutoSize = true;
            lab_specialize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_specialize.Location = new Point(469, 72);
            lab_specialize.Name = "lab_specialize";
            lab_specialize.Size = new Size(136, 30);
            lab_specialize.TabIndex = 47;
            lab_specialize.Text = "Chuyên môn";
            // 
            // tb_oldPass
            // 
            tb_oldPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_oldPass.Location = new Point(672, 119);
            tb_oldPass.Name = "tb_oldPass";
            tb_oldPass.RightToLeft = RightToLeft.No;
            tb_oldPass.Size = new Size(391, 36);
            tb_oldPass.TabIndex = 14;
            tb_oldPass.TabStop = false;
            // 
            // tb_newPass
            // 
            tb_newPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_newPass.Location = new Point(672, 173);
            tb_newPass.Name = "tb_newPass";
            tb_newPass.RightToLeft = RightToLeft.No;
            tb_newPass.Size = new Size(391, 36);
            tb_newPass.TabIndex = 14;
            tb_newPass.TabStop = false;
            // 
            // tb_reenter
            // 
            tb_reenter.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_reenter.Location = new Point(672, 234);
            tb_reenter.Name = "tb_reenter";
            tb_reenter.RightToLeft = RightToLeft.No;
            tb_reenter.Size = new Size(391, 36);
            tb_reenter.TabIndex = 14;
            tb_reenter.TabStop = false;
            // 
            // Info_Dentist_Update
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1076, 531);
            ControlBox = false;
            Controls.Add(tb_reenter);
            Controls.Add(tb_newPass);
            Controls.Add(tb_oldPass);
            Controls.Add(tb_specialize);
            Controls.Add(tb_Name);
            Controls.Add(lb_failed);
            Controls.Add(pictureBox5);
            Controls.Add(bt_Back);
            Controls.Add(bt_Ok);
            Controls.Add(lb_mainUpdate);
            Controls.Add(lb_anewPass);
            Controls.Add(lb_oldPass);
            Controls.Add(lb_newPass);
            Controls.Add(lab_specialize);
            Controls.Add(lb_Name);
            Name = "Info_Dentist_Update";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_failed;
        private PictureBox pictureBox5;
        private Button bt_Back;
        private Button bt_Ok;
        private Label lb_mainUpdate;
        private Label lb_anewPass;
        private Label lb_oldPass;
        private Label lb_newPass;
        private Label lb_Name;
        private TextBox tb_Name;
        private TextBox tb_specialize;
        private Label lab_specialize;
        private TextBox tb_oldPass;
        private TextBox tb_newPass;
        private TextBox tb_reenter;
    }
}