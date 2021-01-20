using System;
using System.Linq;

namespace PasswordMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please imput a character meeting the following conditions:");
            Console.WriteLine("1) Must be more than 8 characters");
            Console.WriteLine("2) Must not be <null>");
            Console.WriteLine("3) Must contain at least 1 uppercase");
            Console.WriteLine("4) Must contain at least 1 lowercase");
            Console.WriteLine("5) Must contain at least 1 digit");
            string password =  Console.ReadLine();

            bool longEnough = IsLongEnough(password);
            Console.WriteLine("Greater than 8 characters: " +longEnough );

            bool isntNull = IsNotNull(password);
            Console.WriteLine("The password is not <null>: " + isntNull);

            bool hasUpperCase = HasUpper(password);
            Console.WriteLine("Has at least 1 uppercase: " + hasUpperCase);

            bool hasLowerCase = HasLower(password);
            Console.WriteLine("Has at least 1 lowercase: " + hasLowerCase);

            bool hasNumber = HasNum(password);
            Console.WriteLine("Has at least 1 number: " + hasNumber);
        }
        public static bool IsLongEnough(string input)
        {
            int len = input.Length;
        if(len > 8)
            { return true; }
        else
            { return false; }
                
          }
        public static bool IsNotNull(string input)
        {
            if (input != "" && input != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool HasUpper(string input)
        {
            if (input.Any(char.IsUpper))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool HasLower(string input)
        {
            if (input.Any(char.IsLower))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool HasNum(string input)
        {
            if (input.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }


}
