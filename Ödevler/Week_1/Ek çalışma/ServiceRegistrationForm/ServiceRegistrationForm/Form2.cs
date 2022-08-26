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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public delegate void MyDelege(List<Musteri> musteriler);
        public MyDelege myDelege;

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (ValideEt()==true)
            {
                List<Musteri> musteriler = new List<Musteri>();
                musteriler.Add(new Musteri()
                {
                    MusteriAdSoyad = textBox1.Text,
                    MusteriTelNo = textBox2.Text,
                    MusteriMail = textBox3.Text,
                    MusteriAdres = textBox4.Text,
                    MusteriTCKimlikNo = textBox5.Text
                });
                myDelege(musteriler);
                textBox1.Text =null;
                textBox2.Text =null;
                textBox3.Text =null;
                textBox4.Text =null;
                textBox5.Text =null;
                MessageBox.Show("Musteri Başarıyla Eklenmiştir...");
                
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakılmamalıdır...");
            }


        }

        private bool ValideEt()
        {
            if (!(string.IsNullOrWhiteSpace(textBox1.Text) == true  && string.IsNullOrWhiteSpace(textBox2.Text) == true && string.IsNullOrWhiteSpace(textBox3.Text) == true && string.IsNullOrWhiteSpace(textBox4.Text) == true))
            {
                return true;
            }
            else
            {
                return false;
            }
            
               
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }




        //private bool MusteriEkleValidation()
        //{
        //    if (textBox1.Text==null && maskedTextBox1.Text==null && textBox2.Text==null && textBox3.Text==null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }





        //}
    }
}
