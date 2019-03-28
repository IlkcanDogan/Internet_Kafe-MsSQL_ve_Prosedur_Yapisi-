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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VeriTabani veritabani = new VeriTabani();


        private void Form1_Load(object sender, EventArgs e)
        {
            OnlinePCYenile();
            tmrYenile.Interval = 3000;
            tmrYenile.Start();
        }


        private void View_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string PC_Adi=null;
            foreach (ListViewItem etiket in View.SelectedItems)
            {
                PC_Adi = etiket.Text.ToString();
            }

            if(PC_Adi != null)
            {
                if (PC_Adi.IndexOf('@', 0, PC_Adi.Length - 1) != -1)
                {
                    PC_Adi = PC_Adi.Substring(1,PC_Adi.Length-1);
                    string IP_Adresi = null;
                    string Baglanti_saati = null;
                    string Kapanma_saati = null;
                   
                    foreach (DataRow satir in veritabani.PCBilgiGetir(PC_Adi).Rows)
                    {
                        IP_Adresi = satir["IP_Adresi"].ToString();
                        Baglanti_saati = satir["Baglanti_Saati"].ToString();
                        Kapanma_saati = satir["Kapanma_Saati"].ToString();
                    }

                    if(IP_Adresi != null & Baglanti_saati != null && Kapanma_saati != null)
                    {
                        Form3 form3 = new Form3();
                        form3.pc_adi = PC_Adi;
                        form3.IP_adresi = IP_Adresi;
                        form3.Baglanti_Saati = Baglanti_saati;
                        form3.Kapanma_Saati = Kapanma_saati;

                        string BosMasa = null;
                        foreach (ListViewItem etiket in View.Items)
                        {

                            BosMasa = etiket.Text.ToString();
                            if(BosMasa.IndexOf('@', 0, BosMasa.Length - 1) == -1)
                            {
                                form3.cmbPC.Items.Add(BosMasa);
                            }
                        }

                        form3.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bir Sorun Var");
                    }
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.PC_Adi = PC_Adi;
                    form2.ShowDialog();
                }
            }
            
        }
        public void OnlinePCYenile()
        {
            View.Items.Clear();
            ImageList ResimListesi = new ImageList();
            ResimListesi.ImageSize = new Size(64, 64);
            ResimListesi.Images.Add(Image.FromFile(@"pc1.png"));
            ResimListesi.Images.Add(Image.FromFile(@"pc2.png"));
            View.LargeImageList = ResimListesi;

            string pc_adi;
            bool durum;
            byte sayac1 = 0;
            byte sayac2 = 0;
            foreach (DataRow satir in veritabani.OnlinePCler().Rows)
            {
                
                pc_adi = satir["PC_Adi"].ToString();
                durum = Convert.ToBoolean(satir["Durum"]);
                if (durum == true)
                {
                    View.Items.Add("@"+pc_adi, 1);
                   
                    sayac1++;
                }
                else
                {
                    View.Items.Add(pc_adi, 0);
                    sayac2++;
                }
                    
            }
            lblOnlineSayisi.Text = sayac1.ToString();
            lblOfflineSayisi.Text = sayac2.ToString();
            sayac1 = 0;
            sayac2 = 0;
        }

        private void tmrYenile_Tick(object sender, EventArgs e)
        {
            OnlinePCYenile();
        }
    }
}
