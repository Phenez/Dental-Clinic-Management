namespace Dentist_Clinic_Management.Warming_Client
{
    partial class No_Appointment
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
            bt_Beck = new Button();
            bt_Ok = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(bt_Beck);
            panel1.Controls.Add(bt_Ok);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 196);
            panel1.TabIndex = 1;
            // 
            // bt_Beck
            // 
            bt_Beck.BackColor = Color.FromArgb(8, 48, 107);
            bt_Beck.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Beck.ForeColor = Color.White;
            bt_Beck.Location = new Point(53, 103);
            bt_Beck.Name = "bt_Beck";
            bt_Beck.Size = new Size(151, 60);
            bt_Beck.TabIndex = 45;
            bt_Beck.TabStop = false;
            bt_Beck.Text = "Quay lại";
            bt_Beck.UseVisualStyleBackColor = false;
            // 
            // bt_Ok
            // 
            bt_Ok.BackColor = Color.FromArgb(8, 48, 107);
            bt_Ok.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Ok.ForeColor = Color.White;
            bt_Ok.Location = new Point(300, 103);
            bt_Ok.Name = "bt_Ok";
            bt_Ok.Size = new Size(151, 60);
            bt_Ok.TabIndex = 44;
            bt_Ok.TabStop = false;
            bt_Ok.Text = "Đặt lịch ngay";
            bt_Ok.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(442, 31);
            label1.TabIndex = 0;
            label1.Text = "Bạn chưa có lịch hẹn nào tại phòng khám!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // No_Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(531, 220);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "No_Appointment";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_Beck;
        private Button bt_Ok;
        private Label label1;
    }
}