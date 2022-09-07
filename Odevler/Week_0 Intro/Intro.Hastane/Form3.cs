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
    public partial class Form3 : Form
    {
        private List<Doktor> doktors;
        private List<Bolum> bolumler;
        List<Hasta> hst = new List<Hasta>();
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<Doktor> doktors):this()
        {
            this.doktors = doktors;
           
        }

        public Form3(List<Doktor> doktors, List<Bolum> bolumler) : this(doktors)
        {
            this.bolumler = bolumler;
            foreach (var item in bolumler)
            {
                comboBox1.Items.Add(item);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var item in this.doktors)
            {
                lstDoktorlar.Items.Add(item);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bolum secilenBolum= comboBox1.SelectedItem as Bolum;
            lstDoktorlar.Items.Clear();
            foreach (var item in doktors)
            {
                if (item.Bolum.BolumAdi ==secilenBolum.BolumAdi)
                {
                    lstDoktorlar.Items.Add(item.ToString().ToUpper());
                }
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            //todo arama geliştir. 
            //  var degerler = doktors.Where(x => x.DoktorAdSoyad == "efe").ToList();
            lstDoktorlar.Items.Clear();
            foreach(var item in this.doktors)
            {
                if (item.ToString().Contains(textBox3.Text))
                {
                    
                    lstDoktorlar.Items.Add(item.ToString().ToUpper());
                }
            }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hst.Add(new Hasta()
            {
                Ad=textBox1.Text,
                Soyad=textBox2.Text,
                SecilenDoktor=lstDoktorlar.SelectedItems.ToString(),
                TC=maskedTextBox1.Text,
                Sikayet=textBox4.Text,
                Teshis=textBox5.Text,
                KayitTarihi=DateTime.Now,
            });
            MessageBox.Show("Hasta Kaydı Başarıyla Alındı.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(hst);
            form4.Show();

        }
    }
}
