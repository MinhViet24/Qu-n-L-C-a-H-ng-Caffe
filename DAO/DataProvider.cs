using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        SqlConnection cn;

        public DataProvider()
        {
            string cnStr = "Data Source=ADMIN-PC\\TIACHOP;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
            cn = new SqlConnection(cnStr);
        }
        public void connection()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public void disconnection()
        {
            if (cn != null && cn.State == System.Data.ConnectionState.Open)
                cn.Close();
        }
        public int MyExecuteScalar(string str)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = str;
            cmd.CommandType = System.Data.CommandType.Text;
            connection();

            try
            {
                int number = (int)cmd.ExecuteScalar();

                return number;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                disconnection();
            }
        }
        public SqlDataReader myExcuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;

            try
            {
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int MyExcutenNoneQuery(string sql, List<SqlParameter> parameters) //(string sql,CommandType type , List<SqlParameter> parameters) 
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;//type
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
            }

            connection();

            try
            {
                int numberOfRows = cmd.ExecuteNonQuery();
                return numberOfRows;
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {
                disconnection();
            }


        }
        public DataTable GetTableShow(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();

            try
            {
                int numberOfRows = da.Fill(dt);
                if (numberOfRows > 0)
                {
                    return dt;
                }
                else
                    return null;
            }
            catch (SqlException ex)
            {                
                throw ex;
            }

        }
     
    }
}
