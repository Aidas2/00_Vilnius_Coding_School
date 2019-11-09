using System;
namespace Septinta
{
    public class KavosAparatas
    {
        private const int MaxPanaudojimuSk = 20;

        public double CukrausKiekisKg { get; set; }
        public double KavosPupeliuKiekisKg { get; set; }
        public double VandensKiekisL { get; set; }
        public double PienoKiekisL { get; set; }

        private int _panaudojimuSk = 0; 

        public KavosAparatas(double cukrus, double kava, double vanduo, double pienas)
        {
            CukrausKiekisKg = cukrus;
            KavosPupeliuKiekisKg = kava;
            VandensKiekisL = vanduo;
            PienoKiekisL = pienas;
        }

        public KavosAparatas(double kava, double vanduo) 
        {
            KavosPupeliuKiekisKg = kava;
            VandensKiekisL = vanduo;
        }

        public void DarykKava() 
        {
            Console.WriteLine("Iveskite kavos pavadinima:");
            string kavosPavadinimas = Console.ReadLine();

            switch (kavosPavadinimas)
            {
                case "latte":
                    DarykGerima(0.2, 0.1, 0.1, 0.2);
                    break;
                case "black":
                    DarykGerima(0.2, 0, 0.1, 0.2);
                    break;
                default:
                    Console.WriteLine("Tokios kavos daryt nemoku.");
                    break;
            }
        }

        private void DarykGerima(double kava, double pienas, double cukrus, double vanduo) 
        {
            if(ArUztenkaIngredientu(kava, pienas, cukrus, vanduo)) 
            {
                PienoKiekisL -= pienas;
                VandensKiekisL -= vanduo;
                KavosPupeliuKiekisKg -= kava;
                CukrausKiekisKg -= cukrus;
                Console.WriteLine("Kava padaryta!");
                _panaudojimuSk++;
            }
            else Console.WriteLine("Neuztenka ingredientu kavai pagaminti!");
        }

        private bool ArUztenkaIngredientu(double kava, double pienas, double cukrus, double vanduo) 
        {
            if (KavosPupeliuKiekisKg - kava >= 0 &&
               PienoKiekisL - pienas >= 0 &&
               CukrausKiekisKg - cukrus >= 0 &&
                VandensKiekisL - vanduo >= 0)
            {
                return true;
            }
            else return false;
        }


        public void SpausdinkBusena() 
        {
            Console.WriteLine("====== Busena =============");
            Console.WriteLine($"Cukraus kiekis: {CukrausKiekisKg}kg");
            Console.WriteLine($"Kavos kiekis: {KavosPupeliuKiekisKg}kg");
            Console.WriteLine($"Pieno kiekis: {PienoKiekisL}l");
            Console.WriteLine($"Vandens kiekis: {VandensKiekisL}l");
            Console.WriteLine("----------------------------");
        }
    }
}
