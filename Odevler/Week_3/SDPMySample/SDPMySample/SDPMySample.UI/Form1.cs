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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyProvider m = new MyProvider("select * from Categories");
            SqlDataReader rdr = m.MyExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    string catName = rdr["CategoryName"].ToString();
                    int categoryID = rdr.GetInt32(0);
                }
            }
            //string deger = "my kategori";
            //MyProvider mp = new MyProvider("insert into Categories(CategoryName) values('"+deger+"')");
            //mp.MyExecuteNonquery();


            string deger = "my kategori";
            MyProvider mp = new MyProvider("insert into Categories(CategoryName) values(@c)");
            mp.ParametreTanimla("@c", deger);
            int donendeger = mp.MyExecuteNonquery();
            //MARS 

            /*
                   
            Mssql ,Oracle, IBMDB2 ,MySQL

            ORM =>  Entity Framework ,Nhibernate

            ADO.NET =>  
            
            1-Connected Mimari => 
                SqlConnection  => 
                SqlCommand 
            2-Disconnected Mimari  => adapter 

            WinForm Console WEb  

             */
        }
        SqlConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {
            Getir();
        }

        private void Getir()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "server=.;Database=Northwind;uid=sa;pwd=123";
            // conn.ConnectionString = "server=.;Database=Northwind;trusted_connection=true";
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "Northwind";
            sb.UserID = "sa";
            sb.Password = "123";
            //conn.ConnectionString = sb.ToString();

            // SqlCommand cmd = new SqlCommand("select * from Shippers",conn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Shippers";
            cmd.CommandType = CommandType.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            listBox1.Items.Clear();
            try
            {
                //int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
                //object tekstunTekkolon = cmd.ExecuteScalar();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        //rdr.GetString(0);
                        //rdr.GetInt64(1);
                        //string s = rdr["CompanyName"].ToString();
                        Shipper s = new Shipper()
                        {
                            ShipperID = Convert.ToInt32(rdr["ShipperID"]),
                            CompanyName = rdr["CompanyName"].ToString(),
                            Phone = rdr["Phone"].ToString()
                        };
                        listBox1.Items.Add(s);
                    }
                }
                else
                {
                    MessageBox.Show("data gelmedi.. ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hata var ");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
        /// <summary>
        /// tran mars 
        /// </summary>
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //validate 
            //MARS=true açık halini yazalım.

            conn = new SqlConnection("server=.;Database=Northwind;uid=sa;pwd=123;");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Shippers(CompanyName,Phone) values(@com,@ph)";
            cmd.Parameters.AddWithValue("@com", txtKargoAdi.Text);
            cmd.Parameters.AddWithValue("@ph", mstTelefon.Text);
            cmd.Connection = conn;

            //SqlCommand cmd02 = new SqlCommand("Select * from Shippers",conn);
            //var deger = cmd02.ExecuteReader();
            try
            {
                conn.Open();
                MessageBox.Show(cmd.ExecuteNonQuery() > 0 ? "veri eklenmiştir" : "bilinmeyen bir sql hatası oluştur..");
                Getir();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("veri eklemedi .");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void Temizle()
        {
            txtKargoAdi.Text = mstTelefon.Text = string.Empty;
        }
    }
}
