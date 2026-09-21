using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArimatikaPenjumlahan.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, apel, hasil = 0;

            Console.Write("mangga = ");
            mangga = int.Parse(Console.ReadLine()); 
            apel = int.Parse(Console.ReadLine());

            // operasi penjumlahan dengan operator +
            hasil = mangga + apel;

            Console.WriteLine($"Hasil mangga + apel = {hasil}");
        }
    }
}
