using System;
using System.IO;

namespace PenktaPamoka
{
    public class FailuOperacijos
    {
        public static void NuskaitykIrIsveskEilutes(string path) 
        {
            string[] eilutes = File.ReadAllLines(path);

            foreach(var eilute in eilutes) 
            {
                Console.WriteLine(eilute);
            }
        }

        public static void NuskaitykIrIsvesk(string path)
        {
            string tekstas = File.ReadAllText(path);
            Console.WriteLine(tekstas);
        }

        public static void NuskaitykPakeiskIrasyk(string path) 
        {
            string[] eilutes = File.ReadAllLines(path);

            for (int i = 0; i < eilutes.Length; i += 2)
            {
                 eilutes[i] = eilutes[i].ToUpper();
            }

            File.WriteAllLines(path, eilutes);
        }
    }
}
