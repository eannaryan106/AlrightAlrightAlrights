** Outlining the DB requests by each user. **

/* Logins: 

Super User:  */
INSERT AND Delete Login record in Login Table.

/* HR: */
Select, Insert,Update,Delete details to Doctor Table

/* // Admin: //  */
SELECT,INSERT From Reports,
SELECT,INSERT, Update FROM Patient Details Table
SELECT FROM Doctor Details
**GENERATE Reports** Function
**GENERATE BILL** Function
End of Month bill for Patient, with patient Id and bill amount

SELECT FROM Hospital Layout
SELECT ALL PATIENTS WHERE DOCTOR ID = ??

/* Doctor: */

**GENERATE Reports** Function
**GENERATE Test Results** Function
SELECT,INSERT, Upate FROM Patient Details Table
SELECT/INSERT/UPDATE/DELETE FROM Test Results
SELECT FROM Hospital Layout
SELECT/INSERT/UPDATE/DELETE FROM prescriptions



////////////////////////THe Actual Statements/////////////////////////////////

INSERT 

SELECT [password]
      ,[LoginID]
      ,[UserType]
  FROM [HospitalDatabase].[dbo].[Login] 
WHERE username = '" + frmUsername.Text + "' AND password = '" + frmPassword.Text + "'";


////Doctor Select///

SELECT 
      [Forename]
      ,[Surname]
      ,[Photo]
      ,[Gender]
      ,[Address]
      ,[PhoneNumber]
      ,[Qualification]
      ,[DepartmentId]
  FROM [HospitalDatabase].[dbo].[DoctorDetails]
  WHERE [Id]=(?);
  
  
  //Doctor//
  
 UPDATE
USE [HospitalDatabase]
GO

UPDATE [dbo].[DoctorDetails]
   SET [Forename] = (?)
      ,[Surname] = (?)
      ,[Photo] = (?)
      ,[Gender] = (?)
      ,[Address] = (?)
      ,[PhoneNumber] = (?)
      ,[Qualification] = (?)
      ,[DepartmentId] = (?)
 WHERE [ID] = (?)
GO




  
  string connectionString = "datasource=localhost;username=xxx;password=xxx;database=xxx";
MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

string selectString =
"SELECT username, password " +
"FROM Login " +
"WHERE username = '" + frmUsername.Text + "' AND password = '" + frmPassword.Text + "'";

MySqlCommand mySqlCommand = new MySqlCommand(selectString, mySqlConnection);
mySqlConnection.Open();
String strResult = String.Empty;
strResult = (String)mySqlCommand.ExecuteScalar();
mySqlConnection.Close();

if (strResult.Length == 0)
{
Label1.Text = "INCORRECT USER/PASS!"
//could redirect to register page
} else {
Label1.Text = "YOU ARE LOGGED IN!";
//set loggin in sessions variables
}