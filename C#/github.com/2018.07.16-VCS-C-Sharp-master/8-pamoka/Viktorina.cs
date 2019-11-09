using System;
using System.Collections.Generic;

namespace NamuDarbai
{
    public class Viktorina
    {
        private List<ViktorinosKlausimas> _klausimai;
        private int _taskai;

        public Viktorina(List<ViktorinosKlausimas> klausimai) 
        {
            _klausimai = klausimai;
        }

        public void PradetiZaidima() 
        {
            foreach (var klausimas in _klausimai)
            {
                Console.WriteLine("---------------------");
                klausimas.AtspausdinkKlausima();
                var ivedeTeisingai = klausimas.NuskaitykIrPatikrink();
                if(ivedeTeisingai) 
                {
                    _taskai++;
                }
            }
        }

        public void ParodykRezultata()
        {
            Console.WriteLine($"Surinkote tasku: {_taskai}");
        }
    }
}
