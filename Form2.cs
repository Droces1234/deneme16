using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_random_lig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int gs = 0;
        int fb = 0;
        int bjk = 0;
        int ts = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label7.Text = c.ToString();
            label6.Text = d.ToString();
            if (Convert.ToInt16(label4.Text) > Convert.ToInt16(label5.Text))
            {
                gs = gs + 3;
                gspuan.Text = gs.ToString();
            }
            if (Convert.ToInt16(label4.Text) == Convert.ToInt16(label5.Text))
            {
                fb = fb + 1;
                gs = gs + 1;
                gspuan.Text = gs.ToString();
                fbpuan.Text = fb.ToString();
            }
            if (Convert.ToInt16(label5.Text) > Convert.ToInt16(label4.Text))
            {
                fb = fb + 3;
                fbpuan.Text = fb.ToString();
            }
            if (Convert.ToInt16(label7.Text) > Convert.ToInt16(label6.Text))
            {
                bjk = bjk + 3;
                bjkpuan.Text = bjk.ToString();
            }
            if (Convert.ToInt16(label7.Text) == Convert.ToInt16(label6.Text))
            {
                bjk = bjk + 1;
                ts = ts + 1;
                bjkpuan.Text = bjk.ToString();
                tspuan.Text = ts.ToString();
            }
            if (Convert.ToInt16(label6.Text) > Convert.ToInt16(label7.Text))
            {
                ts = ts + 3;
                tspuan.Text = ts.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            label21.Text = a.ToString();
            label18.Text = b.ToString();
            label12.Text = c.ToString();
            label11.Text = d.ToString();
            if (Convert.ToInt16(label21.Text) > Convert.ToInt16(label18.Text))
            {
                gs = gs + 3;
                gspuan.Text = gs.ToString();
            }
            if (Convert.ToInt16(label21.Text) == Convert.ToInt16(label18.Text))
            {
                bjk = bjk + 1;
                gs = gs + 1;
                gspuan.Text = gs.ToString();
                bjkpuan.Text = bjk.ToString();
            }
            if (Convert.ToInt16(label18.Text) > Convert.ToInt16(label21.Text))
            {
                bjk = bjk + 3;
                bjkpuan.Text = bjk.ToString();
            }
            if (Convert.ToInt16(label12.Text) > Convert.ToInt16(label11.Text))
            {
                fb = fb + 3;
                fbpuan.Text = fb.ToString();
            }
            if (Convert.ToInt16(label12.Text) == Convert.ToInt16(label11.Text))
            {
                fb = fb + 1;
                ts = ts + 1;
                fbpuan.Text = fb.ToString();
                tspuan.Text = ts.ToString();
            }
            if (Convert.ToInt16(label11.Text) > Convert.ToInt16(label12.Text))
            {
                ts = ts + 3;
                tspuan.Text = ts.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            label31.Text = a.ToString();
            label30.Text = b.ToString();
            label26.Text = c.ToString();
            label25.Text = d.ToString();
            if (Convert.ToInt16(label31.Text) > Convert.ToInt16(label30.Text))
            {
                fb = fb + 3;
                fbpuan.Text = fb.ToString();
            }
            if (Convert.ToInt16(label31.Text) == Convert.ToInt16(label30.Text))
            {
                bjk = bjk + 1;
                fb = fb + 1;
                fbpuan.Text = fb.ToString();
                bjkpuan.Text = bjk.ToString();
            }
            if (Convert.ToInt16(label30.Text) > Convert.ToInt16(label31.Text))
            {
                bjk = bjk + 3;
                bjkpuan.Text = bjk.ToString();
            }
            if (Convert.ToInt16(label26.Text) > Convert.ToInt16(label25.Text))
            {
                gs = gs + 3;
                gspuan.Text = gs.ToString();
            }
            if (Convert.ToInt16(label26.Text) == Convert.ToInt16(label25.Text))
            {
                gs = gs + 1;
                ts = ts + 1;
                gspuan.Text = gs.ToString();
                tspuan.Text = ts.ToString();
            }
            if (Convert.ToInt16(label25.Text) > Convert.ToInt16(label26.Text))
            {
                ts = ts + 3;
                tspuan.Text = ts.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gspuan.Text) > Convert.ToInt32(fbpuan.Text) && Convert.ToInt32(gspuan.Text) > Convert.ToInt32(tspuan.Text) && Convert.ToInt32(gspuan.Text) > Convert.ToInt32(bjkpuan.Text))
            {
                //buraya media player eklersin marşını fotosunuda eklersin diğer if şartlarınıda copy paste yazarsın bu kadar
                //label filan.text="sampiyon galatasaray";
            }
        }
    }
}
