using System;
using System.Collections.Generic;
using System.Text;

namespace TestException
{
   public class SearchUser
    {
    


    public static bool IfContains(List<string> users, string user)
    {


            try
            {
                if (!users.Contains(user))
                    throw new UserNotFoundException("User not found: ");
            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.Message + user);
                return false;
            }
            catch (Exception e)
            {
            Console.WriteLine(e.Message);
            return false;
            }

        return true;
    }





        public static void Run(string user)
    {

            List<string> users = new List<string> { "Anna", "Mario", "Marco", "Matteo" };

            if (IfContains(users, user)) Console.WriteLine("User " + user + " found");



        }


}
}
