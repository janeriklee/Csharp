Console.Write("Anna bonuspisteet (0-9): ");
if (int.TryParse(Console.ReadLine(), out int pisteet))
{
    int kasvatuskerroin = 0;

    if (pisteet >= 1 && pisteet <= 3)
    {
        kasvatuskerroin = 10;
    }
    else if (pisteet >= 4 && pisteet <= 6)
    {
        kasvatuskerroin = 100;
    }
    else if (pisteet >= 7 && pisteet <= 9)
    {
        kasvatuskerroin = 1000;
    }
    else
    {
        Console.WriteLine("Virheelliset pisteet. Anna luku väliltä 0-9.");
        return;
    }

    int uudetPisteet = pisteet * kasvatuskerroin;
    Console.WriteLine("Uudet bonuspisteet: " + uudetPisteet);
}
else
{
    Console.WriteLine("Virheellinen syöte. Anna kokonaisluku.");
}