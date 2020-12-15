using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Java_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
        }
        Kumbara kumbara = new Kumbara();
        private void Btn_ekle_Click(object sender, EventArgs e)
        {
            double miktar=double.Parse(comboBox1.SelectedItem.ToString());
            bool sonuc=kumbara.ParaEkle(miktar);
            if (sonuc) {
                pictureBox2.Visible = true;
                timer1.Start();
                progressBar1.Value = (int)kumbara.dolulukOranı()<100? (int)kumbara.dolulukOranı():100;
            }
        }

        private void Btn_kir_Click(object sender, EventArgs e)
        {
            lbl_miktar.Text = kumbara.KumbarayiKir().ToString() + "₺";
        }

        private void btn_calkala_Click(object sender, EventArgs e)
        {
            kumbara.KumbarayiCalkala();
            progressBar1.Value = (int)kumbara.dolulukOranı() < 100 ? (int)kumbara.dolulukOranı() : 100;
        }

        private void Btn_yapistir_Click(object sender, EventArgs e)
        {
            bool sonuc = kumbara.KumbarayiYapistir();
            if (sonuc)
            {
                lbl_miktar.Text = "";
                progressBar1.Value = 0;
            }
        }

        int timerSayac = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timerSayac <= 1000)
            {
                timerSayac += timer1.Interval;
                pictureBox2.Top += 10;
            }

            else
            {
                timerSayac = 0;
                timer1.Stop();
                pictureBox2.Top = 21;
                pictureBox2.Visible = false;
            }
        }
    }
}
