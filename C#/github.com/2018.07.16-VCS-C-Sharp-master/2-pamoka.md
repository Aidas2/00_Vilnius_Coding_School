
## Kartojam

1. Parašyti programą, kuri nuskaito įvestą skaičių ir patikrina ar jis yra lyginis ar nelyginis.

```c#
Console.WriteLine("Iveskite naturaluji skaiciu: ");
int skaicius = int.Parse(Console.ReadLine());

var lyginis = skaicius % 2 == 0;

if(lyginis)
{
    Console.WriteLine("Skaicius yra lyginis.");
}
else 
{
    Console.WriteLine("Skaicius yra nelyginis.");
}
```
galima ir šitaip, išnaudojant [trinarį operatorių](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator):

```c#
Console.WriteLine("Iveskite naturaluji skaiciu: ");
int skaicius = int.Parse(Console.ReadLine());

Console.WriteLine($"Skaicius yra { (skaicius % 2 == 0 ? "lyginis" : "nelyginis") } ");

Console.ReadLine();
```

2. Parašyti programą, kuri nuskaito savaitės dienos numerį ir atspausdina jos žodinį pavadinimą ekrane.

```c#
Console.WriteLine("Iveskite savaites dienos numeri: ");
int savDienosNr = int.Parse(Console.ReadLine());

switch(savDienosNr){
    case 1:
        Console.WriteLine("Pirmadienis");
        break;
    case 2:
        Console.WriteLine("Antradienis");
        break;
    case 3:
        Console.WriteLine("Treciadienis");
        break;
    case 4:
        Console.WriteLine("Ketvirtadienis");
        break;
    case 5:
        Console.WriteLine("Penktadienis");
        break;
    case 6:
        Console.WriteLine("Sestadienis");
        break;
    case 7:
        Console.WriteLine("Sekmadienis");
        break;
    default:
        Console.WriteLine("Savaiteje yra tik septynios dienos!!!");
        break;
}

Console.ReadLine();
```

3. Parašyti programą kalkuliatorių, kuri nuskaito 2 skaičius, nuskaito matematinį veiksmą, atlieka veiksmą ir atspausdina rezultatą ekrane tokiu formatu:
```c# 
{pirmas skaicius} {matematinis veiksmas} {antras skaičius} = {rezultatas}
```

```c# 
Console.WriteLine("Iveskite pirma skaiciu: ");
int skaicius1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite operacija:");
string operacija = Console.ReadLine();

Console.WriteLine("Iveskite antra skaiciu:");
int skaicius2 = int.Parse(Console.ReadLine());

switch(operacija){
    case "+":
        Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
        break;
    case "-":
        Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
        break;
    case "*":
        Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
        break;
    case "/":
        Console.WriteLine($"{skaicius1} / {skaicius2} = {skaicius1 / skaicius2}");
        break;
    case "%":
        Console.WriteLine($"{skaicius1} % {skaicius2} = {skaicius1 % skaicius2}");
        break;
    case "^":
        Console.WriteLine($"{skaicius1} ^ {skaicius2} = {Math.Pow(skaicius1, skaicius2)}");
        break;
    default:
        Console.WriteLine("Nesuprantu tokios operacijos.");
        break;
}

Console.ReadLine();
```

galima ir taip, bet VS turėtų siūlyti paversti į `switch`:

```c# 
Console.WriteLine("Iveskite pirma skaiciu: ");
int skaicius1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite operacija:");
string operacija = Console.ReadLine();

Console.WriteLine("Iveskite antra skaiciu:");
int skaicius2 = int.Parse(Console.ReadLine());

double rezultatas = 0;

if(operacija == "+") 
{
    rezultatas = skaicius1 + skaicius2;
}
else if(operacija == "-") 
{
    rezultatas = skaicius1 - skaicius2;
}
else if (operacija == "*")
{
    rezultatas = skaicius1 * skaicius2;
}
else if (operacija == "/")
{
    rezultatas = skaicius1 / skaicius2;
}
else if (operacija == "%")
{
    rezultatas = skaicius1 % skaicius2;
}
else if (operacija == "^")
{
    rezultatas = Math.Pow(skaicius1, skaicius2);
}

Console.WriteLine($"{skaicius1} {operacija} {skaicius2} = {rezultatas}");

Console.ReadLine();
```

## Nauja tema

1. Parašyti programą naudojant `while` ciklą, kuri nuskaitinėja įvestus skaičius tol, kol jų suma nėra daugiau 50.

```c#
int sum = 0;
while(sum < 50) 
{
  int number = int.Parse(Console.ReadLine());
  sum += number;
  Console.WriteLine($"suma: {sum} ");
}
Console.ReadLine();
```

2. Parašyti programą naudojant `while` ciklą, kuri nuskaitinėja paspaustus klavišus ir išveda jų pavadinimus tol, kol nepaspaudžiamas ESC klavišas. 

```c#
while(true) 
{
  var key = Console.ReadKey().Key;
  if(key == ConsoleKey.Escape)
  {
    break;
  } 
  else 
  {
    Console.WriteLine(key.ToString());
  }
}
```

3. Parašyti programą naudojant `for` ciklą, kuri suskaičiuoja pirmų 10 natūraliųjų skaičių sumą.

```c#
int sum = 0;
for (var i = 1; i <= 10; i++)
{
  sum += i;
}
Console.WriteLine("sum: " + sum);
Console.ReadKey();
```

4. Parašyti programą naudojant `for` ciklą, kuri prašo įvesti natūralųjį skaičių ir atspausdina visus žemesnius natūraliuosius skaičius mažėjančia tvarka.

```c#
Console.WriteLine("Iveskite skaiciu: ");
int skaicius = int.Parse(Console.ReadLine());

for (var i = skaicius - 1; i > 0; i--) 
{
    Console.WriteLine(i);
}

Console.ReadLine();
```

5. Parašyti programą naudojant for ciklą, kuri prašo įvesti skaičių ir atspausdina jo daugybos lentelę.

```c#
Console.WriteLine("Iveskite skaiciu: ");
int skaicius = int.Parse(Console.ReadLine());

for (var i = 1; i <= 10; i++) 
{
    Console.WriteLine($"{skaicius} * {i} = {skaicius * i}");
}

Console.ReadLine();
```

6. Parašyti programą, kuri nuskaito 10 elementų į masyvą ir jį atspausdina.

```c#
string[] manoMasyvas = new string[10];

for (var i = 0; i < 10; i++ )
{
    var elementas = Console.ReadLine();
    manoMasyvas[i] = elementas;
}

for (var i = 0; i < 10; i++)
{
    Console.WriteLine(manoMasyvas[i]);
}

Console.ReadLine();
```

7. Parašyti programą, kuri prašo įvesti masyvo dydį ir tada nuskaito n elementų į masyvą ir atspausdina jį atvirkščiai.

```c#
Console.Write("Iveskite masyvo dydi: ");
var masyvoDydis = int.Parse(Console.ReadLine());

string[] manoMasyvas = new string[masyvoDydis];

for(var i = 0; i < masyvoDydis; i++)
{
    var elementas = Console.ReadLine();
    manoMasyvas[i] = elementas;
}

for (var i = masyvoDydis - 1; i >= 0; i--)
{
    Console.WriteLine(manoMasyvas[i]);
}

Console.ReadLine();
```

8. Sukurti programą, kuri nuskaitinėja eilutes tol, kol negauna tuščios ir deda eilutes į masyvą. Naudojant foreach ciklą atspausdinti masyvą.

```c#
bool negavauTusciosEilutes = true;
string[] eiluciuMasyvas = new string[10];
int iteratorius = 0;

while (negavauTusciosEilutes)
{
    var eilute = Console.ReadLine();
    if (eilute == "")
    {
        negavauTusciosEilutes = false;
    }
    else 
    {
        eiluciuMasyvas[iteratorius] = eilute;
        iteratorius++;
    }
}

foreach(var eilute in eiluciuMasyvas) 
{
    Console.WriteLine(eilute);
}

Console.ReadLine();
```
