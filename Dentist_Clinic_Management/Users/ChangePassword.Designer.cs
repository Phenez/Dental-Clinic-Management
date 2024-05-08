namespace Dentist_Clinic_Management.Users
{
    partial class ChangePassword
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
            but_confirm = new Button();
            pic_Back = new PictureBox();
            tb_reenter = new TextBox();
            tb_newpass = new TextBox();
            lab_reenter = new Label();
            lab_newpass = new Label();
            lab_incorrect = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_Back).BeginInit();
            SuspendLayout();
            // 
            // but_confirm
            // 
            but_confirm.BackColor = Color.FromArgb(7, 47, 128);
            but_confirm.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_confirm.ForeColor = Color.White;
            but_confirm.Location = new Point(343, 128);
            but_confirm.Name = "but_confirm";
            but_confirm.Size = new Size(167, 50);
            but_confirm.TabIndex = 18;
            but_confirm.TabStop = false;
            but_confirm.Text = "Xác nhận";
            but_confirm.UseVisualStyleBackColor = false;
            but_confirm.Click += but_confirm_Click;
            // 
            // pic_Back
            // 
            pic_Back.Image = Properties.Resources.previous;
            pic_Back.Location = new Point(21, 133);
            pic_Back.Name = "pic_Back";
            pic_Back.Size = new Size(50, 46);
            pic_Back.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Back.TabIndex = 17;
            pic_Back.TabStop = false;
            pic_Back.Click += pic_Back_Click;
            // 
            // tb_reenter
            // 
            tb_reenter.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_reenter.Location = new Point(174, 54);
            tb_reenter.Name = "tb_reenter";
            tb_reenter.Size = new Size(336, 36);
            tb_reenter.TabIndex = 15;
            tb_reenter.TabStop = false;
            // 
            // tb_newpass
            // 
            tb_newpass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_newpass.Location = new Point(174, 6);
            tb_newpass.Name = "tb_newpass";
            tb_newpass.Size = new Size(336, 36);
            tb_newpass.TabIndex = 16;
            tb_newpass.TabStop = false;
            // 
            // lab_reenter
            // 
            lab_reenter.AutoSize = true;
            lab_reenter.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_reenter.Location = new Point(12, 57);
            lab_reenter.Name = "lab_reenter";
            lab_reenter.Size = new Size(92, 30);
            lab_reenter.TabIndex = 13;
            lab_reenter.Text = "Nhập lại";
            // 
            // lab_newpass
            // 
            lab_newpass.AutoSize = true;
            lab_newpass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_newpass.Location = new Point(12, 9);
            lab_newpass.Name = "lab_newpass";
            lab_newpass.Size = new Size(146, 30);
            lab_newpass.TabIndex = 14;
            lab_newpass.Text = "Mật khẩu mới";
            // 
            // lab_incorrect
            // 
            lab_incorrect.AutoSize = true;
            lab_incorrect.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_incorrect.ForeColor = Color.Red;
            lab_incorrect.Location = new Point(91, 96);
            lab_incorrect.Name = "lab_incorrect";
            lab_incorrect.Size = new Size(393, 30);
            lab_incorrect.TabIndex = 13;
            lab_incorrect.Text = "Nhập lại không khớp với mật khẩu mới!";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 189);
            ControlBox = false;
            Controls.Add(but_confirm);
            Controls.Add(pic_Back);
            Controls.Add(tb_reenter);
            Controls.Add(tb_newpass);
            Controls.Add(lab_incorrect);
            Controls.Add(lab_reenter);
            Controls.Add(lab_newpass);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pic_Back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_confirm;
        private PictureBox pic_Back;
        private TextBox tb_reenter;
        private TextBox tb_newpass;
        private Label lab_reenter;
        private Label lab_newpass;
        private Label lab_incorrect;
    }
}