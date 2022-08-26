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
using YesilEv.UI.Mapping;

namespace YesilEv.UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            using (YesilEvEntities db = new YesilEvEntities())
            {
                foreach (var item in db.Uruns.ToList())
                {
                    if (item.BarkodNo ==textBox1.Text)
                    {
                        
                        textBox2.Text = item.BarkodNo;
                        comboBox1.SelectedItem = item.Uretici;
                        textBox3.Text = item.UrunAdi;
                        comboBox2.SelectedItem = item.Kategori;
                        textBox4.Text = item.UrunIcerik;
                        textBox5.Text = item.OnYuz;
                        textBox6.Text = item.ArkaYuz;
                    }
                    else
                    {
                        textBox2.Text = textBox1.Text;
                    }
                }

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
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
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
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
                BarkodNo =urunDTO.BarkodNo,
                UreticiID=urunDTO.UreticiID,
                UrunAdi=urunDTO.UrunAdi,
                KategoriID=urunDTO.KategoriID,
                UrunIcerik=urunDTO.UrunIcerik,
                OnYuz=urunDTO.OnYuz,
                ArkaYuz=urunDTO.ArkaYuz
            });


            
            
        }
    }
}
