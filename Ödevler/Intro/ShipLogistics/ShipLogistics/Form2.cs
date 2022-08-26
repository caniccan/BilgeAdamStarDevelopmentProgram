using ShipLogistics.MyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipLogistics
{
    public partial class Form2 : Form
    {
        private List<Gemi> gemiler;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Gemi> gemiler):this()
        {
            this.gemiler = gemiler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VatidateEt(textBox1.Text, int.Parse(textBox3.Text), textBox2.Text, textBox4.Text, textBox5.Text))
            {
                
                foreach (var item in gemiler)
                {
                    string _guzergah = item.Guzergah_1 + item.Guzergah_2;
                    if (item.MaxTon>int.Parse(textBox3.Text) && item.Konum.ToUpper()==textBox4.Text.ToUpper() && _guzergah.Contains(textBox5.Text) && item.Tarih==listBox2.SelectedItem.ToString() )
                    {
                        listBox1.Items.Add(item.GemiAdı+" "+item.MaxTon+" Ton");
                    }
                }
                
                MessageBox.Show("Uygun Gemiler Listelenmiştir, Lütfen Seçiminizi Yapınız...");

            }
            else
            {
                MessageBox.Show("Boş Alanlar Doldurulmalıdır...");
            }




        }

        private bool VatidateEt(string text1, int text2, string text3, string text4, string text5)
        {
            return (string.IsNullOrWhiteSpace(text1) == true && string.IsNullOrWhiteSpace(text2.ToString()) == true
                && string.IsNullOrWhiteSpace(text3) == true
                && string.IsNullOrWhiteSpace(text4) == true
                && string.IsNullOrWhiteSpace(text5) == true)
                ? false
                : true;
        }

        List<Yuk> yukler = new List<Yuk>();
        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> _monthList = new List<string>();

            for (int i = 0; i < 12; i++)
            {
                _monthList.Add(DateTime.Now.AddMonths(i - 6).ToString("MMMM"));
            }
            foreach (var month in _monthList)
            {
                listBox2.Items.Add(month);
            }
            listBox2.SelectedIndex = 6;
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (VatidateEt(textBox1.Text, int.Parse(textBox3.Text), textBox2.Text, textBox4.Text, textBox5.Text))
            {
                yukler.Add(new Yuk()
                {
                    YukSahibi = textBox1.Text,
                    YukCinsi = textBox2.Text,
                    YukAgırlık = int.Parse(textBox3.Text),
                    MevcutKonum = textBox4.Text,
                    HedefKonum = textBox5.Text,
                    Tarih = listBox2.SelectedItem.ToString(),
                });
                MessageBox.Show("Yük Kaydı Başarıyla Tamamlandı...");
            }
            else
            {
                MessageBox.Show("Boş Alanlar Doldurulmalıdır.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(gemiler,yukler);
            form3.Show();
        }
    }
}
