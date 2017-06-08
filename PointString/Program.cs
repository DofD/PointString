using System;

namespace PointString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            unsafe
            {
                const string str = "Привет";
                const string str2 = "Привет";

                Console.WriteLine($"str = {str}");
                Console.WriteLine($"str2 = {str2}");

                fixed (char* p = str)
                {
                    var adr = (uint)p;
                    Console.WriteLine($"Адресс str = {adr}");
                    Console.WriteLine($"Адресс str2 = {adr}");

                    p[0] = 'T';
                }

                Console.WriteLine($"str = {str}");
                Console.WriteLine($"str2 = {str2}");
            }

            Console.ReadKey();
        }
    }
}