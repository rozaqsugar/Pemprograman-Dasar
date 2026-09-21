using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPenugasan.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // menggunakan operator = untuk mengisi nilai
            int mangga = 10;
            int apel = 8;

            // mengisi ulang nilai variabel mangga
            mangga = 15;

            Console.WriteLine($"mangga {mangga}");

            // menggunakan += untuk mengisi dan menjumlahkan
            apel += 6;

            Console.WriteLine($"apel {apel}");
        }
    }
}
