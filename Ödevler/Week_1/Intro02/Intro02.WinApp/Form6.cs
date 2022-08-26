using Intro02.WinApp.Models;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public delegate void MyDelege(Musteri musteri);
        public MyDelege delegem;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (ValidationKontrol())
            {

                Musteri m = new Musteri()
                {
                    Adress = txtAdres.Text,
                    MusteriAdi = txtAd.Text
                };
                delegem(m);

            }
            else
            {
                MessageBox.Show("veri griniz. ");
            }

            
        }

        private bool ValidationKontrol()
        {
            return true;
        }
    }
}
