using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string Regex_Password = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&#])[A-Za-z0-9@$!%*?&]{8,}$";
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