Console.Write("Anna eka luku: ");
string eka = Console.ReadLine();

Console.Write("Anna toka luku: ");
string toka = Console.ReadLine();

Console.Write("Anna kolmas luku: ");
string kolmas = Console.ReadLine();

int suurin;

if (int.Parse(eka) > int.Parse(toka) && int.Parse(eka) > int.Parse(kolmas))
{
    suurin = int.Parse(eka);
}
else if (int.Parse(toka) > int.Parse(kolmas))
{
    suurin = int.Parse(toka);
}
else
{
    suurin = int.Parse(kolmas);
}

Console.WriteLine("Suurin luku on: " + suurin);
