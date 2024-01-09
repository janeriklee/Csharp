Console.Write("Anna numero (0-999): ");
if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0 && numero <= 999)
{
    string sana = MuunnaNumeroSanaksi(numero);
    Console.WriteLine($"Luku sanoina: {sana}");
}
else
{
    Console.WriteLine("Virheellinen syöte. Anna luku väliltä 0-999.");
}

    static string MuunnaNumeroSanaksi(int numero)
{
    if (numero == 0)
    {
        return "Nolla";
    }

    string[] ykkoset = { "", "Yksi", "Kaksi", "Kolme", "Neljä", "Viisi", "Kuusi", "Seitsemän", "Kahdeksan", "Yhdeksän" };
    string[] kymmenet = { "", "", "Kaksikymmentä", "Kolmekymmentä", "Neljäkymmentä", "Viisikymmentä", "Kuusikymmentä", "Seitsemänkymmentä", "Kahdeksankymmentä", "Yhdeksänkymmentä" };

    if (numero < 10)
    {
        return ykkoset[numero];
    }
    else if (numero < 100)
    {
        return kymmenet[numero / 10] + " " + ykkoset[numero % 10];
    }
    else
    {
        return ykkoset[numero / 100] + "sataa" + (numero % 100 != 0 ? " " + MuunnaNumeroSanaksi(numero % 100) : "");
    }
}