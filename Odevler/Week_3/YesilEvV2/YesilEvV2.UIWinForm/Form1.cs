using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEvV2.Core.Context;
using YesilEvV2.Core.Entities;
using YesilEvV2.Core.Repos;
using YesilEvV2.DAL;
using YesilEvV2.DAL.Interfaces;
using YesilEvV2.Mapping;

namespace YesilEvV2.UIWinForm
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
            groupBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UyeOlValidate())
            {
                UyeDAL uyeDAL = new UyeDAL();
                uyeDAL.UyeEkle(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show(uyeDAL.MySaveChangesBackTF() ? "Üyelik Başarıyla Oluşturuldu" : "Üyelik Oluşturulurken Bir Hata Meydana Geldi.");
            }
            else
            {
                MessageBox.Show("Boş alan Bırakılmamalıdır...");
            }
        }
        private bool UyeOlValidate()
        {
            if (textBox3.Text != String.Empty && textBox4.Text != String.Empty && textBox5.Text != String.Empty && textBox6.Text != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeDAL uyeDAL = new UyeDAL();

            foreach (var item in uyeDAL.UyeGetir())
            {
                if (UyeGirisValidate())
                {
                    if (item.KullaniciAdi == textBox1.Text && item.Sifre == textBox2.Text)
                    {
                        MessageBox.Show("Giriş Başarılı...");
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Giriş Yaparken Bir Sorun Oluştu...");
                    }
                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakılmamalıdır...");
                }
                
            }
            
        }

        private bool UyeGirisValidate()
        {
            if (textBox1.Text!=String.Empty && textBox2.Text!=String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
