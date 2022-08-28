using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEvV2.Core.Context;
using YesilEvV2.Core.Entities;
using YesilEvV2.Core.Repos;
using YesilEvV2.DAL;
using YesilEvV2.DAL.Concrete;

namespace YesilEvV2.UIWinForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4(textBox1.Text);
            Form2 form2 = new Form2();
            form4.StartPosition = FormStartPosition.CenterScreen;
            form4.Show();
            //this.Hide();


            
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
