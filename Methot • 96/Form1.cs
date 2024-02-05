using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methot___96
{
    public partial class Form1 : Form
    {
        Color renk = Color.Blue;
        Color renk2 = Color.Black;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sekil sekil1 = new Sekil();
            sekil1.uzunKenar = Convert.ToInt32(txtSayi1.Text);
            sekil1.kisaKenar = Convert.ToInt32(txtSayi2.Text);
            //sekil1.KareYaz();
            sekil1.sekilCiz(btnSekil, renk, renk2);

            btnSekil.Width = Convert.ToInt32(txtSayi1.Text);
            btnSekil.Height = Convert.ToInt32(txtSayi2.Text);

            sekil1.mesajDegistir(btnSekil, txtMesaj.Text);

        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk2 = colorDialog1.Color;
        }
    }
}
