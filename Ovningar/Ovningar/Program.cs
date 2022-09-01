using System.Collections.Concurrent;

Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();
Console.WriteLine($"Hej {name}!");
Console.WriteLine("Vad är ditt lösenord?");
string pass = Console.ReadLine();

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

for (int i = 0; i <= antal; i++)
{
    Console.WriteLine($"Hej {name}!");
}