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
        public static void FirstName()
        {
            string FirstName;
            var regex = "^[A-Z]{1}[a-z]{3,}$";
            Console.WriteLine("Enter a First Name");
            FirstName = Console.ReadLine();
            bool result =Regex.IsMatch(FirstName, regex);
            if (result)
            {
                Console.WriteLine("{0} is valid firstName",FirstName);
            }
            else
                Console.WriteLine("{0} is invalid firstName",FirstName);
        }
    }
}
