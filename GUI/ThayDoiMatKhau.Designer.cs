namespace GUI
{
    partial class ThayDoiMatKhau
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
            this.matkhau = new System.Windows.Forms.GroupBox();
            this.lbnote = new System.Windows.Forms.Label();
            this.btndoimk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmk2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmk1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.matkhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // matkhau
            // 
            this.matkhau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.matkhau.Controls.Add(this.pictureBox1);
            this.matkhau.Controls.Add(this.lbnote);
            this.matkhau.Controls.Add(this.btndoimk);
            this.matkhau.Controls.Add(this.label5);
            this.matkhau.Controls.Add(this.txtmk2);
            this.matkhau.Controls.Add(this.label4);
            this.matkhau.Controls.Add(this.txtmk1);
            this.matkhau.Location = new System.Drawing.Point(0, 3);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(618, 271);
            this.matkhau.TabIndex = 11;
            this.matkhau.TabStop = false;
            this.matkhau.Text = "Mật khẩu mới";
            // 
            // lbnote
            // 
            this.lbnote.AutoSize = true;
            this.lbnote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbnote.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbnote.Location = new System.Drawing.Point(233, 97);
            this.lbnote.Name = "lbnote";
            this.lbnote.Size = new System.Drawing.Size(86, 22);
            this.lbnote.TabIndex = 16;
            this.lbnote.Text = "labelnote";
            // 
            // btndoimk
            // 
            this.btndoimk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndoimk.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndoimk.Location = new System.Drawing.Point(312, 203);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(90, 44);
            this.btndoimk.TabIndex = 10;
            this.btndoimk.Text = "Lưu thay đổi";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(42, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // txtmk2
            // 
            this.txtmk2.Location = new System.Drawing.Point(237, 129);
            this.txtmk2.Multiline = true;
            this.txtmk2.Name = "txtmk2";
            this.txtmk2.PasswordChar = '*';
            this.txtmk2.Size = new System.Drawing.Size(270, 34);
            this.txtmk2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(42, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // txtmk1
            // 
            this.txtmk1.Location = new System.Drawing.Point(237, 60);
            this.txtmk1.Multiline = true;
            this.txtmk1.Name = "txtmk1";
            this.txtmk1.PasswordChar = '*';
            this.txtmk1.Size = new System.Drawing.Size(270, 34);
            this.txtmk1.TabIndex = 6;
            this.txtmk1.Leave += new System.EventHandler(this.txtmk1_leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._return;
            this.pictureBox1.Location = new System.Drawing.Point(33, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ThayDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 275);
            this.Controls.Add(this.matkhau);
            this.Name = "ThayDoiMatKhau";
            this.Text = "ThayDoiMatKhau";
            this.matkhau.ResumeLayout(false);
            this.matkhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox matkhau;
        private System.Windows.Forms.Label lbnote;
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmk2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmk1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}