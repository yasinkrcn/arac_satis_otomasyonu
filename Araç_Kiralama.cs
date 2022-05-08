using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Satış_Otomasyonu
{
    internal class Araç_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-30LE6PI;Initial Catalog=Araç_Kiralama;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut,string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu,baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void Bos_Araçlar(ComboBox combo,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);    
            SqlDataReader read = komut.ExecuteReader(); 
            while(read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }

            baglanti.Close();
        }


        //--------------------------------------------------------


        public void TC_Ara(TextBox tc,TextBox adsoyad, TextBox telefon, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }

            baglanti.Close();
        }



        public void Ucret_Hesapla(ComboBox comboKiraSekli , TextBox ucret ,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if(comboKiraSekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["kiraucreti"].ToString())*1).ToString();
                if(comboKiraSekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) *0.75).ToString();
                if(comboKiraSekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) *0.60).ToString();
                
               
            }

            baglanti.Close();
        }




        public void CombodanGetir(ComboBox araclar, TextBox marka, TextBox seri, TextBox yil, TextBox renk, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();
                
            }

            baglanti.Close();
        }
    }
}
