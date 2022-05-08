namespace Araç_Satış_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle(); 
            ekle.ShowDialog();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();    
            listele.ShowDialog();   

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAraçKayıt kayıt = new frmAraçKayıt();
            kayıt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAraçListele kayıt = new frmAraçListele();
            kayıt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSözleşme sözlesme = new frmSözleşme();
            sözlesme.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}