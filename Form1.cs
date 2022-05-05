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
    }
}