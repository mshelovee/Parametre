using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methot___96
{
    internal class Sekil
    {
        public int uzunKenar { get; set; }

        public int kisaKenar { get; set; }

        //parametre almayan ve değer döndürmeyen(void)

        public void KareYaz()
        {
            int sonuc = this.kisaKenar * this.uzunKenar;
            MessageBox.Show($"Şeklin Karesi: {sonuc}");
        }

        //parametre alan ve değer dödürmeyen(void)
        public void sekilCiz(Button btn, Color renk, Color renk2)
        {
            btn.Width = this.uzunKenar;
            btn.Height = this.kisaKenar;
            btn.BackColor = renk;
            btn.ForeColor = renk2;
            
        }

        public void mesajDegistir(Button btn, String mesaj)
        {
            btn.Text = mesaj;
        }

    }
}
