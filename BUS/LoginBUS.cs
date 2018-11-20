using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class LoginBUS
    {
        LoginDAO loginDao = new LoginDAO();

        public bool Login(Account acc)
        {

            try
            {
                return new LoginDAO().Login(acc);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public List<Account> GetAccount()
        {
            try
            {
                return new LoginDAO().GetAccount();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int AddAccount(Account account)
        {
            try
            {
                return loginDao.AddAccount(account);
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        public int EditAccount(Account account)
        {
            try
            {
                return new LoginDAO().EditAccount(account);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        

    }


}
