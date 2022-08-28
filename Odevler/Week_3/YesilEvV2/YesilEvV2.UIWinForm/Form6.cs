using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEvV2.DAL.Concrete;

namespace YesilEvV2.UIWinForm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            AramaGecmisiDAL aramaGecmisiDAL = new AramaGecmisiDAL();
            foreach (var item in aramaGecmisiDAL.AramaGecmisiGetir())
            {
                listBox3.Items.Add(item);
            }

            FavorilerDAL favorilerDAL =new FavorilerDAL();
            foreach (var item in favorilerDAL.Favoriler())
            {
                listBox2.Items.Add(item);
                if (item.FavoriListeID==comboBox1.SelectedItem)
                {
                    listBox2.Items.Add(item.ID);
                }
            }
            FavorListeDAL favorListeDAL = new FavorListeDAL();
            foreach (var item in favorListeDAL.favoriListeGetir())
            {
                comboBox1.Items.Add(item.FavoriListeAdi);
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            FavorilerDAL favorilerDAL = new FavorilerDAL();

            foreach (var item in favorilerDAL.Favoriler())
            {
                if (item.FavoriListeID == comboBox1.SelectedItem)
                {
                    listBox2.Items.Add(item);
                }
            }
        }
    }
}
