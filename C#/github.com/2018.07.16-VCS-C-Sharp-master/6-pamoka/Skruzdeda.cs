using System;

namespace SestaPamoka
{
    public class Skruzdeda
    {
        private string _vardas;

        public string Vardas {
            
            get {
                return _vardas;
            }

            set {
                if(value != "") {
                    _vardas = value;
                }
            }
        }

        public int Amzius { get; set; }

        public Skruzdeda(string vardas)
        {
            _vardas = vardas;
        }

        public Skruzdeda(int amzius = 0)
        {
            Amzius = amzius;
        }

        public int KiekSuvalgeiSkruzdeliu() 
        {
            return 100;
        }

        public void SpausdinkSavoSavybes() 
        {
            Console.WriteLine("Vardas yra " + Vardas);
            Console.WriteLine("Amzius yra " + Amzius);
        }
    }
}
