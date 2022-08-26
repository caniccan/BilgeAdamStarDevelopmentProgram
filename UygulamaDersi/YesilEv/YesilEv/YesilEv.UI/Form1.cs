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

namespace YesilEv.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible= true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != String.Empty && textBox4.Text != String.Empty && textBox5.Text != String.Empty && textBox6.Text != String.Empty)
            {

                //Repo<Uye> repo = new Repo<Uye>();
                //Uye uye = repo.Insert(new Uye()
                //{
                //    AdiSoyadi=textBox3.Text,
                //    TelNo=textBox4.Text,
                //    KullaniciAdi=textBox5.Text,
                //    Sifre=textBox6.Text
                //});


                using (YesilEvEntities db = new YesilEvEntities())
                {
                    db.Uyes.Add(new Uye()
                    {
                        ID = 0,
                        AdiSoyadi = textBox3.Text,
                        TelNo = textBox4.Text,
                        KullaniciAdi = textBox5.Text,
                        Sifre = textBox6.Text
                    });
                    MessageBox.Show(db.SaveChanges() > 0 ? "Üyelik Başarıyla Oluşturuldu" : "Üyelik Oluşturulurken Bir Hata Meydana Geldi.");
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakılmamalı...");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (YesilEvEntities db =new YesilEvEntities())
            {
                foreach (var item in db.Uyes.ToList())
                {
                    //MessageBox.Show(item.KullaniciAdi == textBox1.Text && item.Sifre == textBox2.Text ? "Başarıyla Giriş Yaptınız..." : "Kullanıcı Adı veya Şifre Yanlış"); 
                    if (item.KullaniciAdi == textBox1.Text && item.Sifre == textBox2.Text)
                    {
                        MessageBox.Show("Başarıyla Giriş Yaptınız...");
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış...");
                    }
                }
            }
        }
    }
}
