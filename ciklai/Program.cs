using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <5; i++)
            {
            Console.WriteLine("Labas");
            }
            for (int i = 0; i < 25; i+= 5)
            {
                Console.WriteLine("Ate");
            }
            for (double i = 100000; i > 5; i = Math.Sqrt(i))
            {
                Console.WriteLine(i);

                // Rasti visu skaiciu zemesniu uz 1000 ir didesniu uz 0 bei kurie dalinasi is 3 arba 5, suma
            int suma = 0;

            for (int i = 0; i <1000; i++)
                {
                    if (i % 3 == 0 || i % 5 ==0 )
                    {
                        suma += i;
                    }
                }
                Console.WriteLine(i);


            }
        }
    }
}
