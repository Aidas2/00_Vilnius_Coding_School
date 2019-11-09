using System;

namespace KetvirtaPamoka
{
    public class NamuDarbai
    {
        public static int Sum(int[] masyvas)
        {
            var suma = 0;

            foreach (var sk in masyvas)
            {
                suma += sk;
            }

            return suma;
        }

        public static int[] NunulinkElementa(int elementoIndeksas, int[] masyvas)
        {
            masyvas[elementoIndeksas] = 0;
            return masyvas;
        }

        public static int[] SukurMasyva(int masyvoDydis)
        {
            return new int[masyvoDydis];
        }

        public static void Pasisveikink()
        {
            Console.WriteLine("Iveskite varda:");
            var vardas = Console.ReadLine();
            Console.WriteLine($"Labas, {vardas}");
        }

        public static int KadaPenktadienis()
        {
            DateTime siandiena = DateTime.Now;
            var savaitesDiena = (int)siandiena.DayOfWeek;

            if (savaitesDiena <= 5)
            {
                return 5 - savaitesDiena;
            }
            else
            {
                return (7 - savaitesDiena) + 5;
            }
        }

        public static int Max(int[] masyvas)
        {
            int max = masyvas[0];

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > max)
                {
                    max = masyvas[i];
                }
            }

            return max;
        }
    }
}
