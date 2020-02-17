using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Assemblies;
using System.Data.SqlClient;

namespace Hospital_Source_Code
{
    class DAO
    {
        readonly string connection = System.Configuration.ConfigurationManager.ConnectionStrings["HospitalCon"].ConnectionString;

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
