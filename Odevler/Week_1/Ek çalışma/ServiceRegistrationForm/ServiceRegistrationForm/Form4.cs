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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string v):this()
        {
            this.v = v;
        }

        

        private void Form4_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.myDelege = new Form2.MyDelege(VeriyiAl);


            foreach (var item in _musteriler)
            {
                if (item.MusteriAdSoyad.ToString()==v)
                {
                    textBox1.Text = item.MusteriAdSoyad;
                    textBox2.Text = item.MusteriTelNo;
                    textBox3.Text = item.MusteriMail;
                    textBox4.Text = item.MusteriAdres;
                    textBox5.Text = item.MusteriTCKimlikNo;
                }
            }

            


        }
        List<Musteri> _musteriler = new List<Musteri>();
        public delegate void MyDelege(List<Musteri> musteriler);
        public MyDelege myDelege;
        private string v;
        

        private void VeriyiAl(List<Musteri> musteriler)
        {
            foreach (var item in musteriler)
            {
                _musteriler.Add(item);
            }
        }



        

        private void button1_Click(object sender, EventArgs e)
        {
            _musteriler.Add(new Musteri()
            {
                MusteriAdSoyad = textBox1.Text,
                MusteriTelNo = textBox2.Text,
                MusteriMail = textBox3.Text,
                MusteriAdres = textBox4.Text,
                MusteriTCKimlikNo = textBox5.Text
            });
            myDelege(_musteriler);
            MessageBox.Show("Düzenleme işlemi başarıyla yapılmıştır...");
            this.Close();
        }
    }
}
