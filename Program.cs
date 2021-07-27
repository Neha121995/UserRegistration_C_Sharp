using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string Regex_Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MSTest User Registration Practice Problem");
        }
        public string UserRegister(string email)
        {
            if (Regex.IsMatch(email, Regex_Email) == true)
                return "Valid";
            else
                return "InValid";
        }
    }
}