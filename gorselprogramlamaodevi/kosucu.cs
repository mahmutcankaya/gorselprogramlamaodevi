using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlamaodevi
{
    public class kosucu
    {
        public int baslangicnoktasi = 0, sahaalani = 397, konum = 0;
        public PictureBox MyPictureBox = null;
        public Random Randomizer;

        public bool kos()
        {
            konum = Randomizer.Next(1, 5);
            MyPictureBox.Left += konum;
            if (sahaalani <= MyPictureBox.Left)
                return true;
            else
                return false;
        }

        public void baslangicadon()
        {
            MyPictureBox.Left = baslangicnoktasi;
        }
    }
}
