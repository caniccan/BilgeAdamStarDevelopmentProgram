using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicket
{
    public partial class Form3 : Form
    {
        private List<Bilet> sepet=new List<Bilet>();
        private string text1;
        private string text2;
        private ListBox.ObjectCollection items;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(List<Bilet> sepet, string text1, string text2, ListBox.ObjectCollection items) : this()
        {
            this.sepet = sepet;
            this.text1 = text1;
            this.text2 = text2;
            this.items = items;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text = (sepet.Count * 50).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = (int.Parse(label3.Text) - int.Parse(textBox2.Text)).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sepet.Clear();
            foreach (var item in items)
            {
                sepet.Add(new Bilet()
                {
                    AdSoyad = text1,
                    Cinsiyet = text2,
                    KoltukNo = item.ToString(),
                    NakitOdeme = int.Parse(textBox2.Text),
                    KartOdeme = int.Parse(label6.Text),
                    KartNo = maskedTextBox1.Text.ToString()
                });
            }
            bool SatildiMi = true;
            MessageBox.Show("Bilet Alma İşleminiz başarıyla tamamlandı...");
            Form1 frm = new Form1(sepet,SatildiMi);
            frm.Show();
        }
    }
}
