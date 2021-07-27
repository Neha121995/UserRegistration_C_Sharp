using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string Regex_FName = "^[A-Z]{1}[A-Za-z]{2,}$";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MSTest User Registration Practice Problem");
        }
        public string UserRegister(string firstName)
        {
            if (Regex.IsMatch(firstName, Regex_FName) == true)
                return "Valid";
            else
                return "InValid";
        }
    }
}