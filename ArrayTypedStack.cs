using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapısı
{
    public class ArrayTypedStack 
    {
        public int[] top = {-1,-1,-1,-1,-1,-1,-1,-1};
        private object[,] items = new object[8,4];

        public int Push(int Cubuksayi, string deger)
        {
            items[Cubuksayi, ++top[Cubuksayi]] = deger;
            if(top[Cubuksayi] == 3)
            {
                var boncuk = Pop(Cubuksayi);
                while(boncuk == Pop(Cubuksayi))
                {
                    if(IsEmpty(Cubuksayi))
                    {
                        top[Cubuksayi] = 3;
                        return 10;
                    }
                }
                top[Cubuksayi] = 3;
                return Cubuksayi; 
            }
            return -1;
        }

        

        public object Pop(int cubukSayi)
        {
            var boncukRengi = items[cubukSayi, top[cubukSayi]--];
            return boncukRengi;
        }

        
        public bool IsEmpty(int cubukS)
        {
            return top[cubukS] == -1 ? true : false;
        }

        public string EkranCiktisi()
        {
            var oyunSemasi = "";

            for (var i = 0; i < 8; i++) 
            {
                var a = i;
                oyunSemasi += "S" + (a + 1).ToString() + "- ";
                for (var k = 0; k <= top[i]; k++)
                {
                    oyunSemasi += items[i, k].ToString();
                }
                oyunSemasi += Environment.NewLine;
            }
            return oyunSemasi;
        }
    }

    
}
