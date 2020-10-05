using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace regexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to validate pin and email");
            Console.Write("Enter PIN code : ");
            string input = Console.ReadLine();
            string sampleRegex = "^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$";

            Regex rg = new Regex(sampleRegex);
            Boolean result = rg.IsMatch(input);
            if (result)
            {
                Console.WriteLine("Valid PIN");
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }

            Console.WriteLine("Enter an Email : ");
            String email = Console.ReadLine();

            string pattern = @"^[a-z][a-z0-9]*([_+-.][a-z0-9]+)?@([a-z0-9]{1,}[.]){1,2}[a-z]{2,}$";
            Regex reg = new Regex(pattern);

            if (reg.IsMatch(email))
            {
                Console.WriteLine("Valid email\n");
            }
            else
            {
                Console.WriteLine("Invalid email\n");
            }

        }
    }
}
