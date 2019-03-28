using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IstemciPaneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        veritabani veritabani = new veritabani();
        string PC_Adi = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            PC_Adi = Dns.GetHostName();
            string IP_Adresi = Dns.GetHostByName(PC_Adi).AddressList[0].ToString();
            if (veritabani.BaglantiKur(PC_Adi,IP_Adresi))
            {
                lblDurum.Text = "Bağlantı Kuruldu";
                tmrSorgula.Interval = 1000;
                tmrSorgula.Start();
            }
            else
            {
                lblDurum.Text = "Bağlantı Hatası";
            }

        }

        private void tmrSorgula_Tick(object sender, EventArgs e)
        {
            string saat = veritabani.SaatSorgula(PC_Adi);
            if (saat != "1")
            {
                lblOturum.Text = "Oturumunuz SAAT " + saat + "'da Sonlanacaktır.";
                tmrSorgula.Stop();
            }
            else
            {
                lblOturum.Text = "Oturum Bekleniyor...";
            }
        }
    }
}
