using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEv.UI.DAL.Repo;
using YesilEv.UI.DTO;

namespace YesilEv.UI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunDTO urunDTO = new UrunDTO()
            {
                BarkodNo = textBox2.Text,
                UreticiID = 1,
                UrunAdi = textBox3.Text,
                KategoriID = 1,
                UrunIcerik = textBox4.Text,
                OnYuz = textBox5.Text,
                ArkaYuz = textBox6.Text,
            };


            Repo<Urun> repo = new Repo<Urun>();
            Urun eklenecekUrun = repo.Insert(new Urun(urunDTO)
            {
                BarkodNo = urunDTO.BarkodNo,
                UreticiID = urunDTO.UreticiID,
                UrunAdi = urunDTO.UrunAdi,
                KategoriID = urunDTO.KategoriID,
                UrunIcerik = urunDTO.UrunIcerik,
                OnYuz = urunDTO.OnYuz,
                ArkaYuz = urunDTO.ArkaYuz
            });
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (YesilEvEntities db = new YesilEvEntities())
            {
                foreach (var item in db.Ureticis.ToList())
                {
                    comboBox1.Items.Add(item.UreticiAdi);
                }
                foreach (var item in db.Kategoris.ToList())
                {
                    comboBox2.Items.Add(item.KategoriAdi);
                }


                foreach (var item in db.Uruns.ToList())
                {
                    listBox1.Items.Add(item.UrunAdi);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems!=null)
            {
                using (YesilEvEntities db = new YesilEvEntities())
                {
                    foreach (var item in db.Uruns.ToList())
                    {
                        if (item.UrunAdi==listBox1.SelectedItem.ToString())
                        {
                            textBox2.Text = item.BarkodNo;
                            comboBox1.SelectedItem = item.UrunAdi;
                            comboBox2.SelectedItem = item.Kategori;
                            textBox3.Text=item.UrunAdi;
                            textBox4.Text = item.UrunIcerik;
                            textBox5.Text = item.OnYuz;
                            textBox6.Text = item.ArkaYuz;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ürün listesinden seçim yapınız...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
