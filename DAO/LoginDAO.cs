using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class LoginDAO : DataProvider
    {
        public bool Login(Account acc)
        {
            string str = "SELECT COUNT(UserName) FROM Users WHERE UserName = '" + acc.Username + "' AND Password = '" + acc.Password + "'";
            int number;
            try
            {
                number = MyExecuteScalar(str);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public List<Account> GetAccount()
        {
            string sql = "SELECT * FROM Users";
            string username, pass;
            int type;

            List<Account> list = new List<Account>();
            connection();

            try 
	        {	        
		        SqlDataReader dr = myExcuteReader(sql);
                    while(dr.Read())
                    {
                        username = dr[0].ToString();
                        pass = dr[1].ToString();
                        type = int.Parse(dr[2].ToString());

                        Account account = new Account(username,pass,type);
                        list.Add(account);
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

        public int AddAccount(Account account)
        {
            string sql = "INSERT INTO Users VALUES(@UserName,@Password,@Type)";

            List<SqlParameter> parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@UserName", account.Username));
            parameter.Add(new SqlParameter("@Password", account.Password));
            parameter.Add(new SqlParameter("@Type", account.Type));
            try
            {
                return MyExcutenNoneQuery(sql, parameter);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int EditAccount(Account account)
        {
            string sql = "UPDATE Users SET Username = @UserName, Password = @Password , Type = @Type WHERE Username = @UserName";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@UserName", account.Username));
            Parameters.Add(new SqlParameter("@Password", account.Password));
            Parameters.Add(new SqlParameter("@Type", account.Type));

            try
            {
                return MyExcutenNoneQuery(sql, Parameters);
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

        



    }
}
