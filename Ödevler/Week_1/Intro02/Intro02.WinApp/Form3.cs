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
    public partial class Form3 : Form
    {
        private List<AnketSonuc> gonderilecekAnketler;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<AnketSonuc> gonderilecekAnketler):this()
        {
            this.gonderilecekAnketler = gonderilecekAnketler;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int soruevet = 0;
            int soruhayir = 0;
            foreach (var item in gonderilecekAnketler)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Tarih.ToShortDateString();
                for (int i = 0; i < item.AnketSonuclari.Count; i++)
                {
                    li.SubItems.Add(item.AnketSonuclari[i]==true?"Evet":"Hayir");
                    if (i==0)
                    {
                        //1. soru cevabı
                        if (item.AnketSonuclari[i] == true)
                        {
                            soruevet++;
                        }
                        else
                        {
                            soruhayir++;                        
                        }
                    }
                }
                listView1.Items.Add(li);
            }

            lblIlkSoruCevap.Text = "ilk sorunun evet sayısı : " + soruevet + "hayır sayısı :" + soruhayir;
            //lambda
            //todo lambda olmayacak şekilde 5 sorunun Evet ve hayır sayılarını yazdırınız ?
            var degerEvet = gonderilecekAnketler.Where(a=>a.AnketSonuclari[0]==true).Count();
            var degerHayir = gonderilecekAnketler.Where(a => a.AnketSonuclari[0] == false).Count();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000000; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
