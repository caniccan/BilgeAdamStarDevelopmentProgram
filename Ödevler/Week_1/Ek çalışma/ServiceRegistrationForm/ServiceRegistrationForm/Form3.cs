using ServiceRegistrationForm.MyModels;
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
    public partial class Form3 : Form
    {
        private List<Musteri> musteriler;
        private Musteri musteri;
        public delegate void MyDelege(List<Cihaz> cihazlar);
        public MyDelege myDelege;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(List<Musteri> musteriler, Musteri musteri) : this()
        {
            this.musteri = musteri;
            this.musteriler = musteriler;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lstCihazlar.Items.Add("Bilgisayar");
            lstCihazlar.Items.Add("Telefon");
            lstCihazlar.Items.Add("Televizyon");
            lstCihazlar.Items.Add("Yazıcı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Cihaz> cihazlar = new List<Cihaz>();
            Cihaz chz = new Cihaz();
            chz.CihazSahibi = musteri;
            chz.CihazAd = lstCihazlar.SelectedItem.ToString();
            chz.CihazModel = textBox1.Text;
            chz.CihazAriza = textBox2.Text;
            cihazlar.Add(chz);
            MessageBox.Show("Başarıyla cihaz eklediniz...");
            Form5 form5 = new Form5(cihazlar);
            form5.Show();
            this.Close();
            
        }


        

    }
}
