namespace RestoranDbFirst
{
    partial class Login
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Password = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(52, 137);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(113, 33);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Satış Paneli";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kullanıcı Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(65, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Şifre";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(100, 186);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(113, 16);
            this.hyperlinkLabelControl1.TabIndex = 7;
            this.hyperlinkLabelControl1.Text = "Şifreni mi Unuttun ?";
            // 
            // hyperlinkLabelControl2
            // 
            this.hyperlinkLabelControl2.Location = new System.Drawing.Point(78, 208);
            this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
            this.hyperlinkLabelControl2.Size = new System.Drawing.Size(154, 16);
            this.hyperlinkLabelControl2.TabIndex = 8;
            this.hyperlinkLabelControl2.Text = "Hesabın yoksa kayıt oluştur";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(163, 137);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(115, 33);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Admin Paneli";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(249, 110);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(43, 21);
            this.Password.TabIndex = 10;
            this.Password.Text = "Aç";
            this.Password.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(100, 109);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(143, 22);
            this.txtSifre.TabIndex = 4;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(100, 68);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(143, 22);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 308);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.hyperlinkLabelControl2);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::RestoranDbFirst.Properties.Resources.user;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.SimpleButton Password;
    }
}

