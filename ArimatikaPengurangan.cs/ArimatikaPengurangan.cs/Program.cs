using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArimatikaPengurangan.cs
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

            hasil = mangga - apel;

            Console.WriteLine($"Hasil manggga - apel = {hasil}");
        }
    }
}
