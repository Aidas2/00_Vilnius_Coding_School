using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SestaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var zmones = new List<Zmogus>();

                var eilutes = File.ReadAllLines("AdresuKnygute.txt").ToList();

                foreach (var eilute in eilutes)
                {
                    var eilutesDuomenys = eilute.Split(' ');
                    var zmogus = new Zmogus(eilutesDuomenys[0], 
                                            eilutesDuomenys[1], 
                                            eilutesDuomenys[2]);
                    zmones.Add(zmogus);
                }

                foreach(var zmogus in zmones)
                {
                    zmogus.AtspausdinkInformacija();
                }

                Console.WriteLine("Iveskite nauja irasa:");
                var naujaEilute = Console.ReadLine();

                eilutes.Add(naujaEilute);

                File.WriteAllLines("AdresuKnygute.txt", eilutes);
            }
            catch(Exception e) 
            {
                Console.WriteLine($"Ivyko klaida: {e.Message}");
            }
            Console.Read();
        }
    }
}
