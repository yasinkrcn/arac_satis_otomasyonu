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
    public partial class frmAraçListele : Form
    {
        Araç_Kiralama arackiralama = new Araç_Kiralama();
        public frmAraçListele()
        {
            InitializeComponent();
        }

        private void frmAraçListele_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
            
                comboAraçlar.SelectedIndex = 0; 
            

        }

        private void YenileAraçlarListesi()
        {
            string cümle = "select *from araç";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource =  arackiralama.listele(adtr2, cümle);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            Plakatxt.Text = satır.Cells["plaka"].Value.ToString();
            Markacombo.Text = satır.Cells["marka"].Value.ToString();
            Sericombo.Text = satır.Cells["seri"].Value.ToString();
            Modelyiltxt.Text = satır.Cells["yil"].Value.ToString();
            Renktxt.Text = satır.Cells["renk"].Value.ToString();
            Kmtxt.Text = satır.Cells["km"].Value.ToString();
            Yakitcombo.Text = satır.Cells["yakit"].Value.ToString();
            Ucrettxt.Text = satır.Cells["kiraucreti"].Value.ToString();
            pictureBox2.ImageLocation = satır.Cells["resim"].Value.ToString();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnResimSeç_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update araç set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", Plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", Markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", Sericombo.Text);
            komut2.Parameters.AddWithValue("@yil", Modelyiltxt.Text);
            komut2.Parameters.AddWithValue("@renk", Renktxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", Yakitcombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(Ucrettxt.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox2.ImageLocation = "";
            YenileAraçlarListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from araç where plaka='"+satır.Cells["plaka"].Value.ToString()+"'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            YenileAraçlarListesi();
            pictureBox2.ImageLocation = "";
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        private void Markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Sericombo.Items.Clear();
                if (Markacombo.SelectedItem.ToString() == "Mercedes")
                {
                    Sericombo.Items.Add("Mercedes C180");
                    Sericombo.Items.Add("Mercedes E200 ");
                    Sericombo.Items.Add("Mercedes 200AMG");
                    Sericombo.Items.Add("Mercedes 180AMG");
                }
                else if (Markacombo.SelectedIndex == 1)
                {
                    Sericombo.Items.Add("A3 SportBack");
                    Sericombo.Items.Add("A3 Sedan");
                    Sericombo.Items.Add("S3 SportBack");
                    Sericombo.Items.Add("S3 Sedan");

                }
                else if (Markacombo.SelectedIndex == 2)
                {
                    Sericombo.Items.Add("BMW X1");
                    Sericombo.Items.Add("BMW X2");
                    Sericombo.Items.Add("BMW i4");
                    Sericombo.Items.Add("BMW iX");

                }
                else if (Markacombo.SelectedIndex == 3)
                {
                    Sericombo.Items.Add("Wolkswagen Golf");
                    Sericombo.Items.Add("Wolkswagen Passat");
                    Sericombo.Items.Add("Wolkswagen Polo");
                    Sericombo.Items.Add("Wolkswagen Tiguan");

                }
            }
            catch
            {
                ;
            }
        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(comboAraçlar.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                if(comboAraçlar.SelectedIndex == 1)
                {
                    string cümle = "select *from araç where durumu='BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource =  arackiralama.listele(adtr2, cümle);
                }
                if(comboAraçlar.SelectedIndex == 2)
                {
                    string cümle = "select *from araç where durumu='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource =  arackiralama.listele(adtr2, cümle);
                }
                

            }
            catch
            {

                throw;
            }

            
        }
    }
}
