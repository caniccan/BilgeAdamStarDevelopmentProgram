using SDPMySample.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDPMySample.UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Modeller tanımla => kat ve ürün için 
            //formu ayaklandıralım => lst combo
            //urune tıklanınca detay alanını doldur. 
            //ara butonuna basılınca db den aratalım ? urun adına göre .
            //kategori seçilirse urunleri kategorisine gore filtrelyelim.
            //filtreleri kaldır dendiğinde form ilk açıldıgı hale gelsin. 
            string sorgu = "select p.ProductID as UrunID,p.CategoryID as KategoriID,p.ProductName as UrunAdi,p.SupplierID as TedarikciID,p.UnitPrice as UrunFiyati," +
                "p.UnitsInStock as Stok,c.CategoryName KategoriAdi,s.CompanyName as SirketAdi from Products p inner join Suppliers s on s.SupplierID = p.SupplierID  " +
                "inner join Categories c on c.CategoryID = p.CategoryID";
            Doldur(sorgu);


        }
        List<Urun> listem=new List<Urun>();
        private void Doldur(string sorgu)
        {
            MyProvider db = new MyProvider(sorgu);
            //List<Urun> listem = new List<Urun>();          
            SqlDataReader rdr = db.MyExecuteReader();
            listem.Clear();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Urun u = new Urun()
                    {
                        ID = rdr.GetInt32(0),
                        //todo null durumunda c# 9.0 ve üzerinde ne yapılır ?
                        Fiyat = Convert.ToDecimal(rdr["UrunFiyati"]),
                        Kategori = new Kategori()
                        {
                            ID = Convert.ToInt32(rdr["KategoriID"]),
                            KategoriAdi = rdr["KategoriAdi"].ToString()
                            

                        },
                        StokMiktari = Convert.ToInt16(rdr["Stok"]),
                        Ureticisi = new Tedarikci()
                        {
                            ID = Convert.ToInt32(rdr["TedarikciID"]),
                            TedarikciAdi = rdr["SirketAdi"].ToString()
                        },
                        UrunAdi = rdr["UrunAdi"].ToString()
                    };
                    listem.Add(u);
                    listBox1.Items.Add(u);
                    
                }
            }
            else
            {
                MessageBox.Show("data gelmedi.. ");
            }

            
            foreach (var item in listem)
            {
                if (!(comboBox1.Items.Contains(item.Kategori.KategoriAdi.ToString())))
                {                                                                                       //combobox içine kategorileri yazdırdık.
                    comboBox1.Items.Add(item.Kategori.KategoriAdi.ToString());
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kategori = comboBox1.SelectedItem.ToString();

            string sorgu = $"select p.ProductID as UrunID,p.CategoryID as KategoriID,p.ProductName as UrunAdi,p.SupplierID as TedarikciID,p.UnitPrice as UrunFiyati," +
                "p.UnitsInStock as Stok,c.CategoryName KategoriAdi,s.CompanyName as SirketAdi from Products p inner join Suppliers s on s.SupplierID = p.SupplierID  " +
                $"inner join Categories c on c.CategoryID = p.CategoryID where CategoryName='{kategori}'";


            
            // seçilen kategoriye göre yeni sorgumuz belirleniyor ve buna göre de doldur() methodu tekrar çalıştırılarak o kategoriye ait ürünler listeleniyor.
            listBox1.Items.Clear();

            Doldur(sorgu);

            //foreach (var item in listem)
            //{
            //    if (item.Kategori.KategoriAdi==comboBox1.SelectedItem.ToString())                    // bu şekilde kolayca yapılabilirdi fakat yukarıdaki yolu pekiştirmek için kullandım.
            //    {
            //        listBox1.Items.Add(item);
            //    }
            //}


            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetayDoldur(listBox1.SelectedItem.ToString());
        }

        private void DetayDoldur(string selectedItem)
        {
            MyProvider db = new MyProvider("select p.ProductName as UrunAdi,p.UnitsInStock as stok,p.UnitPrice as fiyat,c.CategoryName as kategori,s.CompanyName as SirketAdi  from Products p inner join Categories c on c.CategoryID = p.CategoryID inner join Suppliers s on s.SupplierID = p.SupplierID");
            SqlDataReader rdr = db.MyExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    if (selectedItem == rdr["UrunAdi"].ToString())
                    {
                        label4.Text = rdr["stok"].ToString();                      //listbox da seçilen ürünün istenilen özellikleri detay bölümünde gösteriliyor.
                        label6.Text = rdr["fiyat"].ToString();
                        label8.Text = rdr["kategori"].ToString();
                        label10.Text = rdr["SirketAdi"].ToString();
                    }                   
                }
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in listem)
            {
                if (!(comboBox1.SelectedItem == null))
                {
                    if (item.Kategori.KategoriAdi.ToString().ToLower() == comboBox1.SelectedItem.ToString().ToLower() && item.UrunAdi.ToString().ToLower().Contains(textBox1.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
                else
                {
                    if (item.UrunAdi.ToString().ToLower().Contains(textBox1.Text) && !(listBox1.Items.Contains(item.UrunAdi.ToString().ToLower())))
                    {
                        listBox1.Items.Add(item.UrunAdi.ToString());
                    }
                }
            }
            
            // kategorinin seçili olup olmaması durumlarına göre arama işlemi yapılıyor.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (var item in groupBox1.Controls)
            //{
            //    if (item.GetType().Equals(typeof(Label)))
            //    {
            //        Label l1 = item as Label;
            //        l1.Text = "-";
            //    }
            //}
            Application.Restart();
        }
    }
}
