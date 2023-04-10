namespace FLCMS
{
    partial class QuanLiChungNhan
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcombobox = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnhuy);
            this.groupBox4.Controls.Add(this.btnluu);
            this.groupBox4.Controls.Add(this.btnxoa);
            this.groupBox4.Controls.Add(this.btnsua);
            this.groupBox4.Controls.Add(this.btnthem);
            this.groupBox4.Location = new System.Drawing.Point(321, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(586, 58);
            this.groupBox4.TabIndex = 11;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtcombobox);
            this.groupBox3.Controls.Add(this.btntimkiem);
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 58);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo tên chứng nhận";
            // 
            // txtcombobox
            // 
            this.txtcombobox.FormattingEnabled = true;
            this.txtcombobox.Location = new System.Drawing.Point(6, 25);
            this.txtcombobox.Name = "txtcombobox";
            this.txtcombobox.Size = new System.Drawing.Size(211, 24);
            this.txtcombobox.TabIndex = 6;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 254);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các loại chứng nhận";
            // 
            // dgv
            // 
            this.dgv.HideSelection = false;
            this.dgv.Location = new System.Drawing.Point(6, 27);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(883, 221);
            this.dgv.TabIndex = 0;
            this.dgv.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtxeploai);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 198);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chứng nhận";
            // 
            // txtxeploai
            // 
            this.txtxeploai.Location = new System.Drawing.Point(574, 110);
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(249, 22);
            this.txtxeploai.TabIndex = 19;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(163, 110);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(249, 22);
            this.txtten.TabIndex = 17;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(574, 58);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(249, 22);
            this.txtdate.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Xếp loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên chứng nhận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã chứng nhận";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(163, 58);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(249, 22);
            this.txtid.TabIndex = 5;
            // 
            // QuanLiChungNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 547);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLiChungNhan";
            this.Text = "QuanLiChungNhan";
            this.Load += new System.EventHandler(this.ChungNhan_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txtcombobox;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
    }
}