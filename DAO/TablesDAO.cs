using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class TablesDAO : DataProvider
    {
#region
        public List<Tables> GetTable()
        {
            string sql = "SELECT * FROM Tables";
            string name, status;
            int id;
            List<Tables> list = new List<Tables>();
            connection();

            try
            {
                SqlDataReader dr = myExcuteReader(sql);
                while (dr.Read())
                {
                    id = int.Parse(dr[0].ToString());
                    name = dr[1].ToString();
                    status = dr[2].ToString();

                    Tables table = new Tables(id, name,status);
                    list.Add(table);
                }
                dr.Close();
                return list;
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
#endregion

        public DataTable Get()
        {
            string sql = "SELECT * FROM Tables";

            try
            {
                return GetTableShow(sql);
            }
            catch (SqlException ex)
            {                
                throw ex;
            }
        }
        
    }
}
