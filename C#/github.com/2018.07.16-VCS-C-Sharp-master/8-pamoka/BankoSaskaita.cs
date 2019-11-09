using System;

namespace NamuDarbai
{
    public class BankoSaskaita
    {
        private string _saskaitosNumeris;
        private decimal _piniguSuma;

        public BankoSaskaita(string saskaitosNumeris, decimal piniguSuma)
        {
            _saskaitosNumeris = saskaitosNumeris;
            _piniguSuma = piniguSuma;
        }

        public void IsimkGrynuju(decimal grynieji) 
        {
            if(_piniguSuma >= grynieji) 
            {
                _piniguSuma -= grynieji;
            }
            else Console.WriteLine("Pinigu per mazai!!!");
        }

        public void IdekPinigu(decimal piniguSuma) 
        {
            if(piniguSuma > 0)
                _piniguSuma += piniguSuma;
        }
    }
}
