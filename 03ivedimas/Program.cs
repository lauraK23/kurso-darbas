using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ivedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Iveskite teksta:);
            //string ivedimas = Console.ReadLine();
            //Console.WriteLine($"Jus ivedete : . {ivedimas}");
            //Console.WriteLine();

            //Console.WriteLine("Jusu vardas: ");
            //string vardas = Console.ReadLine();
            //Console.WriteLine("O amzius: ");
            //string amzius = Console.ReadLine();
            //Console.WriteLine($"Jusu vardas {vardas}, o amzius {amzius}");
            //Console.WriteLine();

            //Console.WriteLine(Math.Min(5, 10));
            //Console.WriteLine(Math.Max(5, 10));
            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.Pow(5, 10));
            //Console.WriteLine(Math.Sqrt (9));

            //if salyga 

            //Console.WriteLine("Ar 8 yra daugiau uz 5 ");
            //int skaicius = 5;
            //if (skaicius == 5)
            //{
            //    Console.WriteLine("taip");
            //}
            //Console.WriteLine("tolimensnis kodas ");

            Console.WriteLine("Iveskite skaiciu : ");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jus ivedete : ");
            int liekana = skaicius % 2;
            bool lyginis = true; 
            if (liekana == 0)
            {
                lyginis = true;  
            }
            Console.WriteLine();



        }
    }
}
