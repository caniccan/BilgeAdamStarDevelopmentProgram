using ServiceRegistrationForm.MyModels;
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

namespace ServiceRegistrationForm
{
    public partial class Form5 : Form
    {

        private List<Cihaz> cihazlar;

        public Form5()
        {
            InitializeComponent();
        }

        public Form5(List<Cihaz> cihazlar) : this()
        {
            this.cihazlar = cihazlar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cihazlar != null)
            {
                foreach (var item in cihazlar)
                {

                    if (item.CihazSahibi.MusteriAdSoyad.Contains(textBox1.Text))
                    {
                        string[] sutun =
                        {
                    item.CihazSahibi.MusteriAdSoyad,item.CihazSahibi.MusteriTCKimlikNo,item.CihazSahibi.MusteriTelNo,item.CihazSahibi.MusteriMail,item.CihazSahibi.MusteriAdres,item.CihazAd,item.CihazModel,item.CihazAriza
                    };
                        var satir = new ListViewItem(sutun);
                        listView1.Items.Add(satir);
                    }
                }

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Ad Soyad", 100);
            listView1.Columns.Add("TC No", 100);
            listView1.Columns.Add("Tel No", 100);
            listView1.Columns.Add("Mail", 100);
            listView1.Columns.Add("Adres", 100);
            listView1.Columns.Add("Cihaz", 100);
            listView1.Columns.Add("Model", 100);
            listView1.Columns.Add("Arıza", 100);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in cihazlar)
            {
                File.AppendAllText("log.txt", item.ToString());
                File.AppendAllText("log.txt", Environment.NewLine);
            }
            MessageBox.Show("Loglama işlemi ile Z raporunuz oluşturulmuştur. Program dosyalarından log.txt aracılığı ile ulaşabilirsiniz... ");
        }
    }
}
