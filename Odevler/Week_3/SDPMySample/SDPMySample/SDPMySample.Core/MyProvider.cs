using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDPMySample.Core
{
    public class MyProvider
    {
        SqlConnection conn;
        SqlCommand cmd;
        public MyProvider(string cmdText, string connectionstring=null)
        {
            conn = new SqlConnection(connectionstring ==null ? "server=.;Database=NORTHWND;uid=admin;pwd=admin;MultipleActiveResultSets=True" : connectionstring);
            cmd = new SqlCommand(cmdText, conn);
        }
        public void ParametreTanimla(string paramName, object value) {

            cmd.Parameters.AddWithValue(paramName,value);
        }
        void OpenConn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlDataReader MyExecuteReader()
        {
            SqlDataReader rdr;
            try
            {
                OpenConn();
                return cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                //üretilen hatalarıda geriye donsun ?
            }
            CloseConnection();
            return null;
        }
        public int MyExecuteNonquery()
        {
            int donulecekDeger = 0;
            try
            {
                OpenConn();
                //cmd.Parameters.AddWithValue("@c","dajkls");
                donulecekDeger= cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //üretilen hatalarıda geriye donsun ?
            }
            CloseConnection();
            return donulecekDeger;

        }
        public object MyExecuteScalar() {
            object data = null;
            try
            {
                OpenConn();
                data= cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                //üretilen hatalarıda geriye donsun ?
            }
            CloseConnection();
            return data;
        }
    }
}
