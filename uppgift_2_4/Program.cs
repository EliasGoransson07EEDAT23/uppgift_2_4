using System;
namespace Uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lönekollen; Se medellönen på dina anställda!");
            Console.WriteLine("Dina anställda är Rebecca, Alfred, Morgan.");
            Console.WriteLine("Skriv Rebeccas lön nedan;");
            int Rebecca = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv Alfreds lön nedan;");
            int Alfred = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv Morgans lön nedan;");
            int Morgan = int.Parse(Console.ReadLine());
            int msum = Alfred + Rebecca + Morgan;
            int medel = msum / 3;

            Console.WriteLine("Medellönen på dina anställda är " + medel + "kr.");
            Console.ReadKey();
        }
    }
}