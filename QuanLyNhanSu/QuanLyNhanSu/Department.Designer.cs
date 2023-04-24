namespace QuanLyNhanSu
{
    partial class Department
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
            this.panel_ThongTin = new System.Windows.Forms.Panel();
            this.gb_De = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_ngaythanhlap = new System.Windows.Forms.DateTimePicker();
            this.txt_maphongban = new System.Windows.Forms.TextBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_tenphongban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dg_phongban = new System.Windows.Forms.DataGridView();
            this.panel_ThongTin.SuspendLayout();
            this.gb_De.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_phongban)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ThongTin
            // 
            this.panel_ThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_ThongTin.Controls.Add(this.gb_De);
            this.panel_ThongTin.Controls.Add(this.groupBox6);
            this.panel_ThongTin.Controls.Add(this.dg_phongban);
            this.panel_ThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ThongTin.Location = new System.Drawing.Point(0, 0);
            this.panel_ThongTin.Margin = new System.Windows.Forms.Padding(5);
            this.panel_ThongTin.Name = "panel_ThongTin";
            this.panel_ThongTin.Size = new System.Drawing.Size(1168, 696);
            this.panel_ThongTin.TabIndex = 2;
            // 
            // gb_De
            // 
            this.gb_De.BackColor = System.Drawing.Color.Transparent;
            this.gb_De.Controls.Add(this.label2);
            this.gb_De.Controls.Add(this.dt_ngaythanhlap);
            this.gb_De.Controls.Add(this.txt_maphongban);
            this.gb_De.Controls.Add(this.txt_ghichu);
            this.gb_De.Controls.Add(this.txt_tenphongban);
            this.gb_De.Controls.Add(this.label3);
            this.gb_De.Controls.Add(this.label13);
            this.gb_De.Controls.Add(this.label14);
            this.gb_De.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_De.Location = new System.Drawing.Point(112, 4);
            this.gb_De.Margin = new System.Windows.Forms.Padding(4);
            this.gb_De.Name = "gb_De";
            this.gb_De.Padding = new System.Windows.Forms.Padding(4);
            this.gb_De.Size = new System.Drawing.Size(965, 140);
            this.gb_De.TabIndex = 4;
            this.gb_De.TabStop = false;
            this.gb_De.Text = "Thông tin về phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày thành lập";
            // 
            // dt_ngaythanhlap
            // 
            this.dt_ngaythanhlap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaythanhlap.Location = new System.Drawing.Point(160, 86);
            this.dt_ngaythanhlap.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaythanhlap.Name = "dt_ngaythanhlap";
            this.dt_ngaythanhlap.Size = new System.Drawing.Size(207, 25);
            this.dt_ngaythanhlap.TabIndex = 4;
            // 
            // txt_maphongban
            // 
            this.txt_maphongban.Location = new System.Drawing.Point(160, 39);
            this.txt_maphongban.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maphongban.Name = "txt_maphongban";
            this.txt_maphongban.Size = new System.Drawing.Size(207, 25);
            this.txt_maphongban.TabIndex = 3;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(532, 82);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(207, 36);
            this.txt_ghichu.TabIndex = 1;
            // 
            // txt_tenphongban
            // 
            this.txt_tenphongban.Location = new System.Drawing.Point(532, 39);
            this.txt_tenphongban.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenphongban.Name = "txt_tenphongban";
            this.txt_tenphongban.Size = new System.Drawing.Size(207, 25);
            this.txt_tenphongban.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ghi chú";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(407, 43);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên phòng ban";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã phòng ban";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btn_new);
            this.groupBox6.Controls.Add(this.btn_delete);
            this.groupBox6.Controls.Add(this.btn_add);
            this.groupBox6.Controls.Add(this.btn_update);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(112, 161);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(965, 69);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "các chức năng";
            // 
            // btn_new
            // 
            this.btn_new.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.xanh;
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Image = global::QuanLyNhanSu.Properties.Resources.upload;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_new.Location = new System.Drawing.Point(129, 18);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(112, 43);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "Mới   ";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.xanh;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::QuanLyNhanSu.Properties.Resources.exiit;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_delete.Location = new System.Drawing.Point(556, 18);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 43);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa   ";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.xanh;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = global::QuanLyNhanSu.Properties.Resources.upload;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(265, 18);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 43);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm ";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button15_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.xanh;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Image = global::QuanLyNhanSu.Properties.Resources.edit_user;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(411, 18);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 43);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Sửa   ";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dg_phongban
            // 
            this.dg_phongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_phongban.Location = new System.Drawing.Point(112, 238);
            this.dg_phongban.Margin = new System.Windows.Forms.Padding(4);
            this.dg_phongban.Name = "dg_phongban";
            this.dg_phongban.RowHeadersWidth = 51;
            this.dg_phongban.Size = new System.Drawing.Size(965, 334);
            this.dg_phongban.TabIndex = 2;
            this.dg_phongban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_phongban_CellClick);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 696);
            this.Controls.Add(this.panel_ThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.panel_ThongTin.ResumeLayout(false);
            this.gb_De.ResumeLayout(false);
            this.gb_De.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_phongban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_ThongTin;
        private System.Windows.Forms.GroupBox gb_De;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_ngaythanhlap;
        private System.Windows.Forms.TextBox txt_maphongban;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_tenphongban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dg_phongban;
    }
}