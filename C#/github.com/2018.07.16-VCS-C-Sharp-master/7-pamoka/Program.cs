using System;
using System.Collections.Generic;

namespace Septinta
{
    class Program
    {
        static void Main(string[] args)
        {
            KavosAparatas kavosAparatas = new KavosAparatas(1.2, 1.4, 5, 3);

            kavosAparatas.SpausdinkBusena();
            kavosAparatas.DarykKava();
            kavosAparatas.SpausdinkBusena();

            int sk = 0;
            int.Parse("2");

            List<int> lists = new List<int>();
            lists.Add(3);

            Func<int, int, bool> myFunc2 = (x, y) => x == y;
        }
    }
}


//var taskai = new List<Taskas> {
//                new Taskas(1,3),
//                new Taskas(3,4),
//                new Taskas(5,7)
//            };

//var daugiakampis =
//    new Daugiakampis(taskai);

//daugiakampis.SpausdinkTaskus();

            //Console.WriteLine("============");

            //daugiakampis.PridekTaska(4, 5);
            //daugiakampis.SpausdinkTaskus();

            //Console.WriteLine("============");

            //daugiakampis.IstrinkTaska(0);
            //daugiakampis.SpausdinkTaskus();