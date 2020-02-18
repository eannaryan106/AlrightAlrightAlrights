using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Assemblies;
using System.Data.SqlClient;
using Hospital_Source_Code.Classes;
using System.Data;

namespace Hospital_Source_Code
{
    class DAO
    {
        private readonly string connection = System.Configuration.ConfigurationManager.ConnectionStrings["HospitalCon"].ConnectionString;
        private readonly SqlConnection sqlConnection;

        public DAO()
        {
            sqlConnection = new SqlConnection
            {
                ConnectionString = connection
            };
        }

        public LoginModel GetLogin(string username, string password)
        {
            LoginModel login = new LoginModel();

            try
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "SELECT * FROM Login"
                };
                sqlConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    LoginModel newLogin = new LoginModel((string)dataReader["username"], (string)dataReader["password"], (int)dataReader["LoginID"], 
                        (string)dataReader["UserType"]);
                    if (newLogin.Username.Equals(username) && newLogin.Password.Equals(password))
                    {
                        login = newLogin;
                        //Console.WriteLine(newLogin.Username);
                        //Console.WriteLine(newLogin.UserType);
                        break;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                sqlConnection.Close();
            }

            return login;
        }

        public bool CheckLoginExist(string username)
        {
            bool exist = false;

            try
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "SELECT * FROM Login WHERE username=" + username
                };
                sqlConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string newExist = (string)dataReader["username"];
                    if (newExist.Equals(username))
                    {
                        exist = true;
                        break;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                sqlConnection.Close();
            }

            return exist;
        }

        public void testCon() {
            using(SqlConnection sqlConn = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE LoginID=1000", sqlConn);

                try
                {
                    sqlConn.Open();
                    var newID = cmd.ExecuteScalar();
                    Console.WriteLine("It connected no issues " + newID);
                }
                catch (SqlException ex)
                {

                    Console.WriteLine(ex);
                }


            }
            
        }        
    }
}
