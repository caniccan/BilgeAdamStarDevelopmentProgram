using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.myDelege = new Form2.MyDelege(VeriyiAl);
            form2.Show();
        }

        private void VeriyiAl(List<Musteri> musteriler)
        {
            foreach (var item in musteriler)
            {

                _musteriler.Add(item);
            }

        }

        List<Musteri> _musteriler = new List<Musteri>();

        private void button4_Click(object sender, EventArgs e)
        {
            

            listBox1.Items.Clear();
            foreach (var item in _musteriler)
            {
                
                if (item.MusteriAdSoyad.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(item.MusteriAdSoyad);
                }

            }
            
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(listBox1.SelectedItem.ToString());
            form4.myDelege = new Form4.MyDelege(VeriyiAl);
            form4.Show();
            

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem==null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz...");
            }
            else
            {
                Musteri musteri = new Musteri();
                foreach (var item in _musteriler)
                {
                    if (item.MusteriAdSoyad == listBox1.SelectedItem.ToString())
                    {
                        musteri = item;
                    }
                }

                Form3 form3 = new Form3(_musteriler, musteri);

                form3.Show();
            }
            
        }
    }
}
