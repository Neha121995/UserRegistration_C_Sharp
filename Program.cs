using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string Regex_LName = "^[A-Z]{1}[A-Za-z]{2,}$";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MSTest User Registration Practice Problem");
        }
        public string UserRegister(string lastName)
        {
            if (Regex.IsMatch(lastName, Regex_LName) == true)
                return "Valid";
            else
                return "InValid";
        }
    }
}