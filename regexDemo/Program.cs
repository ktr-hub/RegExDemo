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
            Console.Write("Enter PIN code : ");
            string input = Console.ReadLine();
            string sampleRegex = "^[0-9]{6}$";

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
        }
    }
}
