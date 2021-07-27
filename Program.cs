using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string Regex_MobileNumber = "^[0-9]{2}[ ][1-9]{1}[0-9]{9}$";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MSTest User Registration Practice Problem");
        }
        public string UserRegister(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, Regex_MobileNumber) == true)
                return "Valid";
            else
                return "InValid";
        }
    }
}