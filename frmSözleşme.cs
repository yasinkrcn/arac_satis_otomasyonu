using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string sorgu2 = "select *from araç where durumu='BOŞ'";
            arac.Bos_Araçlar(comboAraclar,sorgu2);
            
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text="";
            string sorgu2 = "select *from müşteri where tc like '"+txtTC.Text+"'";
            arac.TC_Ara(txtTC, txtAdSoyad, txtTelNo, sorgu2);
        }
    }
}
