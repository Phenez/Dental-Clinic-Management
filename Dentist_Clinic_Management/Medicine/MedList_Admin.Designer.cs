namespace Dentist_Clinic_Management.Medicine
{
    partial class MedList_Admin
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
            panel2 = new Panel();
            but_del = new Button();
            lab_expired = new Label();
            tb_expired = new TextBox();
            tb_avail = new TextBox();
            but_Update = new Button();
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
            pic_Back = new PictureBox();
            lab_main = new Label();
            but_Seen = new Button();
            data_list_medi = new DataGridView();
            but_find = new Button();
            text_name_cli = new TextBox();
            main_panel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_list_medi).BeginInit();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(panel2);
            main_panel.Controls.Add(pic_Back);
            main_panel.Controls.Add(lab_main);
            main_panel.Controls.Add(but_Seen);
            main_panel.Controls.Add(data_list_medi);
            main_panel.Controls.Add(but_find);
            main_panel.Controls.Add(text_name_cli);
            main_panel.Location = new Point(12, 11);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1124, 611);
            main_panel.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(but_del);
            panel2.Controls.Add(lab_expired);
            panel2.Controls.Add(tb_expired);
            panel2.Controls.Add(tb_avail);
            panel2.Controls.Add(but_Update);
            panel2.Controls.Add(tb_unit);
            panel2.Controls.Add(tb_cost);
            panel2.Controls.Add(tb_detail);
            panel2.Controls.Add(but_Add);
            panel2.Controls.Add(tb_name);
            panel2.Controls.Add(tb_id);
            panel2.Controls.Add(lab_avail);
            panel2.Controls.Add(lab_unit);
            panel2.Controls.Add(lab_detail);
            panel2.Controls.Add(lab_cost);
            panel2.Controls.Add(lab_name);
            panel2.Controls.Add(lab_id);
            panel2.Location = new Point(515, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 496);
            panel2.TabIndex = 24;
            // 
            // but_del
            // 
            but_del.BackColor = Color.FromArgb(7, 47, 128);
            but_del.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_del.ForeColor = Color.White;
            but_del.Location = new Point(438, 443);
            but_del.Name = "but_del";
            but_del.Size = new Size(125, 50);
            but_del.TabIndex = 19;
            but_del.TabStop = false;
            but_del.Text = "Xóa";
            but_del.UseVisualStyleBackColor = false;
            but_del.Click += but_del_Click;
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
            // tb_expired
            // 
            tb_expired.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_expired.Location = new Point(176, 401);
            tb_expired.Name = "tb_expired";
            tb_expired.ReadOnly = true;
            tb_expired.Size = new Size(387, 36);
            tb_expired.TabIndex = 15;
            tb_expired.TabStop = false;
            // 
            // tb_avail
            // 
            tb_avail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_avail.Location = new Point(176, 342);
            tb_avail.Name = "tb_avail";
            tb_avail.ReadOnly = true;
            tb_avail.Size = new Size(387, 36);
            tb_avail.TabIndex = 15;
            tb_avail.TabStop = false;
            // 
            // but_Update
            // 
            but_Update.BackColor = Color.FromArgb(7, 47, 128);
            but_Update.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Update.ForeColor = Color.White;
            but_Update.Location = new Point(307, 443);
            but_Update.Name = "but_Update";
            but_Update.Size = new Size(125, 50);
            but_Update.TabIndex = 6;
            but_Update.TabStop = false;
            but_Update.Text = "Cập nhật";
            but_Update.UseVisualStyleBackColor = false;
            but_Update.Click += but_Update_Click;
            // 
            // tb_unit
            // 
            tb_unit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_unit.Location = new Point(176, 286);
            tb_unit.Name = "tb_unit";
            tb_unit.ReadOnly = true;
            tb_unit.Size = new Size(387, 36);
            tb_unit.TabIndex = 15;
            tb_unit.TabStop = false;
            // 
            // tb_cost
            // 
            tb_cost.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_cost.Location = new Point(176, 236);
            tb_cost.Name = "tb_cost";
            tb_cost.ReadOnly = true;
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
            tb_detail.ReadOnly = true;
            tb_detail.Size = new Size(387, 91);
            tb_detail.TabIndex = 14;
            tb_detail.TabStop = false;
            // 
            // but_Add
            // 
            but_Add.BackColor = Color.FromArgb(7, 47, 128);
            but_Add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Add.ForeColor = Color.White;
            but_Add.Location = new Point(176, 443);
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
            tb_name.ReadOnly = true;
            tb_name.Size = new Size(387, 36);
            tb_name.TabIndex = 10;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id.Location = new Point(176, 19);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
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
            // lab_main
            // 
            lab_main.AutoSize = true;
            lab_main.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_main.ForeColor = Color.FromArgb(7, 47, 128);
            lab_main.Location = new Point(374, 2);
            lab_main.Name = "lab_main";
            lab_main.Size = new Size(301, 35);
            lab_main.TabIndex = 6;
            lab_main.Text = "Quản lý danh sách thuốc";
            // 
            // but_Seen
            // 
            but_Seen.BackColor = Color.FromArgb(7, 47, 128);
            but_Seen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Seen.ForeColor = Color.White;
            but_Seen.Location = new Point(336, 558);
            but_Seen.Name = "but_Seen";
            but_Seen.Size = new Size(173, 50);
            but_Seen.TabIndex = 4;
            but_Seen.TabStop = false;
            but_Seen.Text = "Xem tất cả";
            but_Seen.UseVisualStyleBackColor = false;
            but_Seen.Click += but_Seen_Click;
            // 
            // data_list_medi
            // 
            data_list_medi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_medi.Location = new Point(17, 113);
            data_list_medi.Name = "data_list_medi";
            data_list_medi.RowHeadersWidth = 51;
            data_list_medi.RowTemplate.Height = 29;
            data_list_medi.Size = new Size(492, 439);
            data_list_medi.TabIndex = 2;
            // 
            // but_find
            // 
            but_find.BackColor = Color.FromArgb(7, 47, 128);
            but_find.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_find.ForeColor = Color.White;
            but_find.Location = new Point(336, 57);
            but_find.Name = "but_find";
            but_find.Size = new Size(173, 50);
            but_find.TabIndex = 1;
            but_find.TabStop = false;
            but_find.Text = "Tìm kiếm";
            but_find.UseVisualStyleBackColor = false;
            but_find.Click += but_find_Click;
            // 
            // text_name_cli
            // 
            text_name_cli.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_cli.Location = new Point(17, 65);
            text_name_cli.Name = "text_name_cli";
            text_name_cli.PlaceholderText = "Nhập tên thuốc";
            text_name_cli.Size = new Size(290, 36);
            text_name_cli.TabIndex = 0;
            text_name_cli.TabStop = false;
            // 
            // MedList_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1148, 634);
            ControlBox = false;
            Controls.Add(main_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MedList_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_list_medi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private PictureBox pic_Back;
        private Button but_del;
        private Button but_Update;
        private Label lab_main;
        private Button but_Seen;
        private DataGridView data_list_medi;
        private Button but_find;
        private TextBox text_name_cli;
        private Panel panel2;
        private Label lab_expired;
        private TextBox tb_avail;
        private TextBox tb_unit;
        private TextBox tb_cost;
        private TextBox tb_detail;
        private Button but_Add;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lab_avail;
        private Label lab_unit;
        private Label lab_detail;
        private Label lab_cost;
        private Label lab_name;
        private Label lab_id;
        private TextBox tb_expired;
    }
}