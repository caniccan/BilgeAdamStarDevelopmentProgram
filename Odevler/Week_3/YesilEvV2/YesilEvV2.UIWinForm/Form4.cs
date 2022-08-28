using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEvV2.DAL;
using YesilEvV2.DAL.Concrete;

namespace YesilEvV2.UIWinForm
{
    public partial class Form4 : Form
    {
        private string gidenVeri;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string gidenVeri):this()
        {
            
            this.gidenVeri = gidenVeri;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UrunDAL urunDAL = new UrunDAL();
            KategoriDAL kategoriDAL = new KategoriDAL();
            UreticiDAL ureticiDAL = new UreticiDAL();

            foreach (var item in urunDAL.UrunleriGetir())
            {

                if (item.BarkodNo ==  this.gidenVeri)
                {
                    textBox2.Text = this.gidenVeri;
                    comboBox2.SelectedItem = kategoriDAL.KategoriCevir(item);
                    comboBox1.SelectedItem = ureticiDAL.UreticiCevir(item);
                    textBox3.Text = item.urunAdi;
                    textBox4.Text = item.urunIcerik;
                    textBox5.Text = item.OnYuz;
                    textBox6.Text = item.ArkaYuz;

                }
                else
                {
                    textBox2.Text = this.gidenVeri;
                }
            }

            foreach (var item in urunDAL.UrunleriGetir())
            {
                listBox1.Items.Add(item);
            }


            foreach (var item in kategoriDAL.KategorileriGetir())
            {
                comboBox2.Items.Add(item);
            }

            foreach (var item in ureticiDAL.UreticiGetir())
            {
                comboBox1.Items.Add(item);
            }

            foreach (var item in urunDAL.UrunleriGetir())
            {
                listBox1.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunDAL urunDAL = new UrunDAL();
            urunDAL.UrunEkle(textBox2.Text,comboBox1.SelectedItem,textBox3.Text,comboBox2.SelectedItem,textBox4.Text,textBox5.Text,textBox6.Text);
            MessageBox.Show(urunDAL.MySaveChangesBackTF() ? "Ürün Başarıyla Oluşturuldu" : "Ürün Oluşturulurken Bir Hata Meydana Geldi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunDAL urunDAL = new UrunDAL();
            var item2 = listBox1.SelectedItem;
            foreach (var item in urunDAL.GetAll())
            {
                if (item.urunAdi==listBox1.SelectedItem.ToString())
                {
                    textBox2.Text = item.BarkodNo;
                    textBox3.Text = item.urunAdi;
                    comboBox1.SelectedItem = item.UreticiID;
                    comboBox2.SelectedItem = item.kategoriID;
                    textBox4.Text = item.urunIcerik;
                    textBox5.Text = item.OnYuz;
                    textBox6.Text = item.ArkaYuz;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                
                textBox1.Enabled = false;
            }
            else
            {
                
   
                textBox1.Enabled = true;
            }
            
        }


    }
}
