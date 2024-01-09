Console.WriteLine("Mitä muotoa haluat käyttää? (kokonaisluku, doubleluku vai merkkijono):");
string valinta = Console.ReadLine();

    switch (valinta)
    {
        case "kokonaisluku":
            Console.Write("Syötä kokonaisluku: ");
            if (int.TryParse(Console.ReadLine(), out int kokonaisluku))
            {
                kokonaisluku++;
                Console.WriteLine("Kasvatettu luku: " + kokonaisluku);
            }
            else
            {
            Console.WriteLine("Virheellinen syöte. Anna kokonaisluku.");
            }
            break;

        case "doubleluku":
            Console.Write("Syötä luku: ");
            if (double.TryParse(Console.ReadLine(), out double doubleluku))
            {
                doubleluku++;
                Console.WriteLine("Kasvatettu luku: " + doubleluku);
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna doubleluku.");
            }
            break;

        case "merkkijono":
            Console.Write("Syötä merkkijono: ");
            string merkkijono = Console.ReadLine();
            merkkijono += "*";
            Console.WriteLine("Merkkijono muokattuna: " + merkkijono);
            break;

        default:
            Console.WriteLine("Virheellinen valinta. Valitse kokonaisluku, doubleluku tai merkkijono.");
            break;
    }

