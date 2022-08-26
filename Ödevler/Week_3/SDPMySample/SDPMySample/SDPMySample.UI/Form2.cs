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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //MultipleActiveResultSets=True
            SqlConnection conn = new SqlConnection("server=.;Database=Northwind;uid=sa;pwd=123;MultipleActiveResultSets=True");
            //todo kontrol ederek conn açılmalı..
            conn.Open();
            using (SqlTransaction tran = conn.BeginTransaction())
            {
                try
                {
                    ////kodlar eren i kaydet eren in adrew e rapor vermesini sağla update et.
                    SqlCommand cmd = new SqlCommand("insert into Employees(FirstName,LastName,City) values('eren','asdasd','izmir')", conn);
                    cmd.Transaction = tran;
                   int deger01= cmd.ExecuteNonQuery();
                    if (deger01 > 0)
                    {
                        SqlCommand cmdBul = new SqlCommand("Select top 1 EmployeeID from Employees order by EmployeeID desc", conn);
                        cmdBul.Transaction = tran;
                        object bulunanSonID = cmdBul.ExecuteScalar();
                        if (bulunanSonID != null)
                        {
                            SqlCommand cmd01 = new SqlCommand("update Employees set ReportsTo=2 where EmployeeID=@id", conn);
                            cmd01.Parameters.AddWithValue("@id", bulunanSonID);
                            cmd01.Transaction = tran;
                            int deger02 = cmd01.ExecuteNonQuery();
                            //todo deger 2 kontrolü ? 
                        }
                        else
                        {
                            throw new Exception("askdlasdlaskjd");                        
                        }
                    }
                    else
                    {
                        throw new Exception("bulunamadı..");
                    } 
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                }
                finally
                {
                    conn.Close();
                }

                //tran.Dispose();
            }

        }
    }
}
