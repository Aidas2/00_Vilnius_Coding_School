```c#
//uzkomentuota eilute

/* 
  uzkomentuotas kodo blokas
*/

//paselectinus norimas eilutes ir CTRL + K + C jas visas uzkomentuoja (windows)
//paselectinus norimas eilutes ir CTRL + K + U jas visas atkomentuoja (windows)
```

1. Parašyti programą, kuri nuskaito įvestą tekstą ir atspausdina jį ekrane. Atspausdintus duomenis rodyti, kol nepaspaudžiamas ENTER. 

```c#
Console.WriteLine("Iveskite teksta:");
var tekstas = Console.ReadLine();
Console.WriteLine(tekstas);
Console.ReadLine();
```

2. Parašyti programą, kuri ATSKIRAI prašo įvesti vardą, pavardę, amžių ir atspausdina juos ekrane. Naudoti kintamuosius.

```c#
Console.WriteLine("Iveskite varda:");
var vardas = Console.ReadLine();


Console.WriteLine("Iveskite pavarde:");
var pavarde = Console.ReadLine();


Console.WriteLine("Iveskite amziu:");
var amzius = Console.ReadLine();

Console.WriteLine($"{vardas} {pavarde} {amzius}");
Console.ReadLine();
```
3. Parašyti programą, kuri prašo įvesti apskritimo spindulį ir pagal jį suskaičiuoja jo ilgį ir plotą.

```c#
Console.WriteLine("Iveskite apskritimo spinduli:");
var spindulysTekstas = Console.ReadLine();
var spindulys = int.Parse(spindulysTekstas);

var ilgis = 2 * Math.PI * spindulys;
var plotas = Math.PI * Math.Pow(spindulys, 2);

Console.WriteLine("Apskritimo ilgis: " + ilgis);
Console.WriteLine("Apskritimo plotas: " + plotas);

Console.ReadLine();
```
4. Parašyti programą, kuri prašo įvesti atstumą (metrais) ir laiką (sekundėmis), o iš įvestų duomenų suskaičiuoja greitį km/h formatu.

```c#
Console.WriteLine("Iveskite atstuma metrais:");
var atstumasMetraisTekstas = Console.ReadLine();
var atstumasMetrais = double.Parse(atstumasTekstas);

Console.WriteLine("Iveskite laika sekundemis:");
var laikasSekundemisTekstas = Console.ReadLine();
var laikasSekundemis = double.Parse(laikasSekundemisTekstas);

var greitis = (atstumasMetrais / 1000) / (laikasSekundemis/3600);

Console.WriteLine($"Greitis km/h: ", greitis);

Console.ReadLine();
```

5. Parašyti programą, kuri prašo įvesti vardą, pavardę ir gimimo vietą ir atspausdina juos ekrane tokiu formatu:

`Jonas Jonaitis deginasi Palangoje`

Pabandyti sujungti tekstą šiais skirtingais būdais: `+`, `string.Concat()`, `string.Format()`, bei panaudojant interpoliaciją.

```c#
Console.WriteLine("Koks jusu vardas?");
var vardas = Console.ReadLine();

Console.WriteLine("Kokia jusu pavarde?");
var pavarde = Console.ReadLine();

Console.WriteLine("Kuriame mieste gimete?");
var miestas = Console.ReadLine();

var tekstas1 = vardas + " " + pavarde + " deginasi " + miestas;
var tekstas2 = string.Concat(vardas, " ", pavarde, " deginasi ", miestas); 
var tekstas3 = string.Format("{0} {1} deginasi {2}", vardas, pavarde, miestas);
var tekstas4 = $"{vardas} {pavarde} deginasi {miestas}";

Console.WriteLine(tekstas1);
Console.WriteLine(tekstas2);
Console.WriteLine(tekstas3);
Console.WriteLine(tekstas4);

Console.ReadLine();
```
6. Parašyti programą, kuri prašo įvesti du skaičius ir patikrina ar jie lygūs. Rezultatą išvesti tokiu formatu: 

`skaičius1 ir skaičius2 yra lygūs/nelygūs`

```c#
Console.WriteLine("Iveskite pirma skaiciu:");
var skaicius1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite antra skaiciu:");
var skaicius2 = int.Parse(Console.ReadLine());

if(skaicius1 == skaicius2)
{
  Console.WriteLine($"{skaicius1} ir {skaicius2} yra lygus.");
}
else 
{
  Console.WriteLine($"{skaicius1} ir {skaicius2} yra nelygus.");
}

Console.ReadLine();
```

7. Parašyti programą, kuri prašo įvesti 3 skaičius ir nustato didžiausią iš jų.

```c#
Console.WriteLine("Iveskite pirma skaiciu:");
var skaicius1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite antra skaiciu:");
var skaicius2 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite trecia skaiciu:");
var skaicius3 = int.Parse(Console.ReadLine());

if(skaicius1 > skaicius2 && skaicius1 > skaicius3)
{
  Console.WriteLine($"{skaicius1} yra didziausias.");
}
else if(skaicius2 > skaicius1 && skaicius2 > skaicius3)
{
  Console.WriteLine($"{skaicius2} yra didziausias.");
}
else 
{
  Console.WriteLine($"{skaicius3} yra didziausias.");
}

Console.ReadLine();
```

8. Parašyti programą, kuri prašo įvesti mokinio pažymį ir ekrane išspausdina jo apibūdinimą. 
(10 – puiku, 9-8 – labai gerai, 7-6- gerai, 5 - vidutiniškai, 4 – bent teigiamas, 3-2-1 – labai blogai)

```c#
Console.WriteLine("Iveskite vaiko pazymi:");
var pazymys = int.Parse(Console.ReadLine());

switch(pazymys) 
{
  case 10:
    Console.WriteLine("Puiku!");
    break;
  case 9:
  case 8:
    Console.WriteLine("Laba gerai");
    break;
  case 7:
  case 6:
    Console.WriteLine("Gerai");
    break;
  case 5:
    Console.WriteLine("Vidutiniškai");
    break;
  case 4:
    Console.WriteLine("Teigiamas");
    break;
  case 3: case 2: case 1: //kad uzimtu maziau vietos, galime case surasyt i viena eilute sitaip
    Console.WriteLine("Labai blogai!");
    break;
  default:
    Console.WriteLine("Tokio pazymio nera vertinimo sistemoje.");
    break;
}

Console.ReadLine();
```
