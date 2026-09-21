using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasLingkaran.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat konstanta

            const float Phi = 3.14f;

            Console.WriteLine("== PROGRAM LUAS LINGKUNGAN ==");
            Console.Write("Input jari-jari: ");
            int r = int.Parse(Console.ReadLine());

            var luas = Phi * r * r;

            Console.WriteLine($"Luas Lingkaran = {luas}");

        }
    }
}
