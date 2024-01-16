Console.Write("Anna ensimmäinen luku: ");
string eka = Console.ReadLine();

Console.Write("Anna toinen luku: ");
string toka = Console.ReadLine();

if (double.TryParse(eka, out double luku1) && double.TryParse(toka, out double luku2))
{
    double summa = LaskeSumma(luku1, luku2);
    Console.WriteLine("Summa: " + summa);
}
else
{
    Console.WriteLine("Virheellinen syöte. Anna kelvolliset luvut. (desimaalit toimii pilkulla!!)");
}

    static double LaskeSumma(double luku1, double luku2)
{
    return luku1 + luku2;
}