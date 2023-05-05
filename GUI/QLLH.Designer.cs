namespace GUI
{
    partial class QLLH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbphong = new System.Windows.Forms.ComboBox();
            this.txtthoihan = new System.Windows.Forms.Label();
            this.txtngaybd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmalh = new System.Windows.Forms.TextBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbten = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvlh = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cbphong);
            this.panel1.Controls.Add(this.txtthoihan);
            this.panel1.Controls.Add(this.txtngaybd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.txtmalh);
            this.panel1.Controls.Add(this.btnhuy);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Location = new System.Drawing.Point(609, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 460);
            this.panel1.TabIndex = 18;
            // 
            // cbphong
            // 
            this.cbphong.FormattingEnabled = true;
            this.cbphong.Items.AddRange(new object[] {
            "Dãy 1, Phòng A01",
            "Dãy 1, Phòng A02",
            "Dãy 1, Phòng A03",
            "Dãy 1, Phòng A04",
            "Dãy 1, Phòng A05",
            "Dãy 1, Phòng A06",
            "Dãy 2, Phòng B01",
            "Dãy 2, Phòng B02",
            "Dãy 2, Phòng B03",
            "Dãy 2, Phòng B04",
            "Dãy 2, Phòng B05",
            "Dãy 2, Phòng B06"});
            this.cbphong.Location = new System.Drawing.Point(171, 179);
            this.cbphong.Name = "cbphong";
            this.cbphong.Size = new System.Drawing.Size(250, 24);
            this.cbphong.TabIndex = 69;
            // 
            // txtthoihan
            // 
            this.txtthoihan.AutoSize = true;
            this.txtthoihan.ForeColor = System.Drawing.Color.Black;
            this.txtthoihan.Location = new System.Drawing.Point(47, 227);
            this.txtthoihan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtthoihan.Name = "txtthoihan";
            this.txtthoihan.Size = new System.Drawing.Size(88, 16);
            this.txtthoihan.TabIndex = 68;
            this.txtthoihan.Text = "Ngày bắt đầu";
            // 
            // txtngaybd
            // 
            this.txtngaybd.Location = new System.Drawing.Point(172, 221);
            this.txtngaybd.Margin = new System.Windows.Forms.Padding(4);
            this.txtngaybd.Name = "txtngaybd";
            this.txtngaybd.Size = new System.Drawing.Size(249, 22);
            this.txtngaybd.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(47, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Tên phòng học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(42, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Tên Lớp Học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Mã Lớp Học";
            // 
            // txtten
            // 
            this.txtten.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtten.Location = new System.Drawing.Point(171, 122);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Multiline = true;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(250, 34);
            this.txtten.TabIndex = 43;
            this.txtten.Tag = "";
            // 
            // txtmalh
            // 
            this.txtmalh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmalh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtmalh.Location = new System.Drawing.Point(171, 68);
            this.txtmalh.Margin = new System.Windows.Forms.Padding(4);
            this.txtmalh.Multiline = true;
            this.txtmalh.Name = "txtmalh";
            this.txtmalh.Size = new System.Drawing.Size(249, 34);
            this.txtmalh.TabIndex = 41;
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Red;
            this.btnhuy.Location = new System.Drawing.Point(403, 297);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 33);
            this.btnhuy.TabIndex = 35;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(298, 297);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 33);
            this.btnxoa.TabIndex = 37;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbten);
            this.groupBox3.Controls.Add(this.btntimkiem);
            this.groupBox3.Location = new System.Drawing.Point(59, 386);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(382, 58);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo tên lớp học";
            // 
            // cbten
            // 
            this.cbten.FormattingEnabled = true;
            this.cbten.Location = new System.Drawing.Point(5, 25);
            this.cbten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(284, 24);
            this.cbten.TabIndex = 6;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btntimkiem.Location = new System.Drawing.Point(295, 21);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 33);
            this.btntimkiem.TabIndex = 4;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnsua.Location = new System.Drawing.Point(188, 297);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 33);
            this.btnsua.TabIndex = 38;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnthem.Location = new System.Drawing.Point(86, 297);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 33);
            this.btnthem.TabIndex = 39;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvlh);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(608, 482);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học";
            // 
            // dgvlh
            // 
            this.dgvlh.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvlh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlh.Location = new System.Drawing.Point(7, 22);
            this.dgvlh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvlh.Name = "dgvlh";
            this.dgvlh.RowHeadersWidth = 51;
            this.dgvlh.RowTemplate.Height = 24;
            this.dgvlh.Size = new System.Drawing.Size(594, 460);
            this.dgvlh.TabIndex = 5;
            this.dgvlh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlh_CellContentClick);
            // 
            // QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "QLLH";
            this.Size = new System.Drawing.Size(1174, 508);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtthoihan;
        private System.Windows.Forms.DateTimePicker txtngaybd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtmalh;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbten;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvlh;
        private System.Windows.Forms.ComboBox cbphong;
    }
}
