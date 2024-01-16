Console.Write("Anna fahrenheit aste: ");
string luku = Console.ReadLine();

if (double.TryParse(luku, out double luku1))
{
    double summa = LaskeSumma(luku1);
    Console.WriteLine("Celsius: " + summa);
}
else
{
    Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku");
}

static double LaskeSumma(double luku1)
{
    return (luku1 - 32) * 5/9;
}