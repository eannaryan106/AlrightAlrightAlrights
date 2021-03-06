﻿using System;
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
            using (SqlConnection sqlConn = new SqlConnection(connection))
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

        public int GetLoginId(string username)
        {
            int id = 0;

            string sql = "SELECT LoginID FROM Login WHERE username=@username";

            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@username", username);
                sqlConn.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    id = dataReader.GetInt32(0);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }

            return id;
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

        ///////////////////////////////////////////////
        // Doctors
        public bool UpdateDoctor(Doctor doc)
        {
            bool result = false;
            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand("[dbo].[Update_Doctor_Details]", sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = doc.ID;
                cmd.Parameters.Add("@Forename", SqlDbType.VarChar, 50).Value = doc.FirstName;
                cmd.Parameters.Add("@Surname", SqlDbType.VarChar, 50).Value = doc.LastName;
                cmd.Parameters.Add("@Gender ", SqlDbType.Bit).Value = doc.Gender;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 400).Value = doc.Address;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 50).Value = doc.PhoneNumber;
                cmd.Parameters.Add("@Qualification", SqlDbType.NVarChar, 50).Value = doc.Qualification;
                cmd.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = doc.DepartID;

                sqlConn.Open();

                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            return result;
        }

        public void AddDoctor(int id)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand("[dbo].[Insert_Doctor_ID]", sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                sqlConn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
        }

        public List<int> GetDeptIds() {
            string sql = "SELECT Department_Id FROM DepartmentDetails";
            List<int> listOfDeptId = new List<int>();
            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                sqlConn.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int tempDeptId = dataReader.GetInt32(0);
                    listOfDeptId.Add(tempDeptId);
                }

                sqlConn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            return listOfDeptId;
        }


        public bool InsertPatient(Patient sickboi)
        {
            bool inserted = false;

            //string str = "INSERT INTO PatientDetails (Forename, Surname, DateOfBirth, Gender, Address, PhoneNumber, NextOfKin) " +
            //    "VALUES(@forename, @surname, @dob, @gender, @address, @phone, @kin); ";
            try
            {
                SqlCommand cmd = new SqlCommand("[dbo].[Insert_Patient_Details]", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
               // DateTime test = new DateTime(1999,11,11);
               // Console.WriteLine("DAO DOB: ++++++++++++++++++++++++++ " + test.ToShortDateString() + "\n");

                cmd.Parameters.Add("@Forename", SqlDbType.VarChar).Value = sickboi.FirstName;
                cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = sickboi.LastName;
                cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = sickboi.birth;
                cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = sickboi.Gender;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = sickboi.Address;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = sickboi.PhoneNumber;
                cmd.Parameters.Add("@NextOfKin", SqlDbType.VarChar).Value = sickboi.NextOfKin;

                //cmd.Parameters.Add(new SqlParameter
                //{
                //    ParameterName = "@forename",
                //    Value = sickboi.FirstName,
                //    SqlDbType = System.Data.SqlDbType.VarChar,
                //});
                //cmd.Parameters.Add(new SqlParameter
                //{
                //    ParameterName = "@surname",
                //    Value = sickboi.LastName,
                //    SqlDbType = System.Data.SqlDbType.VarChar,
                //});
                //cmd.Parameters.Add(new SqlParameter
                //{
                //    ParameterName = "@dob",
                //    Value = sickboi.DOB,
                //    SqlDbType = System.Data.SqlDbType.DateTime,
                //});
                //cmd.Parameters.Add(new SqlParameter
                //{
                //    ParameterName = "@gender",
                //    Value = sickboi.Gender,
                //    SqlDbType = System.Data.SqlDbType.Bit,
                //});
                //cmd.Parameters.Add(new SqlParameter
                //{
                //    ParameterName = "@address",
                //    Value = sickboi.Address,
                //    SqlDbType = System.Data.SqlDbType.VarChar,
                //});
                //cmd.Parameters.Add(new SqlParameter
                //{
                //    ParameterName = "@phone",
                //    Value = sickboi.PhoneNumber,
                //    SqlDbType = System.Data.SqlDbType.VarChar,
                //});
                //cmd.Parameters.Add(new SqlParameter
                //{
                //    ParameterName = "@kin",
                //    Value = sickboi.NextOfKin,
                //    SqlDbType = System.Data.SqlDbType.VarChar,
                //});

                sqlConnection.Open();

                int NumRow = cmd.ExecuteNonQuery();
                if (NumRow == 1)
                    inserted = true;
                inserted = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            finally
            {
                sqlConnection.Close();
            }
            return inserted;
        }

        public Doctor GetDoctor(int id)
        {
            string sql = $"SELECT * FROM DoctorDetails WHERE Id=" + id;
            Doctor doc = new Doctor();
            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                sqlConn.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int docId = (int)dataReader["Id"];
                    string forename = (string)dataReader["Forename"];
                    string surname = (string)dataReader["Surname"];
                    bool gender = (bool)dataReader["Gender"];
                    string address = (string)dataReader["Address"];
                    string phoneNumber = (string)dataReader["PhoneNumber"];
                    string qualification = (string)dataReader["Qualification"];
                    int deptId = (int)dataReader["DepartmentId"];

                    if (forename.Equals(string.Empty))
                    {
                        doc = new Doctor(docId);
                    } else
                    {
                        doc = new Doctor(docId, forename, surname, gender, address, phoneNumber, qualification, deptId);
                    }
                }
                sqlConn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            return doc;
        }

        public DataSet GetDoctors(string surname)
        {
            string sql = $"SELECT Surname, Forename, Id, DepartmentId, Qualification FROM DoctorDetails WHERE Surname='{surname}'";
            DataSet dataSet = new DataSet();
            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);

                SqlCommand command = new SqlCommand(sql, sqlConn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                dataAdapter.Fill(dataSet, "DoctorsTable");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            return dataSet;
        }

        public DataSet GetPatients(string surname)
        {
            Console.WriteLine("The surname passed is " + surname);
            DataSet ds = new DataSet();
            string sql = $"SELECT Forename, Surname, PD_ID, DateOfBirth FROM PatientDetails WHERE Surname='{surname}'";

            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.Fill(ds, "PatientsTable");

            } catch (SqlException ex)
            {
                Console.WriteLine("Database error occured " + ex);
            } catch (Exception ex)
            {
                Console.WriteLine("Database error occured " + ex);
            }
            return ds;
        }

        public Patient GetPatientByID(int patientID)
        {
            string sql = $"SELECT * FROM PatientDetails WHERE PD_ID=" + patientID;
            Patient sickboi = new Patient();

            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                sqlConn.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = (int)dataReader["PD_ID"];
                    string forename = (string)dataReader["Forename"];
                    string surname = (string)dataReader["Surname"];
                    DateTime dob = (DateTime)dataReader["DateOfBirth"];
                    string address = (string)dataReader["Address"];
                    bool gender = (bool)dataReader["Gender"];
                    string phoneNumber = (string)dataReader["PhoneNumber"];
                    string kin = (string)dataReader["NextOfKin"];

                    if (forename.Equals(string.Empty))
                    {
                        sickboi = new Patient(id);
                    }
                    else
                    {
                        sickboi = new Patient(forename, surname, dob, address, gender, phoneNumber, kin);
                        //Console.WriteLine($"ID: {id}, Surname: {surname}");
                    }
                }
                sqlConn.Close();
            } catch (SqlException ex)
            {
                Console.WriteLine("Database error");
            } catch (Exception ex)
            {
                Console.WriteLine("Exception");
            }

            return sickboi;
        }
                
    }
}
