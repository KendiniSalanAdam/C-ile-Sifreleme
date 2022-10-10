using System.Text;
namespace Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifresiz = textBox1.Text;
            byte[] karakterDonusum = Encoding.UTF8.GetBytes(sifresiz); // String olarak gelen veriyi UTF8 formatýnda byte olarak diziye attým.

            string sifreli = Convert.ToBase64String(karakterDonusum); // dizideki 8 bitlik tabandaki veriyi 64 bitlik tabana dönüþtürdüm

            textBox3.Text = sifreli;
            
            
        }

        private void SifreCöz_Click(object sender, EventArgs e)
        {
            string sifreli2 = textBox2.Text;                          
            byte [] karakterDonusum2 = Convert.FromBase64String(sifreli2); // gelen 64 bitlik veriyi 8 bite dönüþtürüp stringe çevirdim. 

            string cözülü = Encoding.UTF8.GetString(karakterDonusum2);    //  dizideki verileri tekrar UTF 8 e sokup þifresiz metine dönüþtürdüm.
            textBox3.Text = cözülü;


        }
    }
}