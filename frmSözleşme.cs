using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Satış_Otomasyonu
{
    public partial class frmSözleşme : Form
    {
        public frmSözleşme()
        {
            InitializeComponent();
        }
        Araç_Kiralama arac = new Araç_Kiralama();
        private void frmSözleşme_Load(object sender, EventArgs e)
        {
            Bos_Araclar();

            Yenile();

        }

        private void Bos_Araclar()
        {
            string sorgu2 = "select *from araç where durumu='BOŞ'";
            arac.Bos_Araçlar(comboAraclar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select *from sözleşme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text="";
            string sorgu2 = "select *from müşteri where tc like '"+txtTC.Text+"'";
            arac.TC_Ara(txtTC, txtAdSoyad, txtTelNo, sorgu2);
        }

        private void comboAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from araç where plaka like '"+comboAraclar.SelectedItem+"'";
            arac.CombodanGetir(comboAraclar,txtMarka,txtSeri,txtModelYil,txtRenk,sorgu2);
        }

        private void txtSeri_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from araç where plaka like '"+comboAraclar.SelectedItem+"'";
            arac.Ucret_Hesapla(comboKiraSekli, txtKiraUcreti, sorgu2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateDonus.Text) - DateTime.Parse(dateCikis.Text);
            int gun2 = gun.Days;  
            txtGun.Text = gun2.ToString();  
            txtTutar.Text = (gun2*int.Parse(txtKiraUcreti.Text)).ToString();    
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            dateCikis.Text = DateTime.Now.ToShortDateString();
            dateDonus.Text = DateTime.Now.ToShortDateString();
            comboKiraSekli.Text = "";
            txtKiraUcreti.Text = "";
            txtGun.Text = "";
            txtTutar.Text = "";
        }

        private void btnSozlesmeEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sözleşme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,ctarih,dtarih) values(@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelNo.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtEhliyetTarihi.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtEhliyetVerildigiYer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraclar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtModelYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", comboKiraSekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraUcreti.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateCikis.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDonus.Text);
            arac.ekle_sil_güncelle(komut2, sorgu2);

            string sorgu3 = "update araç set durumu='DOLU' where plaka='"+comboAraclar.Text+"'";
            SqlCommand komut3 = new SqlCommand();
            arac.ekle_sil_güncelle(komut3,sorgu3);
            comboAraclar.Items.Clear();
            Bos_Araclar();
            Yenile();


            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text="";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text="";
            Temizle();

        }
    }
}
