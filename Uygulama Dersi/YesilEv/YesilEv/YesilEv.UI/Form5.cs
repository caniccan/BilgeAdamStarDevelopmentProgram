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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (YesilEvEntities db = new YesilEvEntities())
            {
                foreach (var item in db.Uruns.ToList())
                {
                    if (item.UrunAdi.Contains(textBox1.Text))
                    {
                        listBox1.Items.Add(item.UrunAdi);
                    }
                }
            }
        }

        private void favoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems!=null)
            {
                using (YesilEvEntities db = new YesilEvEntities())
                {
                    foreach (var item in db.Uruns.ToList())
                    {
                        if (item.UrunAdi==listBox1.SelectedItem.ToString())
                        {
                            Repo<Favoriler> repo = new Repo<Favoriler>();
                            Favoriler favoriler = repo.Insert(new Favoriler()
                            {
                                ID = 0,
                                
                                
                                
                            });
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ürün seçiniz...");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
