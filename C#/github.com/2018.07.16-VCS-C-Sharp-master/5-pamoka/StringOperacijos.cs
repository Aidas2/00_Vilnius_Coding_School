using System;

namespace PenktaPamoka
{
    public class StringOperacijos
    {
        public static void NuskaitykIrPakeisk() 
        {
            Console.WriteLine("Iveskite sakini: ");
            var sakinys = Console.ReadLine();

            Console.WriteLine("Iveskite pirma zodi: ");
            var zodis1 = Console.ReadLine();

            Console.WriteLine("Iveskite antra zodi: ");
            var zodis2 = Console.ReadLine();

            var rezultatas = sakinys.Replace(zodis1, zodis2);
            Console.WriteLine(rezultatas);
        }

        public static void NuskaitykIrIsveskAtvirksciai() 
        {
            Console.WriteLine("Iveskite sakini: ");
            var tekstas = Console.ReadLine();

            for (int i = tekstas.Length - 1; i >= 0; i--)
            {
                if (tekstas[i] != ' ')
                    Console.Write($"{tekstas[i]} ");
            }

            Console.WriteLine();
        }

        public static void NuskaitykIrIsvesk() 
        {
            Console.WriteLine("Iveskite sakini: ");
            var tekstas = Console.ReadLine();

            string[] zodziai = tekstas.Split(' ');

            foreach (var zodis in zodziai)
            {
                Console.WriteLine(zodis);
            }
        }

        public static void Pabandyk() 
        {
            Console.WriteLine("labai ilgas mano sakinys".Length);

            var tekstas1 = "Vilnius Coding School";

            Console.WriteLine(tekstas1.Contains("School"));
            Console.WriteLine(tekstas1.Contains("Learning"));

            Console.WriteLine(tekstas1.ToLower());
            Console.WriteLine(tekstas1.ToUpper());

            var zodziai = tekstas1.Split(' ');
            foreach (var zodis in zodziai)
            {
                Console.WriteLine($"{zodis} ilgis yra {zodis.Length}");
            }

            var arYraSchool = tekstas1
                                .ToLower()
                                .Replace(" ", "*")
                                .Contains("school");

            var tekstas2 = string.Join("*", zodziai);
            Console.WriteLine(tekstas2);
        }
    }
}
