using System;


namespace uzduotis8
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* UZDUOTIS 5 -  Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį,
             kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes. Pvz.: 4 + 5 = 9
             4 - 5 = -1 */

            int a = 5;
            int b = 10;
            int c = 20;
            Console.WriteLine($" {a} + {b} = {a + b}");
            Console.WriteLine($" {b} - {a} = {b - a}");
            Console.WriteLine($" {c} * {a} = {c * a}");
            Console.WriteLine($" {b} / {a} = {b / a}");
            Console.WriteLine();
            Console.WriteLine();

            // Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.

            Console.WriteLine(a);
            Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine(Math.Pow(a, 3));
            Console.WriteLine();

            // Išveskite į ekraną trijų skaičių sandaugą.

            Console.WriteLine(a * b * c);
            Console.WriteLine();

            /* UZDUOTIS 6
            Išveskite pasirinkto skaičiaus daugybos lentelę. Pvz.:
            5 * 0 = 0 5 * 1 = 5 */

            int d = 0;
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine($" {a} * {d++} = {a * d} ");
            Console.WriteLine();


            /* UZDUOTIS 7  
             Liepkite vartotojui įvesti savo vardą ir amžių.
             Į ekraną išveskite: “Jūsų vardas { vardas}, o amžius { amžius}.” */

            Console.WriteLine("Įveskite savo vardą : ");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite savo amžių : ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jūsų vardas {vardas} , o amžius {amzius} ");
            Console.WriteLine();

            //Liepkite vartotojui įvesti bet kokį simbolį. Atspausdinkite 3x3 kvadratą iš to simbolio.

            Console.WriteLine("Įveskite, bet kokį simbolį: ");
            char sim = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{sim}{sim}{sim}");
            Console.WriteLine($"{sim}{sim}{sim}");
            Console.WriteLine($"{sim}{sim}{sim}");
            Console.WriteLine();

            // Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio skaičiaus kvadratą

            Console.WriteLine("Įveskite bet kokį skaičių : ");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Jūsų duoto skaičiaus kvadratas");
            Console.WriteLine(Math.Pow(sk,2));
            Console.WriteLine();


            /*Liepkite vartotojui įvesti tris skaičius.Išveskite visų šių skaičių sumą,
             nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane. Pvz.:
             5 + 3 + 8 = 16 */

            Console.WriteLine("Įveskite bet kokį skaičių : ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite dar vieną skaičių : ");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite bet kokį kitą skaičių : ");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{sk1} + {sk2} + {sk3} = {sk1 + sk2 + sk3}");
            Console.WriteLine();

            /* UZDUOTIS 8
            Liepkite vartotojui įvesti bet kokį sveikąjį skaičių.
            Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5.Pvz.:
            2 * 1 = 2 */

            Console.WriteLine("Įveskite bet kokį sveiką skaičių : ");
            int sk4 = Convert.ToInt32(Console.ReadLine());
            int e = 0;
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine($" {sk4} * {e++} = {sk4 * e} ");
            Console.WriteLine();
            /* Liepkite vartotojui įvesti tris skaičius.Į ekraną išveskite šiuos skaičius ir jų vidurkį.
             * Pvz.: Įvestų skaičių 4, 5, 8 vidurkis: 5,7. */

            Console.WriteLine("Įveskite tris skaičius : 1) ");
            double sk5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įveskite tris skaičius : 2) ");
            double sk6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įveskite tris skaičius : 3) ");
            double sk7 = Convert.ToDouble(Console.ReadLine());
            double vidurkis = (sk5 + sk6 + sk7) / 3;
            Console.WriteLine($"Jūsų skaičių vidurkis = {vidurkis}");
            Console.WriteLine();

            /* UZDUOTIS 9 
            1. Liepkite vartotojui įvesti savo amžių. Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite,
            kad “jūs galite balsuoti”.
            2. Liepkite vartotojui įvesti bet kokį skaičių. Parašykite šias atskiras if sąlygas:
            Patikrinti, ar skaičius neigiamas, jei taip - aprėkti vartotoją :)
            Patikrinti, ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
            Patikrinti, ar skaičius lyginis, jei taip - išvesti “taip, skaičius yra lyginis”;
            Patikrinti, ar skaičius dalinasi iš 4, jei taip - išvesti “taip, dalinasi iš 4”;
            Patikrinti, ar skaičius yra didesnis nei 10, jei taip - išvesti “taip, skaičius yra didesnis už 10”. */


            Console.WriteLine();
            Console.WriteLine("Įveskite savo amžių");
            int amzius2 = Convert.ToInt32(Console.ReadLine());
            if (amzius2 > 18)
            {
                Console.WriteLine("Jūs galite balsuoti ");
            }
            Console.WriteLine();
            Console.WriteLine("Įveskite bet kokį skaičių : ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius < 0)
            {
                Console.WriteLine("Kas čia per skaičius gaidį???? Įvesk normalų!!!");
            }
            Console.WriteLine();

            if (skaicius > 0)
            {
                Console.WriteLine("Ačiū, Jūsų įvestas skaičius - puikus pasirinkimas! ");
            }
            Console.WriteLine();

            if (skaicius % 2 == 0)

            {
                Console.WriteLine("Taip, skaičius yra lyginis");
            }
            Console.WriteLine();

            if (skaicius % 4 == 0) 
            {
                Console.WriteLine("taip, dalinasi iš 4 ");
            }
            Console.WriteLine();

            if (skaicius > 10)
            {
                Console.WriteLine("taip, didesnis už 10 ");
            }
            Console.WriteLine();
        }
    }
}
