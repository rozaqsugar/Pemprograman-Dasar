using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikaSisabagi.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, apel, hasil = 0;

            Console.Write("mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.WriteLine("apel = ");
            apel = int.Parse(Console.ReadLine());

            // Bisa di ganti dengan yang lainnya (+, -, *, %)
            hasil = mangga % apel;

            Console.WriteLine($"Hasil mangga % apel = {hasil}");
        }
    }
}
