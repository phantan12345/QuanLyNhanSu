namespace GUI
{
    partial class TtcnUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.GroupBox();
            this.lb_cv = new System.Windows.Forms.Label();
            this.lb_hopdong = new System.Windows.Forms.Label();
            this.lb_pb = new System.Windows.Forms.Label();
            this.pb_imgnv = new System.Windows.Forms.PictureBox();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.lb_cccd = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.btn_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgnv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_email);
            this.groupBox1.Controls.Add(this.lb_user);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Location = new System.Drawing.Point(43, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1075, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(27, 126);
            this.lb_email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(44, 16);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "Email:";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(25, 42);
            this.lb_user.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(70, 16);
            this.lb_user.TabIndex = 1;
            this.lb_user.Text = "Tài khoản:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(25, 80);
            this.lb_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(49, 16);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Họ tên:";
            // 
            // btn_exit
            // 
            this.btn_exit.Controls.Add(this.lb_cv);
            this.btn_exit.Controls.Add(this.lb_hopdong);
            this.btn_exit.Controls.Add(this.lb_pb);
            this.btn_exit.Controls.Add(this.pb_imgnv);
            this.btn_exit.Controls.Add(this.lb_ngaysinh);
            this.btn_exit.Controls.Add(this.lb_manv);
            this.btn_exit.Controls.Add(this.lb_cccd);
            this.btn_exit.Controls.Add(this.lb_sdt);
            this.btn_exit.Location = new System.Drawing.Point(43, 226);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(5);
            this.btn_exit.Size = new System.Drawing.Size(1075, 366);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.TabStop = false;
            this.btn_exit.Text = "Thông tin nhân sự";
            this.btn_exit.Enter += new System.EventHandler(this.btn_exit_Enter);
            // 
            // lb_cv
            // 
            this.lb_cv.AutoSize = true;
            this.lb_cv.Location = new System.Drawing.Point(718, 137);
            this.lb_cv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_cv.Name = "lb_cv";
            this.lb_cv.Size = new System.Drawing.Size(57, 16);
            this.lb_cv.TabIndex = 8;
            this.lb_cv.Text = "Chức vụ:";
            // 
            // lb_hopdong
            // 
            this.lb_hopdong.AutoSize = true;
            this.lb_hopdong.Location = new System.Drawing.Point(718, 189);
            this.lb_hopdong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_hopdong.Name = "lb_hopdong";
            this.lb_hopdong.Size = new System.Drawing.Size(70, 16);
            this.lb_hopdong.TabIndex = 7;
            this.lb_hopdong.Text = "Hợp đồng:";
            // 
            // lb_pb
            // 
            this.lb_pb.AutoSize = true;
            this.lb_pb.Location = new System.Drawing.Point(718, 90);
            this.lb_pb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_pb.Name = "lb_pb";
            this.lb_pb.Size = new System.Drawing.Size(75, 16);
            this.lb_pb.TabIndex = 6;
            this.lb_pb.Text = "Phòng ban:";
            this.lb_pb.Click += new System.EventHandler(this.lb_pb_Click);
            // 
            // pb_imgnv
            // 
            this.pb_imgnv.Location = new System.Drawing.Point(28, 70);
            this.pb_imgnv.Margin = new System.Windows.Forms.Padding(5);
            this.pb_imgnv.Name = "pb_imgnv";
            this.pb_imgnv.Size = new System.Drawing.Size(250, 245);
            this.pb_imgnv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imgnv.TabIndex = 5;
            this.pb_imgnv.TabStop = false;
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Location = new System.Drawing.Point(333, 137);
            this.lb_ngaysinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(70, 16);
            this.lb_ngaysinh.TabIndex = 2;
            this.lb_ngaysinh.Text = "Ngày sinh:";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Location = new System.Drawing.Point(333, 90);
            this.lb_manv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(51, 16);
            this.lb_manv.TabIndex = 1;
            this.lb_manv.Text = "Mã NV:";
            // 
            // lb_cccd
            // 
            this.lb_cccd.AutoSize = true;
            this.lb_cccd.Location = new System.Drawing.Point(333, 189);
            this.lb_cccd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_cccd.Name = "lb_cccd";
            this.lb_cccd.Size = new System.Drawing.Size(47, 16);
            this.lb_cccd.TabIndex = 4;
            this.lb_cccd.Text = "CCCD:";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(333, 246);
            this.lb_sdt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(37, 16);
            this.lb_sdt.TabIndex = 0;
            this.lb_sdt.Text = "SĐT:";
            // 
            // TtcnUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 657);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Name = "TtcnUser";
            this.Text = "TTCN";
            this.Load += new System.EventHandler(this.TTCN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btn_exit.ResumeLayout(false);
            this.btn_exit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgnv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.GroupBox btn_exit;
        private System.Windows.Forms.Label lb_cv;
        private System.Windows.Forms.Label lb_hopdong;
        private System.Windows.Forms.Label lb_pb;
        private System.Windows.Forms.PictureBox pb_imgnv;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Label lb_cccd;
        private System.Windows.Forms.Label lb_sdt;
    }
}