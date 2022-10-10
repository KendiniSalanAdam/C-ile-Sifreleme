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
            byte[] karakterDonusum = Encoding.UTF8.GetBytes(sifresiz); // String olarak gelen veriyi UTF8 format�nda byte olarak diziye att�m.

            string sifreli = Convert.ToBase64String(karakterDonusum); // dizideki 8 bitlik tabandaki veriyi 64 bitlik tabana d�n��t�rd�m

            textBox3.Text = sifreli;
            
            
        }

        private void SifreC�z_Click(object sender, EventArgs e)
        {
            string sifreli2 = textBox2.Text;                          
            byte [] karakterDonusum2 = Convert.FromBase64String(sifreli2); // gelen 64 bitlik veriyi 8 bite d�n��t�r�p stringe �evirdim. 

            string c�z�l� = Encoding.UTF8.GetString(karakterDonusum2);    //  dizideki verileri tekrar UTF 8 e sokup �ifresiz metine d�n��t�rd�m.
            textBox3.Text = c�z�l�;


        }
    }
}