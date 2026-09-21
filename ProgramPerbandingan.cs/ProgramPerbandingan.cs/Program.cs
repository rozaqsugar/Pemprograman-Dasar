using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPerbandingan.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, apel = 0;

            Console.Write("jumlah perbandingan: ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("jumlah apel: ");
            apel = int.Parse(Console.ReadLine());

            Console.WriteLine("Hasil perbandingan: ");
            Console.WriteLine($"mangga > apel : {mangga > apel}");
            Console.WriteLine($"mangga >= apel : {mangga >= apel}");
            Console.WriteLine($"mangga < apel : {mangga < apel}");
            Console.WriteLine($"mangga <= apel : {mangga <= apel}");
            Console.WriteLine($"mangga == apel : {mangga == apel}");
            Console.WriteLine($"mangga != apel : {mangga != apel}");
        }
    }
}
