Console.Write("Anna eka luku: ");
string eka = Console.ReadLine();

Console.Write("Anna toka luku: ");
string toka = Console.ReadLine();

int isompi, pienempi;
if (int.Parse(eka) > int.Parse(toka))
{
    isompi = int.Parse(eka);
    pienempi = int.Parse(toka);
}
else
{
    isompi = int.Parse(toka);
    pienempi = int.Parse(eka);
}

Console.WriteLine("Numerot järjestyksessä: " + isompi + ", " + pienempi);