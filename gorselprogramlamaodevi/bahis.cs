using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorselprogramlamaodevi
{
    public class bahis
    {
        public int Miktar = 0, kosucu;
        public oyuncu Oyuncu;

        public string aciklamalar()
        {
            if (Miktar == 0)
                return "Bahiste Bulunmadınız";
            else
                return kosucu + " numaralı kosucuya \n" + Miktar + " TL para yatırdınız.";
        }



        public int odeme(int winner)
        {
            if (kosucu == winner)
                return Miktar;
            else
                return -Miktar;
        }
    }


}
