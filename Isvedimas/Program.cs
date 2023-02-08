

using System;

namespace Isvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Mano vardas : Laura");
            string vardas = "Laura";
            Console.Write("Mano vardas : ");
            Console.WriteLine(vardas);
            Console.WriteLine(); // jei nieko neparašyta veikia, kaip nauja eilutė 

            Console.WriteLine("Mano vardas : " + vardas);
            Console.WriteLine("Mano vardas : {0}, {1}", vardas, "ž");
            Console.WriteLine($"Mano vardas : {vardas}"); //geriausias būdas su dolerio ženklu
            Console.WriteLine("nauja eilutė \n viduryje uzduoties(funkcijos) ");
        }
    }
}
