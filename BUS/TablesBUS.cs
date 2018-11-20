using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public class TablesBUS
    {
        TablesDAO tablesDao = new TablesDAO();
 #region

        public List<Tables> GetTable()
        {
            try
            {
                return tablesDao.GetTable();
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
 #endregion

        public DataTable Get()
        {
            try
            {
                return tablesDao.Get();
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
    }
}
