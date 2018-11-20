using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ProductDAO : DataProvider
    {
        public List<Product> GetProduct()
        {
            string sql = "SELECT * FROM Product";
            string id, name, supplierId;
            float purchasePrice, sellingPrice;
            int categoryId;
            List<Product> list = new List<Product>();
            connection();

            try
            {
                SqlDataReader dr = myExcuteReader(sql);
                while (dr.Read())
                {
                    id = dr[0].ToString();
                    name = dr[1].ToString();
                    purchasePrice = float.Parse(dr[2].ToString());
                    sellingPrice = float.Parse(dr[3].ToString());
                    categoryId = int.Parse(dr[4].ToString());
                    supplierId = dr[5].ToString();

                    Product product = new Product(id, name, purchasePrice, sellingPrice, categoryId, supplierId);
                    list.Add(product);
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


        public int Add(Product product)
        {
            string sql = "INSERT INTO Product VALUES(@id,@name,@purchasePrice,@sellingPrice,@categoryId,@supplierId)";

            List<SqlParameter> parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@id", product.Id));
            parameter.Add(new SqlParameter("@name", product.Id));
            parameter.Add(new SqlParameter("@purchasePrice", product.purchasePrice));
            parameter.Add(new SqlParameter("@sellingPrice", product.sellingPrice));
            parameter.Add(new SqlParameter("@categoryId", product.categoryId));
            parameter.Add(new SqlParameter("@supplierId", product.supplierId));
            try
            {
                return MyExcutenNoneQuery(sql, parameter);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Delete(string id)
        {
            
            string sql = "DELETE FROM Product WHERE id =@id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id",id));

            try
            {
                return MyExcutenNoneQuery(sql,Parameters);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Edit(Product product)
        {
            string sql = "UPDATE Product SET name = @name, purchasePrice = @purchasePrice, sellingPrice = @sellingPrice, categoryId = @categoryId, supplierId = @supplierId WHERE id = @id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", product.Id));
            Parameters.Add(new SqlParameter("@name", product.Name));
            Parameters.Add(new SqlParameter("@purchasePrice", product.purchasePrice));
            Parameters.Add(new SqlParameter("@sellingPrice", product.sellingPrice));
            Parameters.Add(new SqlParameter("@categoryId", product.categoryId));
            Parameters.Add(new SqlParameter("@supplierId", product.supplierId));


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
