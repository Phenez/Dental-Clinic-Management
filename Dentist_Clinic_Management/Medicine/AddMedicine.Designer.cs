namespace Dentist_Clinic_Management.Medicine
{
    partial class AddMedicine
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
            main_panel = new Panel();
            but_Seen = new Button();
            pic_Back = new PictureBox();
            data_list_patient = new DataGridView();
            lab_main = new Label();
            panel1 = new Panel();
            tb_expired = new DateTimePicker();
            lab_expired = new Label();
            tb_avail = new TextBox();
            tb_unit = new TextBox();
            tb_cost = new TextBox();
            tb_detail = new TextBox();
            but_Add = new Button();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lab_avail = new Label();
            lab_unit = new Label();
            lab_detail = new Label();
            lab_cost = new Label();
            lab_name = new Label();
            lab_id = new Label();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_list_patient).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(but_Seen);
            main_panel.Controls.Add(pic_Back);
            main_panel.Controls.Add(data_list_patient);
            main_panel.Controls.Add(lab_main);
            main_panel.Controls.Add(panel1);
            main_panel.Location = new Point(12, 11);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1124, 611);
            main_panel.TabIndex = 11;
            // 
            // but_Seen
            // 
            but_Seen.BackColor = Color.FromArgb(7, 47, 128);
            but_Seen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Seen.ForeColor = Color.White;
            but_Seen.Location = new Point(334, 555);
            but_Seen.Name = "but_Seen";
            but_Seen.Size = new Size(173, 50);
            but_Seen.TabIndex = 27;
            but_Seen.TabStop = false;
            but_Seen.Text = "Xem tất cả";
            but_Seen.UseVisualStyleBackColor = false;
            // 
            // pic_Back
            // 
            pic_Back.Image = Properties.Resources.previous;
            pic_Back.Location = new Point(17, 3);
            pic_Back.Name = "pic_Back";
            pic_Back.Size = new Size(50, 46);
            pic_Back.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Back.TabIndex = 10;
            pic_Back.TabStop = false;
            pic_Back.Click += pic_Back_Click;
            // 
            // data_list_patient
            // 
            data_list_patient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_patient.Location = new Point(17, 109);
            data_list_patient.Name = "data_list_patient";
            data_list_patient.RowHeadersWidth = 51;
            data_list_patient.RowTemplate.Height = 29;
            data_list_patient.Size = new Size(490, 440);
            data_list_patient.TabIndex = 26;
            // 
            // lab_main
            // 
            lab_main.AutoSize = true;
            lab_main.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_main.ForeColor = Color.FromArgb(7, 47, 128);
            lab_main.Location = new Point(334, 3);
            lab_main.Name = "lab_main";
            lab_main.Size = new Size(392, 35);
            lab_main.TabIndex = 6;
            lab_main.Text = "Quản lý danh sách thuốc - Thêm";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tb_expired);
            panel1.Controls.Add(lab_expired);
            panel1.Controls.Add(tb_avail);
            panel1.Controls.Add(tb_unit);
            panel1.Controls.Add(tb_cost);
            panel1.Controls.Add(tb_detail);
            panel1.Controls.Add(but_Add);
            panel1.Controls.Add(tb_name);
            panel1.Controls.Add(tb_id);
            panel1.Controls.Add(lab_avail);
            panel1.Controls.Add(lab_unit);
            panel1.Controls.Add(lab_detail);
            panel1.Controls.Add(lab_cost);
            panel1.Controls.Add(lab_name);
            panel1.Controls.Add(lab_id);
            panel1.Location = new Point(530, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 496);
            panel1.TabIndex = 23;
            // 
            // tb_expired
            // 
            tb_expired.CustomFormat = "HH:mm MM/dd/yyyy";
            tb_expired.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_expired.Format = DateTimePickerFormat.Custom;
            tb_expired.Location = new Point(176, 401);
            tb_expired.MinDate = new DateTime(2024, 1, 11, 0, 0, 0, 0);
            tb_expired.Name = "tb_expired";
            tb_expired.Size = new Size(387, 36);
            tb_expired.TabIndex = 19;
            tb_expired.TabStop = false;
            // 
            // lab_expired
            // 
            lab_expired.AutoSize = true;
            lab_expired.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_expired.Location = new Point(13, 407);
            lab_expired.Name = "lab_expired";
            lab_expired.Size = new Size(142, 30);
            lab_expired.TabIndex = 16;
            lab_expired.Text = "Ngày hết hạn";
            // 
            // tb_avail
            // 
            tb_avail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_avail.Location = new Point(176, 342);
            tb_avail.Name = "tb_avail";
            tb_avail.Size = new Size(387, 36);
            tb_avail.TabIndex = 15;
            tb_avail.TabStop = false;
            // 
            // tb_unit
            // 
            tb_unit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_unit.Location = new Point(176, 286);
            tb_unit.Name = "tb_unit";
            tb_unit.Size = new Size(387, 36);
            tb_unit.TabIndex = 15;
            tb_unit.TabStop = false;
            // 
            // tb_cost
            // 
            tb_cost.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_cost.Location = new Point(176, 236);
            tb_cost.Name = "tb_cost";
            tb_cost.Size = new Size(387, 36);
            tb_cost.TabIndex = 15;
            tb_cost.TabStop = false;
            // 
            // tb_detail
            // 
            tb_detail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_detail.Location = new Point(176, 128);
            tb_detail.Multiline = true;
            tb_detail.Name = "tb_detail";
            tb_detail.Size = new Size(387, 91);
            tb_detail.TabIndex = 14;
            tb_detail.TabStop = false;
            // 
            // but_Add
            // 
            but_Add.BackColor = Color.FromArgb(7, 47, 128);
            but_Add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Add.ForeColor = Color.White;
            but_Add.Location = new Point(438, 443);
            but_Add.Name = "but_Add";
            but_Add.Size = new Size(125, 50);
            but_Add.TabIndex = 5;
            but_Add.TabStop = false;
            but_Add.Text = "Thêm";
            but_Add.UseVisualStyleBackColor = false;
            but_Add.Click += but_Add_Click;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name.Location = new Point(176, 71);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(387, 36);
            tb_name.TabIndex = 10;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id.Location = new Point(176, 19);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(387, 36);
            tb_id.TabIndex = 8;
            tb_id.TabStop = false;
            // 
            // lab_avail
            // 
            lab_avail.AutoSize = true;
            lab_avail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_avail.Location = new Point(13, 349);
            lab_avail.Name = "lab_avail";
            lab_avail.Size = new Size(154, 30);
            lab_avail.TabIndex = 7;
            lab_avail.Text = "Lượng tồn kho";
            // 
            // lab_unit
            // 
            lab_unit.AutoSize = true;
            lab_unit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_unit.Location = new Point(13, 293);
            lab_unit.Name = "lab_unit";
            lab_unit.Size = new Size(117, 30);
            lab_unit.TabIndex = 7;
            lab_unit.Text = "Đơn vị tính";
            // 
            // lab_detail
            // 
            lab_detail.AutoSize = true;
            lab_detail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_detail.Location = new Point(13, 131);
            lab_detail.Name = "lab_detail";
            lab_detail.Size = new Size(92, 30);
            lab_detail.TabIndex = 6;
            lab_detail.Text = "Chỉ định";
            // 
            // lab_cost
            // 
            lab_cost.AutoSize = true;
            lab_cost.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_cost.Location = new Point(13, 242);
            lab_cost.Name = "lab_cost";
            lab_cost.Size = new Size(88, 30);
            lab_cost.TabIndex = 5;
            lab_cost.Text = "Đơn giá";
            // 
            // lab_name
            // 
            lab_name.AutoSize = true;
            lab_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_name.Location = new Point(13, 74);
            lab_name.Name = "lab_name";
            lab_name.Size = new Size(107, 30);
            lab_name.TabIndex = 1;
            lab_name.Text = "Tên thuốc";
            // 
            // lab_id
            // 
            lab_id.AutoSize = true;
            lab_id.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_id.Location = new Point(13, 22);
            lab_id.Name = "lab_id";
            lab_id.Size = new Size(104, 30);
            lab_id.TabIndex = 0;
            lab_id.Text = "Mã thuốc";
            // 
            // AddMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 127);
            ClientSize = new Size(1148, 634);
            ControlBox = false;
            Controls.Add(main_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddMedicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_list_patient).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private Button but_Seen;
        private PictureBox pic_Back;
        private DataGridView data_list_patient;
        private Label lab_main;
        private Panel panel1;
        private Label label1;
        private DateTimePicker tb_expired;
        private Label lab_expired;
        private TextBox tb_detail;
        private TextBox tb_cost;
        private Button but_Add;
        private TextBox tb_id;
        private TextBox tb_name;
        private Label lab_unit;
        private Label lab_detail;
        private Label lab_cost;
        private Label lab_name;
        private Label lab_id;
        private TextBox tb_avail;
        private TextBox tb_unit;
        private Label lab_avail;
    }
}