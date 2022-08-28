using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YesilEvV2.UIWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.StartPosition = FormStartPosition.CenterScreen;
            form3.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.StartPosition = FormStartPosition.CenterScreen;
            form4.Show();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            Form5 form5 = new Form5();
            form5.MdiParent = this;
            form5.StartPosition = FormStartPosition.CenterScreen;
            form5.Show();
 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            Form6 form6 = new Form6();
            form6.MdiParent = this;
            form6.StartPosition = FormStartPosition.CenterScreen;
            form6.Show();
        }
    }
}
