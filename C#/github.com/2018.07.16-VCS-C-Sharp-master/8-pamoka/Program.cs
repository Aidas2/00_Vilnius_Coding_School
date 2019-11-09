using System;
using System.Collections.Generic;

namespace NamuDarbai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFigura> figuros = new List<IFigura>
            {
                new Kvadratas(10),
                new Apskritimas(3),
                new StatusTrikampis(2, 3),
                new Staciakampis(2, 5),
                new Kvadratas(101),
                new Apskritimas(31),
                new StatusTrikampis(22, 34),
                new Staciakampis(12, 35),
                new Kvadratas(110),
                new Apskritimas(33),
                new StatusTrikampis(21, 34),
                new Staciakampis(12, 45)
            };

            foreach (var figura in figuros)
            {
                figura.IsveskInformacija();
            }

            double bendrasPlotas = 0;

            foreach (var figura in figuros)
            {
                bendrasPlotas += figura.PaskaiciuokPlota();
            }

            Console.WriteLine("Bendras plotas: " + bendrasPlotas);


            //List<IGyvunas> gyvunai = new List<IGyvunas>
            //{
            //    new Dramblys("Pilka", 1),
            //    new Skruzdeda("Sviesiai ruda", 2.3),
            //    new Dramblys("Pilka", 1.2),
            //    new Skruzdeda("Tamsiai ruda", 3.1)
            //};

            //foreach (var gyvunas in gyvunai)
            //{
            //    gyvunas.Kalbek();
            //    gyvunas.SpausdinkInformacija();
            //}
        }
    }
}
