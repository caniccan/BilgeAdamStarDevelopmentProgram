using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicket
{
    public partial class Form1 : Form
    {
        private List<Bilet> sepet;
        private bool satildiMi;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Bilet> sepet, bool satildiMi) :this()
        {
            this.sepet = sepet;
            this.satildiMi = satildiMi;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 1;
            if (ValidateEt())
            {
                for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if ((!(i == 0 && j == 0)) && (!(i == 0 && j == 1)) && (!(i == 0 && j == 12)) && (!(i == 0 && j == 13)) && (!(i == 1 && j == 2)) && (!(i == 1 && j == 11)) && (!(i == 2 && j == 2)) && (!(i == 2 && j == 11)) && (!(i == 3 && j == 2)) && (!(i == 3 && j == 11)) && (!(i == 4 && j == 0)) && (!(i == 4 && j == 1)) && (!(i == 4 && j == 12)) && (!(i == 4 && j == 13)) && (!(i == 5 && j == 0)) && (!(i == 5 && j == 1)) && (!(i == 5 && j == 12)) && (!(i == 5 && j == 13)))
                    {
                            Button btn = new Button();
                            btn.Tag = listBox1.SelectedItem.ToString() + " " + listBox2.SelectedItem.ToString();
                            btn.Width = 35;
                            btn.Height = 30;
                            btn.Left = 35 * j;
                            btn.Top = 35 * i + 10;
                            btn.Text = (sayac++).ToString();
                            btn.AccessibleName = (sayac-1).ToString();
                            groupBox1.Controls.Add(btn);
                            if (!(sepet==null))
                            {
                                foreach (var item in sepet)
                                {
                                    if (item.KoltukNo.ToString() == btn.AccessibleName)
                                    {
                                        btn.BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                }
            }
            }
        }

        private bool ValidateEt()
        {
            if (listBox1.SelectedItem == null && listBox2.SelectedItem == null)
            {
                MessageBox.Show("Film ve Seans Seçiniz...");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Film> films = new List<Film>();
            films.Add(new Film() { FilmAdi= "Harry Potter and the Sorcerer's Stone" });
            films.Add(new Film() { FilmAdi= "Harry Potter and the Chamber of Secrets" });
            films.Add(new Film() { FilmAdi= "Harry Potter and the Prisoner of Azkaban" });
            films.Add(new Film() { FilmAdi= "Harry Potter and the Goblet of Fire" });
            films.Add(new Film() { FilmAdi= "Harry Potter and the Order of the Phoenix" });
            films.Add(new Film() { FilmAdi= "Harry PotterHarry Potter and the Half-Blood Prince ***" });
            films.Add(new Film() { FilmAdi= "Harry Potter and the Deathly Hallows: Part 1" });
            films.Add(new Film() { FilmAdi= "Harry Potter and the Deathly Hallows: Part 2" });
            foreach (var item in films)
            {
                listBox1.Items.Add(item.FilmAdi);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<Seans> seans = new List<Seans>();
            seans.Add(new Seans() { FilmAdi = listBox1.SelectedItem.ToString(), FilmTarihi = DateTime.Parse("09:00") });
            seans.Add(new Seans() { FilmAdi = listBox1.SelectedItem.ToString(), FilmTarihi = DateTime.Parse("15:00") });
            seans.Add(new Seans() { FilmAdi = listBox1.SelectedItem.ToString(), FilmTarihi = DateTime.Parse("21:00") });
            foreach (var item in seans)
            {
                listBox2.Items.Add(item.FilmTarihi.ToShortTimeString());
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(sepet);
            form2.Show();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(sepet==null))
            {
                foreach (var item in sepet)
                {
                    File.AppendAllText("log.txt", item.AdSoyad);
                    File.AppendAllText("log.txt", item.Cinsiyet);
                    File.AppendAllText("log.txt", item.KoltukNo);
                    File.AppendAllText("log.txt", item.NakitOdeme.ToString());
                    File.AppendAllText("log.txt", item.KartOdeme.ToString());
                    File.AppendAllText("log.txt", item.KartNo);
                    File.AppendAllText("log.txt", DateTime.Now.ToString());
                    File.AppendAllText("log.txt", Environment.NewLine);
                }
            }
        }
    }
    }

