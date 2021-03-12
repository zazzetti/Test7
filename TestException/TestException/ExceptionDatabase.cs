using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TestException
{



    public static class ExceptionDatabase
    {

        public static bool IfExists(SqlConnection conn)
        {
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        



        public static void RunConnessione(string connectionString)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (IfExists(connection))
                {
                    Console.WriteLine("Andata a buon fine");
                }
                else Console.WriteLine("Non andata a buon fine");
            }


            }

        
    }

}

