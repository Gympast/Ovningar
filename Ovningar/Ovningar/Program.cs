using System.Collections.Concurrent;

double a = 0;
int b = 0;
Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();
Console.WriteLine($"Hej {name}!");
Console.WriteLine("Vad är ditt lösenord?");
string pass = Console.ReadLine().ToLower();

if (pass == "lösen")
{
    Console.WriteLine($"Grattis! Du kom ihåg att ditt lösenord va {pass}");
}
else
    Console.WriteLine("Fel lösenord");

Console.Write("Skriv ett tal:");
int tal = int.Parse(Console.ReadLine());

if (tal < 100)
{
    Console.WriteLine("Talet är mindre än 100");
}
else if(tal == 100)
{
    Console.WriteLine("Talet är 100");
}
else
    Console.WriteLine("Talet är större än 100");

Console.WriteLine("Hur många gånger ska jag hälsa på dig?");
int antal = int.Parse(Console.ReadLine());

for (int i = 0; i < antal; i++)
{
    Console.WriteLine($"Hej {name}!");
}

while (true)
{
    Console.WriteLine("Tal igen...");
    string tal2 = Console.ReadLine();

    if (double.TryParse(tal2, out double tal3))
    {
       a = a + tal3;
        Console.WriteLine($"Summan är {a} hittils");
        b++;
    }
    else
    {
        double sum = a/2;
    Console.WriteLine($"Medelvärdet av dina tal är {a/2}");
        break;
    }
}
Console.WriteLine("Skriv ett tal igen...");
double calc1 = double.Parse(Console.ReadLine());
Console.WriteLine("välj tecken (+-*/)");
string teck = Console.ReadLine();
Console.WriteLine("Tal igen...");
double calc2 = double.Parse(Console.ReadLine());

if (teck == "+")
{
    Console.WriteLine($"{calc1} plus {calc2} blir {calc1+calc2}");
}
else if (teck == "-")
{
    Console.WriteLine($"{calc1} minus {calc2} blir {calc1-calc2}");
}
else if (teck == "*")
{
    Console.WriteLine($"{calc1} gånger {calc2} blir {calc1*calc2}");
}
else if (teck == "/")
{
    Console.WriteLine($"{calc1} genom {calc2} blir {calc1/calc2}");
}
Console.WriteLine("Skriv in en månad");
int[] manadnr = new int[1];
string manad = Console.ReadLine();
switch (manad)
{
    case "januari":
        Console.WriteLine("1");

        break;

    case "februari":
        Console.WriteLine("2");
        break;

    case "mars":
        Console.WriteLine("3");
        break;

    default:
        Console.WriteLine("Det va la fan ingen månad");
        break;
}

Console.ReadKey();