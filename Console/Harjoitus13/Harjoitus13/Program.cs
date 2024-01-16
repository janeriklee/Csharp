Console.Write("Anna eka luku: ");
string eka = Console.ReadLine();

Console.Write("Anna toka luku: ");
string toka = Console.ReadLine();

Console.Write("Anna kolmas luku: ");
string kolmas = Console.ReadLine();

Console.Write("Anna neljäs luku: ");
string neljäs = Console.ReadLine();

Console.Write("Anna viides luku: ");
string viides = Console.ReadLine();

int suurin;

if (int.Parse(eka) > int.Parse(toka) && int.Parse(eka) > int.Parse(kolmas) && int.Parse(eka) > int.Parse(neljäs) && int.Parse(eka) > int.Parse(viides))
{
    suurin = int.Parse(eka);
}
else if (int.Parse(toka) > int.Parse(kolmas) && int.Parse(toka) > int.Parse(neljäs) && int.Parse(toka) > int.Parse(viides))
{
    suurin = int.Parse(toka);
}
else if (int.Parse(kolmas) > int.Parse(neljäs) && int.Parse(kolmas) > int.Parse(viides))
{
    suurin = int.Parse(kolmas);
}
else if (int.Parse(neljäs) > int.Parse(viides))
{
    suurin = int.Parse(neljäs);
}
else
{
    suurin = int.Parse(viides);
}

Console.WriteLine("Suurin luku on: " + suurin);