namespace Dentist_Clinic_Management.Warming_Admin
{
    partial class Failed
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
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bt_Beck);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 196);
            panel1.TabIndex = 3;
            // 
            // bt_Beck
            // 
            bt_Beck.BackColor = Color.FromArgb(8, 48, 107);
            bt_Beck.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Beck.ForeColor = Color.White;
            bt_Beck.Location = new Point(332, 131);
            bt_Beck.Name = "bt_Beck";
            bt_Beck.Size = new Size(151, 60);
            bt_Beck.TabIndex = 45;
            bt_Beck.TabStop = false;
            bt_Beck.Text = "Quay lại";
            bt_Beck.UseVisualStyleBackColor = false;
            bt_Beck.Click += bt_Beck_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(91, 79);
            label1.Name = "label1";
            label1.Size = new Size(302, 41);
            label1.TabIndex = 0;
            label1.Text = "Vui lòng kiểm tra lại!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 19);
            label2.Name = "label2";
            label2.Size = new Size(324, 41);
            label2.TabIndex = 46;
            label2.Text = "Lỗi, không thành công";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Book_Failed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(531, 220);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Book_Failed";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button bt_Beck;
        private Label label1;
    }
}