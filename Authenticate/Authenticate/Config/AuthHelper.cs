using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticate.Config
{
   public  class AuthHelper
    {
        private static Dictionary<string, string> dict = new Dictionary<string, string>();
        public static void AddUser(string username,string password)
        {
           // dict.Add("Ruchi", "101");
           dict.Add(username, password);

        }
        public static bool Check(string username, string password)
        {
            // if(dict.ContainsKey("username")
            for (int i = 0; i < dict.Count; i++)
            {

                if (dict.Keys.ElementAt(i) == username)
                {
                    if (dict[username] == password)
                     //   Console.WriteLine("match");
                    return true;
                }
            }
          //  Console.WriteLine("try again");
            return false;
        }

          
          
    }
    
}
