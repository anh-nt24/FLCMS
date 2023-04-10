namespace FLCMS
{
    partial class Hocvien_KiThi
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmakt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmahv = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnco = new System.Windows.Forms.RadioButton();
            this.btnkhong = new System.Windows.Forms.RadioButton();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mahocvien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.makithi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaythi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ketquathi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diemdanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenhocvien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenkithi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnhuy);
            this.groupBox4.Controls.Add(this.btnluu);
            this.groupBox4.Controls.Add(this.btnxoa);
            this.groupBox4.Controls.Add(this.btnsua);
            this.groupBox4.Controls.Add(this.btnthem);
            this.groupBox4.Location = new System.Drawing.Point(321, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(586, 58);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Công cụ";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(490, 19);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(74, 33);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(376, 19);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(74, 33);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(255, 19);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(74, 33);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(140, 19);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(74, 33);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(26, 20);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(74, 33);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv);
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 254);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thông tin";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mahocvien,
            this.tenhocvien,
            this.makithi,
            this.tenkithi,
            this.ngaythi,
            this.ketquathi,
            this.diemdanh});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(6, 27);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(883, 221);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkhong);
            this.groupBox1.Controls.Add(this.btnco);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtmahv);
            this.groupBox1.Controls.Add(this.txtmakt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtkq);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 198);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học viên- kì thi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtmakt
            // 
            this.txtmakt.FormattingEnabled = true;
            this.txtmakt.Location = new System.Drawing.Point(564, 30);
            this.txtmakt.Name = "txtmakt";
            this.txtmakt.Size = new System.Drawing.Size(249, 24);
            this.txtmakt.TabIndex = 22;
            this.txtmakt.SelectedIndexChanged += new System.EventHandler(this.txtmacn_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(113, 88);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(249, 22);
            this.txtkq.TabIndex = 17;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(113, 144);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(249, 22);
            this.txtdate.TabIndex = 16;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(471, 33);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 16);
            this.label.TabIndex = 11;
            this.label.Text = "Mã kì thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điểm danh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kết quả thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã học viên";
            // 
            // txtmahv
            // 
            this.txtmahv.FormattingEnabled = true;
            this.txtmahv.Location = new System.Drawing.Point(113, 30);
            this.txtmahv.Name = "txtmahv";
            this.txtmahv.Size = new System.Drawing.Size(249, 24);
            this.txtmahv.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 28);
            this.button2.TabIndex = 24;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnco
            // 
            this.btnco.AutoSize = true;
            this.btnco.Location = new System.Drawing.Point(596, 92);
            this.btnco.Name = "btnco";
            this.btnco.Size = new System.Drawing.Size(45, 20);
            this.btnco.TabIndex = 25;
            this.btnco.TabStop = true;
            this.btnco.Text = "Có";
            this.btnco.UseVisualStyleBackColor = true;
            // 
            // btnkhong
            // 
            this.btnkhong.AutoSize = true;
            this.btnkhong.Location = new System.Drawing.Point(685, 92);
            this.btnkhong.Name = "btnkhong";
            this.btnkhong.Size = new System.Drawing.Size(66, 20);
            this.btnkhong.TabIndex = 26;
            this.btnkhong.TabStop = true;
            this.btnkhong.Text = "Không";
            this.btnkhong.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(223, 20);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(74, 33);
            this.btntimkiem.TabIndex = 4;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.FormattingEnabled = true;
            this.txttimkiem.Location = new System.Drawing.Point(6, 25);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(211, 24);
            this.txttimkiem.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Controls.Add(this.btntimkiem);
            this.groupBox3.Location = new System.Drawing.Point(12, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 58);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo mã kì thi";
            // 
            // makithi
            // 
            this.makithi.DisplayIndex = 1;
            // 
            // ngaythi
            // 
            this.ngaythi.DisplayIndex = 2;
            // 
            // ketquathi
            // 
            this.ketquathi.DisplayIndex = 3;
            // 
            // diemdanh
            // 
            this.diemdanh.DisplayIndex = 4;
            // 
            // tenhocvien
            // 
            this.tenhocvien.DisplayIndex = 5;
            // 
            // tenkithi
            // 
            this.tenkithi.DisplayIndex = 6;
            // 
            // Hocvien_KiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 528);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hocvien_KiThi";
            this.Text = "Hocvien_KiThi";
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtmakt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txtmahv;
        private System.Windows.Forms.ColumnHeader mahocvien;
        private System.Windows.Forms.ColumnHeader tenhocvien;
        private System.Windows.Forms.ColumnHeader makithi;
        private System.Windows.Forms.ColumnHeader tenkithi;
        private System.Windows.Forms.ColumnHeader ngaythi;
        private System.Windows.Forms.ColumnHeader ketquathi;
        private System.Windows.Forms.ColumnHeader diemdanh;
        private System.Windows.Forms.RadioButton btnkhong;
        private System.Windows.Forms.RadioButton btnco;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.ComboBox txttimkiem;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}