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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string PC_Adi;
        VeriTabani veritabani = new VeriTabani();
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = PC_Adi + " - Oturum Aç";
        }

        private void btnOturum_Click(object sender, EventArgs e)
        {   
            string Sure = null;
            if (cmbTarife.SelectedIndex == 0)
                Sure = "30";
            else if (cmbTarife.SelectedIndex == 1)
                Sure = "60";

            if(Sure != null)
            {
                if (veritabani.OturumAc(PC_Adi, Sure))
                {
                    MessageBox.Show(PC_Adi + " için oturum açıldı");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Oturum Açma Hatası.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen süre belirleyin");
            }
                       
            
        }
    }
}
