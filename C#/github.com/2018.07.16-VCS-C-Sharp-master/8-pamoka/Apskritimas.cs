using System;
namespace NamuDarbai
{
    public class Apskritimas : IFigura
    {
        private double _spindulys;

        public Apskritimas(double spindulys)
        {
            _spindulys = spindulys;
        }

        public void IsveskInformacija()
        {
            Console.WriteLine($"Mano spindulio ilgis yra {_spindulys}.");
        }

        public double PaskaiciuokIlgi()
        {
            return 2 * Math.PI * _spindulys;
        }

        public double PaskaiciuokPlota()
        {
            return Math.PI * _spindulys * _spindulys;
        }
    }
}
