using System;
namespace NamuDarbai
{
    public class Dramblys : IGyvunas
    {
        public string Spalva { get; set; }

        public double StraublioIlgis { get; set; }

        public Dramblys(string spalva, double straublioIlgis)
        {
            Spalva = spalva;
            StraublioIlgis = straublioIlgis;
        }

        public void Kalbek()
        {
            Console.WriteLine("tuuuu tuuuuuu");
        }

        public void SpausdinkInformacija()
        {
            Console.WriteLine($"Mano spalva - {Spalva}, straublio ilgis - {StraublioIlgis}");
        }
    }
}
