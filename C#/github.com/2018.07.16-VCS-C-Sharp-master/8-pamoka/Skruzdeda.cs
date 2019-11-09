using System;
namespace NamuDarbai
{
    public class Skruzdeda : IGyvunas
    {
        public string Spalva { get; set; }

        public double Svoris { get; set; }

        public Skruzdeda(string spalva, double svoris)
        {
            Spalva = spalva;
            Svoris = svoris;
        }

        public void Kalbek()
        {
           Console.WriteLine("bubububu");
        }

        public void SpausdinkInformacija()
        {
            Console.WriteLine($"Mano spalva - {Spalva}, o mano svoris - {Svoris}.");
        }
    }
}
