using System;
namespace NamuDarbai
{
    public class ViktorinosKlausimas
    {
        private string _klausimas;
        private string[] _galimiAtsakymai;
        private int _teisingasAtsakymas;

        public ViktorinosKlausimas(string klausimas, 
                                   string[] galimiAtsakymai, int teisingasAtsakymas)
        {
            _klausimas = klausimas;
            _galimiAtsakymai = galimiAtsakymai;
            _teisingasAtsakymas = teisingasAtsakymas;
        }

        public void AtspausdinkKlausima()
        {
            Console.WriteLine(_klausimas);

            for (int i = 0; i < _galimiAtsakymai.Length; i++)
            {
                Console.Write($"{i+1}. {_galimiAtsakymai[i]} ");
            }

            Console.WriteLine();
        } 

        public bool NuskaitykIrPatikrink() 
        {
            Console.WriteLine();
            Console.WriteLine("Iveskite teisingojo atsakymo numeri:");
            int numeris = int.Parse(Console.ReadLine());
            return (numeris - 1) == _teisingasAtsakymas;
        }
    }
}
