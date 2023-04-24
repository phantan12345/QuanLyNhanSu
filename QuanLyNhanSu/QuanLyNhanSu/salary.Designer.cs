using System;

namespace QuanLyNhanSu
{
    partial class salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salary));
            this.panel_ThongTin = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gvLuong = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gvTangLuong = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtLuongCu = new System.Windows.Forms.TextBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.txtLuongMoi = new System.Windows.Forms.TextBox();
            this.txtLiDo = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel_ThongTin.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuong)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTangLuong)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ThongTin
            // 
            this.panel_ThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_ThongTin.Controls.Add(this.tabControl2);
            this.panel_ThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ThongTin.Location = new System.Drawing.Point(0, 0);
            this.panel_ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ThongTin.Name = "panel_ThongTin";
            this.panel_ThongTin.Size = new System.Drawing.Size(857, 570);
            this.panel_ThongTin.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(724, 459);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gvLuong);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(716, 431);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Lương công ty";
            // 
            // gvLuong
            // 
            this.gvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLuong.Location = new System.Drawing.Point(3, 202);
            this.gvLuong.Name = "gvLuong";
            this.gvLuong.RowHeadersWidth = 51;
            this.gvLuong.Size = new System.Drawing.Size(713, 232);
            this.gvLuong.TabIndex = 0;
            this.gvLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvLuong_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btn);
            this.groupBox5.Controls.Add(this.txtTim);
            this.groupBox5.Location = new System.Drawing.Point(6, 142);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(710, 54);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Các chức năng";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::QuanLyNhanSu.Properties.Resources.upload;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(537, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Lương Cá Nhân";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QuanLyNhanSu.Properties.Resources.upload;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(379, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Lương Tổng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn
            // 
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Image = global::QuanLyNhanSu.Properties.Resources.exiit;
            this.btn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn.Location = new System.Drawing.Point(231, 19);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(73, 26);
            this.btn.TabIndex = 4;
            this.btn.Text = "Clear   ";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTim.FlatAppearance.BorderSize = 0;
            this.txtTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.txtTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.txtTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTim.Image = global::QuanLyNhanSu.Properties.Resources.upload;
            this.txtTim.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTim.Location = new System.Drawing.Point(82, 19);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(73, 26);
            this.txtTim.TabIndex = 0;
            this.txtTim.Text = "Tìm Kiếm";
            this.txtTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtTim.UseVisualStyleBackColor = false;
            this.txtTim.Click += new System.EventHandler(this.txtTim_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtNam);
            this.groupBox6.Controls.Add(this.txtThang);
            this.groupBox6.Controls.Add(this.txtMa);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Location = new System.Drawing.Point(7, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(709, 130);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin về lương nhân viên";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(95, 97);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(178, 21);
            this.txtNam.TabIndex = 2;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(95, 64);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(178, 21);
            this.txtThang.TabIndex = 3;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(95, 23);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(178, 21);
            this.txtMa.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Năm";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 64);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 15);
            this.label27.TabIndex = 0;
            this.label27.Text = "Tháng";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 29);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 15);
            this.label28.TabIndex = 0;
            this.label28.Text = "Mã Nhân Viên";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gvTangLuong);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(716, 431);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Vấn đề tăng lương";
            // 
            // gvTangLuong
            // 
            this.gvTangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTangLuong.Location = new System.Drawing.Point(8, 203);
            this.gvTangLuong.Name = "gvTangLuong";
            this.gvTangLuong.RowHeadersWidth = 51;
            this.gvTangLuong.Size = new System.Drawing.Size(708, 297);
            this.gvTangLuong.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnThem);
            this.groupBox7.Controls.Add(this.btnXem);
            this.groupBox7.Location = new System.Drawing.Point(8, 144);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(708, 53);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Các chức năng";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(161, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 26);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackgroundImage = global::QuanLyNhanSu.Properties.Resources._133;
            this.btnXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(360, 20);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(78, 26);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtLuongCu);
            this.groupBox8.Controls.Add(this.cbMaNV);
            this.groupBox8.Controls.Add(this.txtLuongMoi);
            this.groupBox8.Controls.Add(this.txtLiDo);
            this.groupBox8.Controls.Add(this.label30);
            this.groupBox8.Controls.Add(this.label31);
            this.groupBox8.Controls.Add(this.label34);
            this.groupBox8.Controls.Add(this.label36);
            this.groupBox8.Location = new System.Drawing.Point(8, 15);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(708, 123);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Thông tin về tăng lương nhân viên";
            // 
            // txtLuongCu
            // 
            this.txtLuongCu.Location = new System.Drawing.Point(90, 88);
            this.txtLuongCu.Name = "txtLuongCu";
            this.txtLuongCu.ReadOnly = true;
            this.txtLuongCu.Size = new System.Drawing.Size(111, 21);
            this.txtLuongCu.TabIndex = 12;
            // 
            // cbMaNV
            // 
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(92, 29);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(88, 23);
            this.cbMaNV.TabIndex = 11;
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // txtLuongMoi
            // 
            this.txtLuongMoi.Location = new System.Drawing.Point(398, 87);
            this.txtLuongMoi.Name = "txtLuongMoi";
            this.txtLuongMoi.Size = new System.Drawing.Size(112, 21);
            this.txtLuongMoi.TabIndex = 6;
            // 
            // txtLiDo
            // 
            this.txtLiDo.Location = new System.Drawing.Point(375, 32);
            this.txtLiDo.Name = "txtLiDo";
            this.txtLiDo.Size = new System.Drawing.Size(222, 21);
            this.txtLiDo.TabIndex = 10;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(325, 35);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 15);
            this.label30.TabIndex = 0;
            this.label30.Text = "Lí do";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(320, 91);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 15);
            this.label31.TabIndex = 0;
            this.label31.Text = "Lương mới";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(11, 93);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(52, 15);
            this.label34.TabIndex = 0;
            this.label34.Text = "Lương cũ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(13, 32);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(73, 15);
            this.label36.TabIndex = 0;
            this.label36.Text = "Mã nhân viên";
            // 
            // salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 570);
            this.Controls.Add(this.panel_ThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "salary";
            this.Text = "salary";
            this.Load += new System.EventHandler(this.FormLoad);
            this.panel_ThongTin.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvLuong)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTangLuong)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panel_ThongTin;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gvLuong;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button txtTim;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView gvTangLuong;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtLuongCu;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.TextBox txtLiDo;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtLuongMoi;
        private System.Windows.Forms.Label label31;
    }
}