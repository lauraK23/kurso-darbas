using System;
using System.Reflection.Emit;


namespace Uzduotis01
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Parašykite programą, kuri išvestų žodį “Labas” ir jūsų vardą toje pačioje eilutėje.

            string vardas = "Laura";
            Console.WriteLine("Labas " + vardas);

            Console.WriteLine("Labas Laura");

            //Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite į ekraną tekstą su šiuo amžiumi: “Įvestas amžius: { amžius}”. Tarp { }
            //nurodytas kintamasis, kurio reikšmė toje vietoje turi būti įstatyta.

            int amžius = 24;
            Console.WriteLine($"Įvestas amžius: {amžius}");

            //Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje be tarpų tarp šių skaičių(skaičius -25, išvedimas - 2525252525).
            //Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje su tarpais tarp šių skaičių(skaičius -25, rezultatas - 25 25 25 25 25).
          
            int skaičius = 12;

            Console.WriteLine($"{skaičius}{skaičius}{skaičius}{skaičius}{skaičius}");
            Console.WriteLine($"{skaičius} {skaičius} {skaičius} {skaičius} {skaičius} ");

            //Užduotis 2:     Atspausdinti rezultatą kuris pateiktas 1 Paskaitos paskutinėje skaidrėje

            Console.WriteLine(" --------------------------");
            Console.WriteLine("|                          |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|       Mano vardas        |");
            Console.WriteLine("|          Laura           |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|                          |");
            Console.WriteLine(" --------------------------");


            
        }
    }
}
