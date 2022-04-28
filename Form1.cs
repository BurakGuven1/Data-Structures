using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayTypedStack ats = new ArrayTypedStack();
        List<int> sayilar = new List<int>();
        int boyut = 8;
        private void button1_Click(object sender, EventArgs e)
        {
            var kontrol = true;
            Random rastgele = new Random();
            int index = rastgele.Next(boyut);
            var baslangic = ats.Push(sayilar[index], "W");
            if(baslangic < 8 && baslangic>=0)
            {
                sayilar.Remove(baslangic);
                boyut--;
            }
            else if(baslangic == 10)
            {
                txtOyunSonucu.Text = ats.EkranCiktisi() + "\n\n\tW kazandı";
                btnOyna.Enabled = false;
                btnYenidenOyna.Enabled = true;
                kontrol = false;
            }
            if(kontrol)
            {
                index = rastgele.Next(boyut);
                baslangic = ats.Push(sayilar[index], "G");
                if (baslangic < 8 && baslangic >= 0)
                {
                    sayilar.Remove(baslangic);
                    boyut--;
                }
                else if (baslangic == 10)
                {
                    txtOyunSonucu.Text = ats.EkranCiktisi() + "\n\n\tG kazandı";
                    btnOyna.Enabled = false;
                    btnYenidenOyna.Enabled = true;
                    kontrol = false;
                }
            }
            if(kontrol)
            {
                if (boyut == 0)
                {
                    txtOyunSonucu.Text = ats.EkranCiktisi() + "\n\n\t Oyun Berabere";
                    btnOyna.Enabled = false;
                    btnYenidenOyna.Enabled = true;
                }
                else
                {
                    txtOyunSonucu.Text = ats.EkranCiktisi();
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(var i=0; i<8; i++)
            {
                sayilar.Add(i);
            }
        }

        private void btnYenidenOyna_Click(object sender, EventArgs e)
        {
            txtOyunSonucu.Text = "";
            for (var i = 0; i < 8; i++)
            {
                ats.top[i] = -1;
            }
            sayilar.Clear();
            for (var i = 0; i < 8; i++)
            {
                sayilar.Add(i);
            }
            boyut = 8;
            btnYenidenOyna.Enabled = false;
            btnOyna.Enabled = true;
        }
    }
}
