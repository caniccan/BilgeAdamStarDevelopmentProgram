using Intro.Hastane.MyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro.Hastane
{
    public partial class Form4 : Form
    {
        
        private List<Hasta> hastalar;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(List<Hasta>hastalar):this()
        {
            this.hastalar = hastalar;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            foreach (var item in hastalar)
            {
                string[] sutun =
                {
                    item.Ad,item.Soyad,item.SecilenDoktor,item.TC,item.Sikayet,item.Teshis,item.KayitTarihi.ToString()
                };
                var satir =new ListViewItem(sutun);
                listView1.Items.Add(satir);
                //listView1.Items.Add(item.Ad,100);
                //listView1.Items.Add(,100);
                //listView1.Items.Add(item.SecilenDoktor,100);
                //listView1.Items.Add(item.TC,100);
                //listView1.Items.Add(item.Sikayet,100);
                //listView1.Items.Add(item.Teshis,100);
                //listView1.Items.Add(item.KayitTarihi.ToString(),100);

                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Ad", 100);
            listView1.Columns.Add("Soyad", 100);
            listView1.Columns.Add("Seçilen Doktor", 100);
            listView1.Columns.Add("TC", 100);
            listView1.Columns.Add("Şikayet", 100);
            listView1.Columns.Add("Teşhis", 100);
            listView1.Columns.Add("Kayıt Tarihi", 100);
        }
    }
}
