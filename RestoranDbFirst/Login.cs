using DevExpress.Office.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace RestoranDbFirst
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }
        DbTuccoEntities db = new DbTuccoEntities();
        private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {



            foreach (var o in db.PERSONEL)
            {
                if (o.PERSONELADI == txtKullaniciAdi.Text && o.SIFRE == txtSifre.Text)
                {

                    SatisPaneli satisPaneli = new SatisPaneli();
                    satisPaneli.Show();
                    satisPaneli.Text += $" | Hoşgeldin {txtKullaniciAdi.Text}";

                }
                else MessageBox.Show("Hatalı Giriş !");

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtSifre.Properties.PasswordChar = '*';
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (txtSifre.Properties.PasswordChar == '*')
            {
                txtSifre.Properties.PasswordChar = '\0';  // Şifreyi göster
                Password.Text = "Gizle";  // Butonun metnini "Gizle" yap
            }
            else
            {
                txtSifre.Properties.PasswordChar = '*';  // Şifreyi gizle
                Password.Text = "Aç";  // Butonun metnini "Aç" yap
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (var o in db.PERSONEL)
            {
                if (o.PERSONELADI == txtKullaniciAdi.Text && o.SIFRE == txtSifre.Text)
                {

                    AdminPaneli adminPaneli = new AdminPaneli();
                    adminPaneli.Show();
                    adminPaneli.Text += $" | Hoşgeldin {txtKullaniciAdi.Text}"  ;

                }
                else MessageBox.Show("Hatalı Giriş !");

            }
        }
    }
}
