using System;
namespace NamuDarbai
{
    public class Kvadratas : IFigura
    {
        private double _krastine;

        public Kvadratas(double krastine)
        {
            _krastine = krastine;
        }

        public void IsveskInformacija()
        {
            Console.WriteLine($"Mano krastines ilgis yra {_krastine}.");
        }

        public double PaskaiciuokIlgi()
        {
            return 4 * _krastine;
        }

        public double PaskaiciuokPlota()
        {
            return _krastine * _krastine;
        }
    }
}
