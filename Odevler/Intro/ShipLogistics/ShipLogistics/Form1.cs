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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Gemi> gemiler=new List<Gemi>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateEt(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text))
            {
                gemiler.Add(new Gemi()
                {
                    GemiAdı = textBox1.Text,
                    MaxTon = int.Parse(textBox2.Text),
                    Konum=textBox3.Text,
                    Guzergah_1=textBox4.Text,
                    Guzergah_2=textBox5.Text,
                    Tarih = listBox1.SelectedItem.ToString()
                }) ;
                MessageBox.Show("Gemi başarıyla eklendi..");
                Clear();
            }
            else
            {
                MessageBox.Show("Boş Alanlar Doldurulmalıdır.");
            }
        }

        private void Clear()
        {
            textBox1.Text = textBox2.Text = string.Empty;
        }

        private bool ValidateEt(string text1,string text2,string text3,string text4,string text5)
        {
            return (string.IsNullOrWhiteSpace(text1) == true && string.IsNullOrWhiteSpace(text2) == true
                && string.IsNullOrWhiteSpace(text3) == true
                && string.IsNullOrWhiteSpace(text4) == true
                && string.IsNullOrWhiteSpace(text5) == true)
                ? false
                : true;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> _monthList = new List<string>();

            for (int i = 0; i < 12; i++)
            {
                _monthList.Add(DateTime.Now.AddMonths(i-6).ToString("MMMM"));
            }
            foreach (var month in _monthList)
            {
                listBox1.Items.Add(month);
            }
            listBox1.SelectedIndex = 6;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(gemiler);
            form2.Show();
        }
    }
}
