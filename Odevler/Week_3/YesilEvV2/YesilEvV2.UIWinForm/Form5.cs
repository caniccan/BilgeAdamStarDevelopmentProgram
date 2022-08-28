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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            UrunDAL urunDAL = new UrunDAL();
            if (textBox1.Text!=string.Empty)
            {
                foreach (var item in urunDAL.GetAll().ToList())
                {
                    if (item.urunAdi.Contains(textBox1.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aranacak metni giriniz...");
            }

            AramaGecmisiDAL aramaGecmisiDAL = new AramaGecmisiDAL();
            aramaGecmisiDAL.AramaGecmisiEkle(textBox1.Text);
            


        }

        private void favoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FavorilerDAL favorilerDAL = new FavorilerDAL();
            if (listBox1.SelectedItem!=null)
            {
                favorilerDAL.FavoriEkle(listBox1.SelectedItem);
            }
            MessageBox.Show(favorilerDAL.MySaveChangesBackTF() ? "Ürün Başarıyla Favori Listeye Eklendi" : "Ürün Listeye Eklenirken Bir Hata Meydana Geldi.");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            FavorilerDAL favorilerDAL = new FavorilerDAL();
            foreach (var item in favorilerDAL.Favoriler())
            {
                comboBox1.Items.Add(item.ID);
            }
        }

        private void karalisteEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KaralisteDAL karalisteDAL = new KaralisteDAL();
            foreach (var item in karalisteDAL.Karaliste())
            {
                comboBox1.Items.Add(item.ID);
            }
            MessageBox.Show(karalisteDAL.MySaveChangesBackTF() ? "Ürün Başarıyla Karalisteye Eklendi" : "Ürün Listeye Eklenirken Bir Hata Meydana Geldi.");
        }
    }
}
