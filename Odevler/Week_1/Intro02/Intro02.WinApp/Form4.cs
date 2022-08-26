using Intro02.WinApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro02.WinApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Sevgili {_formdanGelenMusteriBilgisi.MusteriAdi}, Toplam {lstSepetim.Items.Count} çeşit pizza siparişin bulunmakta. Bize {AnaToplamTutariBul()} TL dökül bakalım :)");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.delegem = new Form6.MyDelege(VeriyiAl);
            f.Show();
        }

        void VeriyiAl(Musteri formdanGelenMusteriBilgisi)
        {
            
                _formdanGelenMusteriBilgisi = formdanGelenMusteriBilgisi;
            
           
        }

        Musteri _formdanGelenMusteriBilgisi;

        private void Form4_Load(object sender, EventArgs e)
        {
            PizzaDoldur();
            MalzemeleriDoldur();
            txtAraToplam.Enabled = false;
            
        }

        private void MalzemeleriDoldur()
        {
            lstMalzemeler.Items.Add("Mısır");
            lstMalzemeler.Items.Add("Zeytin");
            lstMalzemeler.Items.Add("Siyah Zeytin");
    }

        private void PizzaDoldur()
        {
            cmbPizzalar.Items.Add(new Pizza()
            {
                Adi = "Süper Pizza",
                Fiyat = 50m
            }) ;
            cmbPizzalar.Items.Add(new Pizza()
            {
                Adi = "Ege Pizza",
                Fiyat = 150m
            });
        }
        Pizza secilenPizza;
        private void cmbPizzalar_SelectedIndexChanged(object sender, EventArgs e)
        {

             secilenPizza = cmbPizzalar.SelectedItem as Pizza;
            rdpKucuk.Checked = true;
            txtAraToplam.Text = secilenPizza.Fiyat.ToString();
            lstSecilenMalzemeler.Items.Clear();
            
            
            
            
        }

        private void btnAt_Click(object sender, EventArgs e)
        {
            

            if (!(lstSecilenMalzemeler.Items.Contains(lstMalzemeler.SelectedItem.ToString())))
            {
                lstSecilenMalzemeler.Items.Add(lstMalzemeler.SelectedItem);
                txtAraToplam.Text = (decimal.Parse(txtAraToplam.Text) + 1* numericUpDown1.Value).ToString();
            }
            



            
            
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (lstSecilenMalzemeler.Items.Contains(lstSecilenMalzemeler.SelectedItem.ToString()))
                {
                    lstSecilenMalzemeler.Items.Remove(lstSecilenMalzemeler.SelectedItem);
                    txtAraToplam.Text = (decimal.Parse(txtAraToplam.Text) - 1 * numericUpDown1.Value).ToString();
                }
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Bir Seçim Yapınız...");
            }

            catch (Exception)
            {

                MessageBox.Show("Bir Seçim Yapınız...");
            }

            
        }



        private void rdpKucuk_CheckedChanged_1(object sender, EventArgs e)
        {
            //todo yanlış senaryoda ne olur.
            //lstSecilenMalzemeler.Items.Clear();
            if (rdpOrta.Checked)
            {
                txtAraToplam.Text= (secilenPizza.Fiyat + (secilenPizza.Fiyat* 0.2m)).ToString();
            }
            else if (rdpBuyuk.Checked)
            {
                txtAraToplam.Text = (secilenPizza.Fiyat + (secilenPizza.Fiyat * 0.5m)).ToString();
            }
            else
            {
                txtAraToplam.Text = (secilenPizza.Fiyat ).ToString();
            }

            txtAraToplam.Text = (decimal.Parse(txtAraToplam.Text) + lstSecilenMalzemeler.Items.Count*numericUpDown1.Value).ToString();

            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // todo hata var geri dön
            decimal secilenAdetMiktari = numericUpDown1.Value;
            //string oldValue = (decimal.Parse(txtAraToplam.Text)/secilenAdetMiktari);
            txtAraToplam.Text = (decimal.Parse(txtAraToplam.Text) * secilenAdetMiktari).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstSepetim.Items.Add(new Sepetim() { 
            Adet=numericUpDown1.Value,
            Pizza=secilenPizza,
            AraTutar=decimal.Parse(txtAraToplam.Text)
            });

            lblAnaToplam.Text= AnaToplamTutariBul();
            numericUpDown1.Value = 1;
        }

        private string AnaToplamTutariBul()
        {
            // todo

            decimal a=0;

            a = decimal.Parse(lblAnaToplam.Text)+decimal.Parse(txtAraToplam.Text);
            
            return a.ToString();
        }
    }
}
