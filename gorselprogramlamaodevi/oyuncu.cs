using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlamaodevi
{
    public class oyuncu
    {
        public string Ad;
        public bahis Bahisim;
        public int Bakiyeniz;

        public Label MyLabel;
        public Label MyLabel2;

        public void guncelleme()
        {
            MyLabel.Text = Bahisim.aciklamalar();
            MyLabel2.Text = "Bakiyeniz: " + Bakiyeniz;

        }

        public bool mBahis(int Amount, int kosucu)
        {
            if (Amount <= Bakiyeniz)
            {
                Bahisim = new bahis() { Miktar = Amount, kosucu = kosucu, Oyuncu = this };
                guncelleme();
                return true;

            }
            else
                return false;


        }

        public void sonuc(int winner)
        {
            Bakiyeniz += Bahisim.odeme(winner);
            guncelleme();
        }
    }
}
