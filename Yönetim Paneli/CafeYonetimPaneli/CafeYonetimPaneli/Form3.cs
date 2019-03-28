using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeYonetimPaneli
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string pc_adi;
        public string IP_adresi;
        public string Baglanti_Saati;
        public string Kapanma_Saati;
        VeriTabani veritabani = new VeriTabani();
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = pc_adi;
            lblIP.Text = IP_adresi;
            lblBaglanti.Text = Baglanti_Saati;
            lblKapanis.Text = Kapanma_Saati;
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            if(cmbPC.SelectedIndex != -1)
            {
                if (veritabani.MasaAktar(pc_adi, cmbPC.SelectedItem.ToString()))
                {
                    MessageBox.Show("Masa Aktarıldı.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu");
                }
               

            }
            else
            {
                MessageBox.Show("Lütfen bir masa seçin.");
            }
        }
    }
}
