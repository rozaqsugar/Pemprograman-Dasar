using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrement.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga = 3;
            int apel = 4;

            Console.WriteLine($"mangga+1 = {mangga}");
            Console.WriteLine($"apel+1 = {apel}");

            // increment
            mangga++;
            ++apel;

            Console.WriteLine($"mangga+1 = {mangga}");
            Console.WriteLine($"apel+1 = {apel}");

            // decrement
            mangga--;
            --apel;

            Console.WriteLine($"mangga-1 = {mangga}");
            Console.WriteLine($"apel-1 = {apel}");
        }
    }
}
