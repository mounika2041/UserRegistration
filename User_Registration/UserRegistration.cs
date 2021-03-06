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
            bool result = Regex.IsMatch(FirstName, regex);
            if (result)
            {
                Console.WriteLine("{0} is valid firstName", FirstName);
            }
            else
                Console.WriteLine("{0} is invalid firstName", FirstName);
        }
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
        public static void validateEmail()
        {
            string EmailId;
            var regex = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Console.WriteLine("Enter a EmailId");
            EmailId = Console.ReadLine();
            bool result = Regex.IsMatch(EmailId, regex);
            if (result)
            {
                Console.WriteLine("{0} is valid EmailId", EmailId);
            }
            else
                Console.WriteLine("{0} is invalid EmailId", EmailId);
        }
        public static void mobileNumber()
        {
            string mobileNumber;
            var regex = @"^[0-9]{2}[\s][0-9]{10}$";
            Console.WriteLine("Enter a mobileNumber");
            mobileNumber = Console.ReadLine();
            bool result = Regex.IsMatch(mobileNumber, regex);
            if (result)
            {
                Console.WriteLine("{0} is valid mobileNumber", mobileNumber);
            }
            else
                Console.WriteLine("{0} is invalid mobileNumber", mobileNumber);
        }
        public static void ValidatePassword()
        {
            string Password;
            var regex = "^[a-zA-Z0-9]{8,}$";
            Console.WriteLine("Enter a Password");
            Password = Console.ReadLine();
            bool result = Regex.IsMatch(Password, regex);
            if (result)
            {
                Console.WriteLine("{0} is valid Password", Password);
            }
            else
                Console.WriteLine("{0} is invalid Password", Password);
        }
    }
}
