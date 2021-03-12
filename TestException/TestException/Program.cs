using System;
using System.Collections.Generic;

namespace TestException
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = @"Persist Security Info=False; Integrated Security=True; Initial Catalog= Cinema; Server=.\SQLEXPRESS";
            //string connectionStringWrong = @"Persist Security Info=False; Integrated Security=True; Initial Catalog= Cinema; Server=.\SQLEdXPRESS";

            //ExceptionDatabase.RunConnessione(connectionString);
            //ExceptionDatabase.RunConnessione(connectionStringWrong);



            string user = "Antonio";
            string user2 = "Anna";
            SearchUser.Run(user);
            SearchUser.Run(user2);





        }
    }
}
