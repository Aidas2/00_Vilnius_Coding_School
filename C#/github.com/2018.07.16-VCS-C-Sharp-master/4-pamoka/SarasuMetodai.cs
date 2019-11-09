using System;
using System.Collections.Generic;

namespace KetvirtaPamoka
{
    public class SarasuMetodai
    {
        public static void SpausdinkSarasa(List<int> sarasas) 
        {
            if(sarasas.Count == 0) 
            {
                Console.WriteLine("Sarasas yra tuscias.");
                return;
            }

            foreach (var elementas in sarasas)
            {
                Console.Write($"{elementas} ");
            }

            Console.WriteLine();
        }

        public static void TestuokSarasus() 
        {
            var skaiciai = new List<int> { 1, 9, 10, -100, 78, 99 };

            SarasuMetodai.SpausdinkSarasa(skaiciai);

            skaiciai.Add(0);
            SarasuMetodai.SpausdinkSarasa(skaiciai);

            skaiciai.AddRange(new List<int> { 1, 2, 3 });
            SarasuMetodai.SpausdinkSarasa(skaiciai);

            skaiciai.Insert(0, 100);
            SarasuMetodai.SpausdinkSarasa(skaiciai);

            skaiciai.InsertRange(1, new List<int> { 0, 0, 0 });
            SarasuMetodai.SpausdinkSarasa(skaiciai);

            skaiciai.Remove(1);
            SarasuMetodai.SpausdinkSarasa(skaiciai);

            skaiciai.RemoveAt(0);
            SarasuMetodai.SpausdinkSarasa(skaiciai);

            skaiciai.RemoveRange(2, 4);
            SarasuMetodai.SpausdinkSarasa(skaiciai);

            var indeksas = skaiciai.IndexOf(99);
            Console.WriteLine(indeksas);

            var contains = skaiciai.Contains(-100);
            Console.WriteLine(contains);

            Console.WriteLine(skaiciai.Count);

            skaiciai.Sort();
            SarasuMetodai.SpausdinkSarasa(skaiciai);

            skaiciai.Reverse();
            SarasuMetodai.SpausdinkSarasa(skaiciai);

            skaiciai.Clear();
            SarasuMetodai.SpausdinkSarasa(skaiciai);
        }
    }
}
