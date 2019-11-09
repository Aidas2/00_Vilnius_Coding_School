using System;

using System.Collections.Generic;

namespace Septinta
{
    public class Daugiakampis
    {
        private List<Taskas> _taskai;

        public Daugiakampis(List<Taskas> taskai)
        {
            _taskai = taskai;
        }

        public void SpausdinkTaskus() 
        {
            foreach (var t in _taskai)
            {
                t.Spausdinti();
            }
        }

        public void PridekTaska(double x, double y)
        {
            _taskai.Add(new Taskas(x, y));
        }

        public void IstrinkTaska(int indeksas) 
        {
            _taskai.RemoveAt(indeksas);
        }
    }
}
