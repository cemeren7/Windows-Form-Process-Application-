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
            double sayı1 = Convert.ToDouble(textBox1.Text); 
            double sayı2 = Convert.ToDouble(textBox2.Text);
            double sonuc;
            if (Toplama.Checked)
            {
                sonuc = sayı1 + sayı2; 
                textBox3.Text = sonuc.ToString();
                this.Text = "Toplama İşlemini Yaptınız:";
            }
            else if (Cıkarma.Checked)
            {
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
