using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogika.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Password: ");
            string password = Console.ReadLine();

            bool isAdult = age > 18; // pertanyaan 1
            bool isPasswordValid = password == "admin";

            // menggunakan logika AND
            if (isAdult && isPasswordValid)
            {
                Console.WriteLine("WELCOME TO THE CLUB!"); ;
            }
            else
            {
                Console.WriteLine("Sorry, try again!");
            }
        }
    }
}
