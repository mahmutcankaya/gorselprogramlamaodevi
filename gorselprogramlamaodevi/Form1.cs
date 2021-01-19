using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlamaodevi
{
    public partial class Form1 : Form

    {
        kosucu kosucu1 = new kosucu();
        kosucu kosucu2 = new kosucu();
        kosucu kosucu3 = new kosucu();
        kosucu kosucu4 = new kosucu();
        oyuncu oyuncu1 = new oyuncu();

        Random random = new Random();
        public Form1()
        {
       
           InitializeComponent();
            kosucu1 = new kosucu()
            {
              MyPictureBox = pKosucu1,
              Randomizer = random
            };
            kosucu2 = new kosucu()
            {
                MyPictureBox = pKosucu2,
                Randomizer = random
            };
            kosucu3 = new kosucu()
            {
                MyPictureBox = pKosucu3,
                Randomizer = random
            };
            kosucu4 = new kosucu()
            {
                MyPictureBox = pKosucu4,
                Randomizer = random
            };
            oyuncu1 = new oyuncu()
            {
                Ad = "oyuncu",
              Bakiyeniz = 50,
              MyLabel2 = label3,
              MyLabel = label5,
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winner = 0;
            if (kosucu1.kos() == true)
            {
                timer1.Stop();
                button1.Enabled = false;
                MessageBox.Show(1 + "numarali kosucu kazandi");
                winner = 1;
                oyuncu1.sonuc(winner);
                button2.Enabled = true;

            }
            if (kosucu2.kos() == true)
            {
                timer1.Stop();
                button1.Enabled = false;
                MessageBox.Show(2 + "numarali kosucu kazandi");
                winner = 2;
                oyuncu1.sonuc(winner);
                button2.Enabled = true;
            }
            if (kosucu3.kos() == true)
            {
                timer1.Stop();
                button1.Enabled = false;
                MessageBox.Show(3 + "numarali kosucu kazandi");
                winner = 3;
                oyuncu1.sonuc(winner);
                button2.Enabled = true;
            }
            if (kosucu4.kos() == true)
            {
                timer1.Stop();
                button1.Enabled = false;
                MessageBox.Show(4 + "numarali kosucu kazandi");
                winner = 4;
                oyuncu1.sonuc(winner);
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kosucu1.baslangicadon();
            kosucu2.baslangicadon();
            kosucu3.baslangicadon();
            kosucu4.baslangicadon();
            timer1.Start();
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oyuncu1.mBahis((int)numericUpDown2.Value, (int)numericUpDown1.Value);
            button1.Enabled = true;
        }
    }
}
