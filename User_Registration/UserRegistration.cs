using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class UserRegistration
    {
        public static void LastName()
        {
            string LastName;
            var regex = "^[A-Z]{1}[a-z]{3,}$";
            Console.WriteLine("Enter a Last Name");
            LastName = Console.ReadLine();
            bool result =Regex.IsMatch(LastName, regex);
            if (result)
            {
                Console.WriteLine("{0} is valid LastName", LastName);
            }
            else
                Console.WriteLine("{0} is invalid LastName", LastName);
        }
    }
}
