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
            arac.TC_Ara(txtTcAra,txtTC, txtAdSoyad, txtTelNo, sorgu2);
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
            comboAraclar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Eklendi");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text="";
            string sorgu2 = "select *from müşteri where tc like '" + txtTcAra.Text + "'";
            arac.TC_Ara(txtTcAra,txtTC,txtAdSoyad,txtTelNo,sorgu2);

        }

        private void btnSozlesmeGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update sözleşme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,e_tarih=@e_tarih,e_yer=@e_yer,marka=@marka,seri=@seri,yil=@yil,renk=@renk,kirasekli=@kirasekli,kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,ctarih=@ctarih,dtarih=@dtarih where plaka=@plaka";
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

            
            comboAraclar.Items.Clear();
            Bos_Araclar();
            Yenile();


            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text="";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text="";
            comboAraclar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Eklendi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTC.Text = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelNo.Text = satır.Cells[2].Value.ToString();
            txtEhliyetNo.Text = satır.Cells[3].Value.ToString();
            txtEhliyetTarihi.Text = satır.Cells[4].Value.ToString();
            txtEhliyetVerildigiYer.Text = satır.Cells[5].Value.ToString();
            comboAraclar.Text = satır.Cells[6].Value.ToString();
            txtMarka.Text = satır.Cells[7].Value.ToString();
            txtSeri.Text = satır.Cells[8].Value.ToString();
            txtModelYil.Text = satır.Cells[9].Value.ToString();
            txtRenk.Text = satır.Cells[10].Value.ToString();
            comboKiraSekli.Text = satır.Cells[11].Value.ToString();
            txtKiraUcreti.Text = satır.Cells[12].Value.ToString();
            txtGun.Text = satır.Cells[13].Value.ToString();
            txtTutar.Text = satır.Cells[14].Value.ToString();
            dateCikis.Text = satır.Cells[15].Value.ToString();
            dateDonus.Text = satır.Cells[16].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;

            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(satır.Cells["dtarih"].Value.ToString());
            int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunFarkı = bugun - donus;
            int _gunFarkı = gunFarkı.Days;
            int ucretFarkı;
            ucretFarkı = _gunFarkı * ucret;
            txtEkstra.Text = ucretFarkı.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtEkstra.Text)>=0 || int.Parse(txtEkstra.Text)<0)
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satır.Cells["tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(satır.Cells["ctarih"].Value.ToString());

                TimeSpan gun = bugun - cikis;
                int _gun = gun.Days;
                int toplamTutar = _gun * ucret;
                string sorgu1 = "delete from sözleşme where plaka='"+satır.Cells["plaka"].Value.ToString+"'";
                SqlCommand komut = new SqlCommand();
                arac.ekle_sil_güncelle(komut, sorgu1);
                string sorgu2 = "update araç set durumu='BOŞ' where plaka='"+satır.Cells["plaka"].Value.ToString+"'";
                SqlCommand komut3 = new SqlCommand();
                arac.ekle_sil_güncelle(komut3, sorgu2);


                string sorgu3 = "insert into satış(tc,adsoyad,plaka,marka,seri,yil,renk,gun,tutar,tarih1,tarih2,fiyat) values(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@tutar,@tarih1,@tarih2,@fiyat)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc", satır.Cells["tc"].Value.ToString());
                komut2.Parameters.AddWithValue("@adsoyad", satır.Cells["adsoyad"].Value.ToString());
                komut2.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@marka", satır.Cells["marka"].Value.ToString());
                komut2.Parameters.AddWithValue("@seri", satır.Cells["seri"].Value.ToString());
                komut2.Parameters.AddWithValue("@yil", satır.Cells["yil"].Value.ToString());
                komut2.Parameters.AddWithValue("@renk", satır.Cells["renk"].Value.ToString());
                komut2.Parameters.AddWithValue("@gun", _gun);
                komut2.Parameters.AddWithValue("@tutar", toplamTutar);
                komut2.Parameters.AddWithValue("@tarih1", satır.Cells["ctarih"].Value.ToString());
                komut2.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());
                komut2.Parameters.AddWithValue("@fiyat", ucret);

                arac.ekle_sil_güncelle(komut2, sorgu3);

                MessageBox.Show("Araç Teslim Edilidi");
                comboAraclar.Text = "";
                comboAraclar.Items.Clear();
                Bos_Araclar();
                Yenile();


                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text="";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text="";
                comboAraclar.Text = "";
                Temizle();


                txtEkstra.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız","Uyarı");
            }
        }
    }
}
