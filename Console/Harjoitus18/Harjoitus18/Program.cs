Console.Write("Anna celsius aste: ");
string luku = Console.ReadLine();

if (double.TryParse(luku, out double luku1))
{
    double summa = LaskeSumma(luku1);
    Console.WriteLine("Fahrenheit: " + summa);
}
else
{
    Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku");
}

static double LaskeSumma(double luku1)
{
    return luku1 * 1.8 + 32;
}
