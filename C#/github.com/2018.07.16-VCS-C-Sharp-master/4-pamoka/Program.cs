using System;

namespace KetvirtaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            var pazymiai = PazymiuMetodai.NuskaitykPazymius();
            SarasuMetodai.SpausdinkSarasa(pazymiai);

            var vidurkis = PazymiuMetodai.PaskaiciuokVidurki(pazymiai);
            Console.WriteLine(vidurkis);

            var mediana = PazymiuMetodai.PaskaiciuokMediana(pazymiai);
            Console.WriteLine(mediana);
        }
    }
}
