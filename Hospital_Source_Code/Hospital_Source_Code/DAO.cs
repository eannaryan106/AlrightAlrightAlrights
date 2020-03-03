using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Assemblies;
using System.Data.SqlClient;
using Hospital_Source_Code.Classes;
using System.Data;
using System.Data.SqlClient;
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

        public bool CheckForAccount(string username)
        {
            bool accountAvailable = false;

            string sql = "SELECT username FROM Login WHERE username=@username";

            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@username", username);
                sqlConn.Open();

                System.Data.DataSet dsUser = new System.Data.DataSet();

                SqlDataAdapter adaptID = new SqlDataAdapter(cmd);
                adaptID.Fill(dsUser);

                sqlConn.Close();

                int count = dsUser.Tables[0].Rows.Count;
                if (count == 0)
                accountAvailable = true;

            } catch (SqlException ex)
            {
                Console.WriteLine("Database error occured " + ex);
                accountAvailable = false;
            }

            return accountAvailable;
        }

        public bool testAddUser(string username, string password, UserRole role)
        {
            bool success = true;

            string sql = "INSERT INTO Login (username, password, UserType) VALUES (@username, @password, @UserType)";

            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@username",
                    Value = username,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                });

                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@password",
                    Value = password,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                });

                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@UserType",
                    Value = role,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                });

                sqlConn.Open();

                int NumRow = cmd.ExecuteNonQuery();
                if (NumRow == 1)
                    success = true;

                success = true;

            } catch (SqlException ex)
            {
                Console.WriteLine("Database error occured " + ex);
                success = false;
            }

            return success;
        }

        public DataSet SearchBills(string field, string @operator, string @value)
        {
            DataSet dataSet = new DataSet();

            string sql = "SELECT * FROM BillingDetails WHERE " +
                        $"{field} {@operator} '{@value}'";

            try
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = sql
                };
                sqlConnection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(dataSet, "BillingTable");
            }
            catch(SqlException ex)
            {
                Console.WriteLine("A DataBase Exception Occurred: " + ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine("A Non Database Exception Occured: " + ex);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            return dataSet;
        }

        public bool InsertBill(Bill bill)
        {
            bool success = false;
            int newId = 0;

            string sql = "INSERT INTO BillingDetails " +
                        "(Date, PatientId, RoomCharge, DoctorsFee, Note, MiscellaneousFee, VisitID, Paid) " +
                        $"VALUES(@Date, @PatientId, @RoomCharge, @DoctorsFee, @Note, @MiscellaneousFee, @VisitID, @Paid)";
                        

            try
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = sql
                };
               

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Date",
                    Value = bill.DateIssued,
                    SqlDbType = SqlDbType.Date        
                });

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@PatientId",
                    Value = bill.PatientId,
                    SqlDbType = SqlDbType.Int
                });

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@RoomCharge",
                    Value = bill.RoomCharge,
                    SqlDbType = SqlDbType.Decimal
                });

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@DoctorsFee",
                    Value = bill.DoctorFee,
                    SqlDbType = SqlDbType.Decimal            
                });

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Note",
                    Value = bill.Note,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 40
                });

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@MiscellaneousFee",
                    Value = bill.MicellFee,
                    SqlDbType = SqlDbType.Decimal
                });

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@VisitID",
                    Value = bill.visitId,
                    SqlDbType = SqlDbType.Int
                });

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Paid",
                    Value = 0,
                    SqlDbType = SqlDbType.Bit
                });

                sqlConnection.Open();

                //newId = int.Parse(command.ExecuteScalar().ToString());
                newId = command.ExecuteNonQuery();
                success = true;


            }
            catch (SqlException ex)
            {
                Console.WriteLine("A Database Exception Occurred: " + ex);
                success = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("A Non Database Exception Occurred: " + ex);
                success = false;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return success;
        }
    }
}
