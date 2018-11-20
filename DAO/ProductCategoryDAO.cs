using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ProductCategoryDAO : DataProvider
    {
        public List<ProductCategory> GetProductCategory()
        {
            string sql = "SELECT * FROM ProductCategory ";
            int id;
            string name;

            List<ProductCategory> list = new List<ProductCategory>();
            connection();

            try
            {
                SqlDataReader dr = myExcuteReader(sql);
                while (dr.Read())
                {
                    id = int.Parse(dr[0].ToString());
                    name = dr[1].ToString();

                    ProductCategory productCategory = new ProductCategory(id, name);
                    list.Add(productCategory);
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

        public int AddCategory(ProductCategory productCategory)
        {
            string sql = "INSERT INTO ProductCategory VALUES(@id,@name)";

            List<SqlParameter> parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@id", productCategory.Id));
            parameter.Add(new SqlParameter("@name", productCategory.Name));
            try
            {
                return MyExcutenNoneQuery(sql, parameter);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteCategory(string id)
        {

            string sql = "DELETE FROM ProductCategory WHERE id =@id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", id));

            try
            {
                return MyExcutenNoneQuery(sql, Parameters);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int EditCategory(ProductCategory productCategory)
        {
            string sql = "UPDATE Product SET name = @name WHERE id = @id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", productCategory.Id));
            Parameters.Add(new SqlParameter("@name", productCategory.Name));
            try
            {
                return MyExcutenNoneQuery(sql, Parameters);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
