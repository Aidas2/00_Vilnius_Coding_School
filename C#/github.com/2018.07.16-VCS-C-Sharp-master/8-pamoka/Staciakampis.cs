using System;
namespace NamuDarbai
{
    public class Staciakampis : IFigura
    {
        private double _krastineX;
        private double _krastineY;

        public Staciakampis(double krastineX, double krastineY)
        {
            _krastineX = krastineX;
            _krastineY = krastineY;
        }

        public void IsveskInformacija()
        {
            Console.WriteLine($"Pirmos krastines ilgis - {_krastineX}, o antros - {_krastineY}");
        }

        public double PaskaiciuokIlgi()
        {
            return 2 * _krastineX + 2 * _krastineY;
        }

        public double PaskaiciuokPlota()
        {
            return _krastineX * _krastineY;
        }
    }
}
