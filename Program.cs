using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string Regex_Password = "^[A-Z][A-Za-z0-9]{7,}$";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MSTest User Registration Practice Problem");
        }
        public string UserRegister(string password)
        {
            if (Regex.IsMatch(password, Regex_Password) == true)
                return "Valid";
            else
                return "InValid";
        }
    }
}