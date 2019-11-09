using System;
using System.Collections.Generic;

namespace KetvirtaPamoka
{
    public class PazymiuMetodai
    {
        public static List<int> NuskaitykPazymius() 
        {
            var pazymiai = new List<int>();

            bool arIvestaTuscia = false;

            Console.WriteLine("Iveskite pazymius:");

            while(!arIvestaTuscia) 
            {
                var tekstas = Console.ReadLine();
                if (tekstas == "")
                {
                    arIvestaTuscia = true;
                }
                else
                {
                    var pazymys = int.Parse(tekstas);
                    pazymiai.Add(pazymys);
                }
            }

            return pazymiai;
        }

        public static double PaskaiciuokVidurki(List<int> pazymiai) 
        {
            double suma = 0;

            foreach (var pazymys in pazymiai)
            {
                suma += pazymys;
            }

            return suma/pazymiai.Count;
        }

        public static double PaskaiciuokMediana(List<int> pazymiai) 
        {
            pazymiai.Sort();

            double mediana = 0;

            if(pazymiai.Count % 2 == 0) 
            {
                var indeksas1 = pazymiai.Count / 2;
                var indeksas2 = (pazymiai.Count / 2) - 1;
                mediana = (pazymiai[indeksas1] + pazymiai[indeksas2]) / 2.0;
            }
            else 
            {
                var indeksas = pazymiai.Count / 2;
                mediana = pazymiai[indeksas];
            }

            return mediana;
        }
    }
}
