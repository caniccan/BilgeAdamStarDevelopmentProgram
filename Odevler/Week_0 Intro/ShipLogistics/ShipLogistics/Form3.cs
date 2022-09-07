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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<Gemi> gemiler, List<Yuk> yukler) : this()
        {
            Gemiler = gemiler;
            Yukler = yukler;
        }

        public List<Gemi> Gemiler { get; }
        public List<Yuk> Yukler { get; }

        private void button1_Click(object sender, EventArgs e)
        {

            listViewClear();
            YukColumn();

            foreach (var item in Yukler)
            {
                if (item.YukCinsi==textBox1.Text)
                {
                    string[] sutun =
                    {
                        item.YukSahibi,item.YukCinsi,item.YukAgırlık.ToString(),item.MevcutKonum,item.HedefKonum,item.Tarih
                    };
                    var satir=new ListViewItem(sutun);
                    listView1.Items.Add(satir);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listViewClear();
            GemiColumn();
            foreach (var item in Gemiler)
            {
                string _guzergah = item.Konum + " " + item.Guzergah_1 + " " + item.Guzergah_2 + " " + item.Konum;
                string[] sutun =
                {
                    item.GemiAdı,item.MaxTon.ToString(),item.Konum,_guzergah,item.Tarih
                };
                var satir = new ListViewItem(sutun);
                listView1.Items.Add(satir);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listViewClear();
            GemiColumn();
            
            foreach (var item in Gemiler)
            {
                if (item.Konum==textBox2.Text)
                {
                    string _guzergah = item.Konum + " " + item.Guzergah_1 + " " + item.Guzergah_2 + " " + item.Konum;
                    string[] sutun =
                    {
                    item.GemiAdı,item.MaxTon.ToString(),item.Konum,_guzergah,item.Tarih
                    };
                    var satir = new ListViewItem(sutun);
                    listView1.Items.Add(satir);
                }
            }
            

        }

        private void GemiColumn()
        {
            listView1.Columns.Add("Gemi Adı", 100);
            listView1.Columns.Add("Limit (Ton)", 100);
            listView1.Columns.Add("Konum", 100);
            listView1.Columns.Add("Güzergah", 100);
            listView1.Columns.Add("Tarih", 100);
        }

        private void listViewClear()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
        }

        private void YukColumn()
        {
            listView1.Columns.Add("Yük Sahibi", 100);
            listView1.Columns.Add("Yük Cinsi", 100);
            listView1.Columns.Add("Yük Ağırlığı (Ton)", 100);
            listView1.Columns.Add("Mevcut Konum", 100);
            listView1.Columns.Add("Hedef Konum", 100);
            listView1.Columns.Add("Tarih", 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listViewClear();
            GemiColumn();

            foreach (var item in Gemiler)
            {
                string _guzergah = item.Konum + " " + item.Guzergah_1 + " " + item.Guzergah_2 + " " + item.Konum;
                if (_guzergah.Contains(textBox3.Text))
                {
                    string[] sutun =
                    {
                    item.GemiAdı,item.MaxTon.ToString(),item.Konum,_guzergah,item.Tarih
                    };
                    var satir = new ListViewItem(sutun);
                    listView1.Items.Add(satir);
                }
            }
        }
    }
}
