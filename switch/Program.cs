using System;


namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string reiksme = "Katė";
            //switch (reiksme)

            switch ("Šuo")
            {
                case "šuo":
                    Console.WriteLine("neteisingas");
                    break;
                case "Šuo":
                    Console.WriteLine("teisingas");
                    break;

            }
        }
    }
}
