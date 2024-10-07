using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematiksel_Projem_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox1.Text); //  Girilen ilk sayıyı textbox 1 den aldık aynı zamanda sayıyı double çevirdik böylece textBox 1 girdigimiz degerin sayı oldugunu anladı
            double sayı2 = Convert.ToDouble(textBox2.Text); // İkinci sayıyı textBox 2 den aldık
            double sonuc; // yapacagımız işlemi bu degişkende yapacagız

            if (Toplama.Checked) // toplama radiobutton seçili oldugunda aşagıdaki işlemleri yap 
            {
                sonuc = sayı1 + sayı2; // sayı1 ve sayı2 topla sonuc degişkenine ata
                textBox3.Text = sonuc.ToString(); // sonuc degişkenine atanan işlemi textBox 3 yazdır
                this.Text = "Toplama İşlemini Yaptınız:"; // bu işlem yapıldıgı zaman formun başlıgında Toplama İşlemini Yaptınız Yazısı Çıkar
            }
            else if (Cıkarma.Checked)
            {
                // yukarıda yazdıgım işlemlerin aynısı buradada yapılıyor
                // toStrıng Kullanarak Sonucu Metine Çevirdik
                sonuc = sayı1 - sayı2;
                textBox3.Text = sonuc.ToString();
                this.Text = "Çıkarma İşlemi Yaptınız: ";
            }
            else if (Carpma.Checked)
            {
                sonuc = sayı1 * sayı2;
                textBox3.Text = sonuc.ToString();
                this.Text = "Çarpam İşlemi Yaptınız: ";
            }
            else if (Bolme.Checked)
            {
                sonuc = sayı1 / sayı2;
                textBox3.Text = sonuc.ToString();
                this.Text = "Bölme İşlemi Yaptınız: ";
            }
            else if (Ortalama.Checked)
            {
                sonuc = (sayı1 + sayı2) / 2;
                textBox3.Text = sonuc.ToString();
                this.Text = "Ortalama İşlemi Yaptınız: ";
            }                    
        }
    }
}
