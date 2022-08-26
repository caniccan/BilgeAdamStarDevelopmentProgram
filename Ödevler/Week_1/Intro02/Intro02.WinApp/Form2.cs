using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro02.WinApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string ifade) : this()
        {

            // this.Text = ifade;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtBilgi.Tag = 896;
            int o = (int)txtBilgi.Tag;
            var hede = int.Parse(txtBilgi.Tag.ToString());

            string deger = "54";
            int donustur = int.Parse(deger);


        }

        public delegate void MyDelegate(List<AnketSonuc>  veriler);
        public MyDelegate delegem;

        private void button1_Click(object sender, EventArgs e)
        {
            //sonucları a l 
            //kaydet
            AnketSonuc anketSonuc = new AnketSonuc();
            anketSonuc.Tarih = DateTime.Now;
            anketSonuc.AnketSonuclari = SonuclariBul();
            girilenAnketler.Add(anketSonuc);

            delegem(girilenAnketler);
        }

        private List<bool> SonuclariBul()
        {           
            bool[] myarray = new bool[5];
            foreach (var item in groupBox1.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox grp = item as GroupBox;
                    foreach (RadioButton rdp in grp.Controls)
                    {
                        if (rdp.Text == "Evet" && rdp.Checked)
                        {
                            myarray[(Convert.ToInt32(rdp.Tag))-1] = true;
                        }
                        else
                        {
                            myarray[(Convert.ToInt32(rdp.Tag))-1] = false;
                        }                        
                    }
                }
            }
            return myarray.ToList();
        }

        List<AnketSonuc> girilenAnketler = new List<AnketSonuc>();

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //delegate 

            
        }
    }
}
