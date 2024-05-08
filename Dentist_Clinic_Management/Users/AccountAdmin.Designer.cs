namespace Dentist_Clinic_Management.Users
{
    partial class AccountAdmin
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
            lab_account = new Label();
            lab_pass = new Label();
            tb_account = new TextBox();
            tb_pass = new TextBox();
            pic_Back = new PictureBox();
            but_changepass = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Back).BeginInit();
            SuspendLayout();
            // 
            // lab_account
            // 
            lab_account.AutoSize = true;
            lab_account.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_account.Location = new Point(3, 37);
            lab_account.Name = "lab_account";
            lab_account.Size = new Size(104, 30);
            lab_account.TabIndex = 1;
            lab_account.Text = "Tài khoản";
            // 
            // lab_pass
            // 
            lab_pass.AutoSize = true;
            lab_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_pass.Location = new Point(3, 86);
            lab_pass.Name = "lab_pass";
            lab_pass.Size = new Size(103, 30);
            lab_pass.TabIndex = 1;
            lab_pass.Text = "Mật khẩu";
            // 
            // tb_account
            // 
            tb_account.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_account.Location = new Point(118, 34);
            tb_account.Name = "tb_account";
            tb_account.ReadOnly = true;
            tb_account.Size = new Size(336, 36);
            tb_account.TabIndex = 9;
            tb_account.TabStop = false;
            // 
            // tb_pass
            // 
            tb_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_pass.Location = new Point(118, 83);
            tb_pass.Name = "tb_pass";
            tb_pass.ReadOnly = true;
            tb_pass.Size = new Size(336, 36);
            tb_pass.TabIndex = 9;
            tb_pass.TabStop = false;
            // 
            // pic_Back
            // 
            pic_Back.Image = Properties.Resources.previous;
            pic_Back.Location = new Point(12, 162);
            pic_Back.Name = "pic_Back";
            pic_Back.Size = new Size(50, 46);
            pic_Back.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Back.TabIndex = 11;
            pic_Back.TabStop = false;
            pic_Back.Click += pic_Back_Click;
            // 
            // but_changepass
            // 
            but_changepass.BackColor = Color.FromArgb(7, 47, 128);
            but_changepass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_changepass.ForeColor = Color.White;
            but_changepass.Location = new Point(287, 157);
            but_changepass.Name = "but_changepass";
            but_changepass.Size = new Size(167, 50);
            but_changepass.TabIndex = 12;
            but_changepass.TabStop = false;
            but_changepass.Text = "Đổi mật khẩu";
            but_changepass.UseVisualStyleBackColor = false;
            but_changepass.Click += but_changepass_Click;
            // 
            // AccountAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(466, 218);
            ControlBox = false;
            Controls.Add(but_changepass);
            Controls.Add(pic_Back);
            Controls.Add(tb_pass);
            Controls.Add(tb_account);
            Controls.Add(lab_pass);
            Controls.Add(lab_account);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AccountAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pic_Back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_account;
        private Label lab_pass;
        private TextBox tb_account;
        private TextBox tb_pass;
        private PictureBox pic_Back;
        private Button but_changepass;
    }
}