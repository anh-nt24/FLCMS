namespace GUI
{
    partial class QuenMatKhau
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
            this.captcha = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btngui = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcaptcha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbcaptcha = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.GroupBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.btnxn = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.matkhau = new System.Windows.Forms.GroupBox();
            this.lbnote = new System.Windows.Forms.Label();
            this.btndoimk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmk2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmk1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.captcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.email.SuspendLayout();
            this.matkhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.captcha);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.matkhau);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thay đổi mật khẩu";
            // 
            // captcha
            // 
            this.captcha.Controls.Add(this.label6);
            this.captcha.Controls.Add(this.btngui);
            this.captcha.Controls.Add(this.label3);
            this.captcha.Controls.Add(this.txtcaptcha);
            this.captcha.Controls.Add(this.pictureBox1);
            this.captcha.Controls.Add(this.lbcaptcha);
            this.captcha.Location = new System.Drawing.Point(65, 155);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(611, 141);
            this.captcha.TabIndex = 13;
            this.captcha.TabStop = false;
            this.captcha.Text = "Captcha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(132, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Captcha";
            // 
            // btngui
            // 
            this.btngui.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btngui.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btngui.Location = new System.Drawing.Point(516, 86);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(64, 47);
            this.btngui.TabIndex = 14;
            this.btngui.Text = "Gửi";
            this.btngui.UseVisualStyleBackColor = true;
            this.btngui.Click += new System.EventHandler(this.btndn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhập Captcha để tiếp tục";
            // 
            // txtcaptcha
            // 
            this.txtcaptcha.Location = new System.Drawing.Point(224, 93);
            this.txtcaptcha.Multiline = true;
            this.txtcaptcha.Name = "txtcaptcha";
            this.txtcaptcha.Size = new System.Drawing.Size(270, 34);
            this.txtcaptcha.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.captcha;
            this.pictureBox1.Location = new System.Drawing.Point(516, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbcaptcha
            // 
            this.lbcaptcha.AutoSize = true;
            this.lbcaptcha.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbcaptcha.Location = new System.Drawing.Point(301, 31);
            this.lbcaptcha.Name = "lbcaptcha";
            this.lbcaptcha.Size = new System.Drawing.Size(56, 32);
            this.lbcaptcha.TabIndex = 6;
            this.lbcaptcha.Text = "___";
            // 
            // email
            // 
            this.email.Controls.Add(this.lbemail);
            this.email.Controls.Add(this.btnxn);
            this.email.Controls.Add(this.txtemail);
            this.email.Controls.Add(this.label1);
            this.email.Location = new System.Drawing.Point(65, 21);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(611, 128);
            this.email.TabIndex = 12;
            this.email.TabStop = false;
            this.email.Text = "Email";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbemail.Location = new System.Drawing.Point(220, 92);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(61, 22);
            this.lbemail.TabIndex = 13;
            this.lbemail.Text = "label2";
            // 
            // btnxn
            // 
            this.btnxn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnxn.Location = new System.Drawing.Point(516, 33);
            this.btnxn.Name = "btnxn";
            this.btnxn.Size = new System.Drawing.Size(64, 49);
            this.btnxn.TabIndex = 12;
            this.btnxn.Text = "Xác nhận";
            this.btnxn.UseVisualStyleBackColor = true;
            this.btnxn.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(224, 46);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(270, 34);
            this.txtemail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(77, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập Email";
            // 
            // matkhau
            // 
            this.matkhau.Controls.Add(this.lbnote);
            this.matkhau.Controls.Add(this.btndoimk);
            this.matkhau.Controls.Add(this.label5);
            this.matkhau.Controls.Add(this.txtmk2);
            this.matkhau.Controls.Add(this.label4);
            this.matkhau.Controls.Add(this.txtmk1);
            this.matkhau.Location = new System.Drawing.Point(65, 302);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(611, 251);
            this.matkhau.TabIndex = 10;
            this.matkhau.TabStop = false;
            this.matkhau.Text = "Mật khẩu mới";
            // 
            // lbnote
            // 
            this.lbnote.AutoSize = true;
            this.lbnote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbnote.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbnote.Location = new System.Drawing.Point(220, 77);
            this.lbnote.Name = "lbnote";
            this.lbnote.Size = new System.Drawing.Size(86, 22);
            this.lbnote.TabIndex = 16;
            this.lbnote.Text = "labelnote";
            // 
            // btndoimk
            // 
            this.btndoimk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndoimk.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndoimk.Location = new System.Drawing.Point(307, 190);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(90, 44);
            this.btndoimk.TabIndex = 10;
            this.btndoimk.Text = "Thay đổi mật khẩu";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(29, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // txtmk2
            // 
            this.txtmk2.Location = new System.Drawing.Point(224, 109);
            this.txtmk2.Multiline = true;
            this.txtmk2.Name = "txtmk2";
            this.txtmk2.Size = new System.Drawing.Size(270, 34);
            this.txtmk2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(29, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // txtmk1
            // 
            this.txtmk1.Location = new System.Drawing.Point(224, 40);
            this.txtmk1.Multiline = true;
            this.txtmk1.Name = "txtmk1";
            this.txtmk1.Size = new System.Drawing.Size(270, 34);
            this.txtmk1.TabIndex = 6;
            this.txtmk1.Leave += new System.EventHandler(this.txtmk1_leave);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 566);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuenMatKhau";
            this.Text = "GUI_QuenMatKhau";
            this.groupBox1.ResumeLayout(false);
            this.captcha.ResumeLayout(false);
            this.captcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.email.ResumeLayout(false);
            this.email.PerformLayout();
            this.matkhau.ResumeLayout(false);
            this.matkhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbcaptcha;
        private System.Windows.Forms.GroupBox matkhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmk2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmk1;
        private System.Windows.Forms.GroupBox email;
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.GroupBox captcha;
        private System.Windows.Forms.Button btngui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcaptcha;
        private System.Windows.Forms.Button btnxn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbnote;
        private System.Windows.Forms.Label lbemail;
    }
}