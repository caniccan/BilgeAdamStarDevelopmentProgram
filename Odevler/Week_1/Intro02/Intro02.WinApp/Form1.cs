using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro02.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           // MyClass c = new MyClass()
        
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form2 f = new Form2("melike");
        //    f.txtBilgi.Text = "melike";
        //    f.Show();
        //}

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.delegem = new Form2.MyDelegate(Hede);
            f.Show();

            f.Tag = 55f;
        }
        List<AnketSonuc> gonderilecekAnketler = new List<AnketSonuc>();
        void Hede(List<AnketSonuc> sonuclar)
        {

            gonderilecekAnketler.AddRange(sonuclar);
        
        }

        private void sonuclarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            Form3 f = new Form3(gonderilecekAnketler);
            f.MdiParent = this;
            f.Show();

        }
    }
}
