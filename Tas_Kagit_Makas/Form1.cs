using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tas_Kagit_Makas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string oyuncu;
        string blg;
        int oyuncu_p;
        int blg_p;
        Random ras = new Random();
        int rastge;
        int elsay;
        private void pB_Tas_Click(object sender, EventArgs e)
        {
            pB_kl.ImageLocation = "resim/tas.jpg";
            oyuncu = "tas";
            Blg_hamle();
            skor();
            elsay++;
            lb_elsay.Text = elsay.ToString();

        }

        private void pB_kagt_Click(object sender, EventArgs e)
        {
            pB_kl.ImageLocation = "resim/kagit.jpg";
            oyuncu = "kagit";
            Blg_hamle();
            skor();
            elsay++;
            lb_elsay.Text = elsay.ToString();
        }

        private void pB_mks_Click(object sender, EventArgs e)
        {
            pB_kl.ImageLocation = "resim/makas.jpg";
            oyuncu = "makas";
            Blg_hamle();
            skor();
            elsay++;
            lb_elsay.Text = elsay.ToString();
        }

        private void Blg_hamle()
        {

            rastge = ras.Next(1, 4);
            if (rastge == 1)
            {
                pB_blg.ImageLocation = "resim/tas.jpg";
                blg = "tas";

            }
           else if (rastge == 2)
            {
                pB_blg.ImageLocation = "resim/kagit.jpg";
                blg = "kagit";

            }
            else if (rastge == 3)
            {
                pB_blg.ImageLocation = "resim/makas.jpg";
                blg = "makas";

            }
        }
    private void skor()
        {
            if(oyuncu=="tas" && blg == "kagit")
            {
                blg_p++;
                blgpuan.Text = blg_p.ToString();

            }

           else if (oyuncu == "tas" && blg == "makas")
            {
                oyuncu_p++;
                klcpuan.Text = oyuncu_p.ToString();

            }
            else if (oyuncu == "kagit" && blg == "tas")
            {
                oyuncu_p++;
                klcpuan.Text = oyuncu_p.ToString();

            }
            else if (oyuncu == "kagit" && blg == "makas")
            {
                blg_p++;
                blgpuan.Text = blg_p.ToString();

            }
            else if (oyuncu == "makas" && blg == "tas")
            {
                blg_p++;
                blgpuan.Text = blg_p.ToString();

            }
            else if (oyuncu == "makas" && blg == "kagit")
            {
                oyuncu_p++;
                klcpuan.Text = oyuncu_p.ToString();

            }

            if (elsay == 10)
            {

                lb_snc.Visible = true;
                if (oyuncu_p > blg_p)
                {
                    lb_snc.Text = "SEN KAZANDIN";
                    oyuncu_p=0;
                     blg_p=0;
                    elsay = -1;
                    lb_elsay.Text = elsay.ToString();
                    pB_blg.ImageLocation = null;
                    pB_kl.ImageLocation = null;
                    blg = null;
                    blgpuan.Text = blg_p.ToString();
                    klcpuan.Text = oyuncu_p.ToString();
                }
                else if (oyuncu_p < blg_p)
                {
                    lb_snc.Text = "BİLGİSAYAR KAZANDI";
                    oyuncu_p = 0;
                    blg_p = 0;
                    elsay = -1;
                    lb_elsay.Text = elsay.ToString();
                    pB_blg.ImageLocation = null;
                    pB_kl.ImageLocation = null;
                    blg = null;
                    blgpuan.Text = blg_p.ToString();
                    klcpuan.Text = oyuncu_p.ToString();
                }
                else if (oyuncu_p == blg_p)
                {
                    lb_snc.Text = "BERABERE";
                    oyuncu_p = 0;
                    blg_p = 0;
                    elsay = -1;
                    lb_elsay.Text = elsay.ToString();
                    pB_blg.ImageLocation = null;
                    pB_kl.ImageLocation = null;
                    blg = null;
                    blgpuan.Text = blg_p.ToString();
                    klcpuan.Text = oyuncu_p.ToString();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
                    form2sec.Show();
                      this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
