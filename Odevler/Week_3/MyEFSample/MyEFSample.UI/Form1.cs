using MyEFSample.UI.DAL;
using MyEFSample.UI.DAL.Repo;
using MyEFSample.UI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEFSample.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                foreach (var item in db.Categories.ToList())
                {
                    comboBox1.Items.Add(item.CategoryName);
                }
            }
        }

        List<Product> urunListesi = new List<Product>();
        private void UrunleriGetir()
        {
            listBox1.Items.Clear();
            using (NorthwindEntities db = new NorthwindEntities())
            {
                
                var gelenVeri = db.Products.ToList();
                foreach (var item in gelenVeri)
                {
                    listBox1.Items.Add(item.ProductName);
                    urunListesi.Add(item);

                }
                //foreach (var item in db.Categories.ToList())
                //{                                                                         // ürünleri getirirken fazladan bir foreach ile kategorileri de getirilebilirdi.
                //    comboBox1.Items.Add(item.CategoryName);                               // fakat pekiştirmek amaçlı ayrı bir method ile getirildi.
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!listBox2.Items.Contains(listBox1.SelectedItem))
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            using (NorthwindEntities db =new NorthwindEntities())
            {
                var sorgu = (from p in db.Products                                          //combobox tan bir kategori seçildiğinde o kategoriye ait ürünler listeleniyor.
                             join c in db.Categories on p.CategoryID equals c.CategoryID
                             where c.CategoryName == comboBox1.SelectedItem.ToString() select p  
                             );

                foreach (var item in sorgu)
                {
                    listBox1.Items.Add(item.ProductName);
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in urunListesi)
            {
                if (item.ProductName==listBox1.SelectedItem.ToString())
                {
                    label5.Text = item.UnitPrice.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            List<OrderDetailsDTO> detailsList=new List<OrderDetailsDTO>();

            

            foreach (var item in listBox2.Items)
            {
                foreach (var item2 in urunListesi)
                {
                    if (item.ToString()==item2.ProductName)
                    {
                        
                        OrderDTO orderDTO = new OrderDTO()
                        {
                            OrderDate = DateTime.Now,
                            OrderID = 0,
                            ShipAddress = textBox3.Text,
                            ShipCity = textBox2.Text,
                            ShipName = textBox4.Text
                        };
                        OrderDetailsDTO detailsDTO = new OrderDetailsDTO()
                        {
                            Discount = 0,
                            OrderID = 0,
                            ProductID = item2.ProductID,
                            UnitPrice = Convert.ToDecimal(item2.UnitPrice)
                        };
                        detailsList.Add(detailsDTO);
                        SatisDAL dal = new SatisDAL();
                        if (dal.SatisYap(null,null))
                        {
                            MessageBox.Show("hata2");
                        }
                        else
                        {
                            dal.SatisYap(orderDTO, detailsList);
                        }

                        

                    }
                }
            }

        
    }
    }
}
