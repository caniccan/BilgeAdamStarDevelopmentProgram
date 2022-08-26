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
    public partial class Form2 : Form
    {
        private List<Bilet> sepet;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Bilet> sepet):this()
        {
            this.sepet = sepet;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            List<Button> buttons=new List<Button>();
            int sayac = 1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if ((!(i == 0 && j == 0)) && (!(i == 0 && j == 1)) && (!(i == 0 && j == 12)) && (!(i == 0 && j == 13)) && (!(i == 1 && j == 2)) && (!(i == 1 && j == 11)) && (!(i == 2 && j == 2)) && (!(i == 2 && j == 11)) && (!(i == 3 && j == 2)) && (!(i == 3 && j == 11)) && (!(i == 4 && j == 0)) && (!(i == 4 && j == 1)) && (!(i == 4 && j == 12)) && (!(i == 4 && j == 13)) && (!(i == 5 && j == 0)) && (!(i == 5 && j == 1)) && (!(i == 5 && j == 12)) && (!(i == 5 && j == 13)))
                    {
                        Button btn = new Button();
                        btn.Width = 35;
                        btn.Height = 30;
                        btn.Left = 35 * j;
                        btn.Top = 35 * i + 10;
                        btn.Text = (sayac++).ToString();
                        btn.AccessibleName = (sayac-1).ToString();
                        this.Controls.Add(btn);
                        buttons.Add(btn);
                        if (!(sepet == null))
                        {
                            foreach (var item in sepet)
                            {
                                if (item.KoltukNo.ToString() == btn.AccessibleName)
                                {
                                    btn.BackColor = Color.Red;
                                }
                            }
                        }
                        if (btn.BackColor==Color.Red)
                        {
                            buttons.Remove(btn);
                        }
                    }
                }
            }
            foreach (var item in buttons)
            {
                listBox1.Items.Add(item.AccessibleName);
            }
            comboBox1.Items.Add("Kadın");
            comboBox1.Items.Add("Erkek");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
        private void button3_Click(object sender, EventArgs e)
        {
           List<Bilet> sepet = new List<Bilet>();
            foreach (var item in listBox2.Items)
            {
                sepet.Add(new Bilet() { AdSoyad = textBox1.Text, Cinsiyet = comboBox1.Text, KoltukNo = item.ToString()});
            }
            Form3 form3 = new Form3(sepet,textBox1.Text,comboBox1.Text,listBox2.Items);
            form3.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}
