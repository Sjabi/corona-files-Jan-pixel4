static void EnclaveManager()
{
    Dictionary<string, Enclave> enclaves = new Dictionary<string, Enclave>();

    while (true)
    {
        Console.WriteLine("\n--- ENCLAVE BEHEER ---");
        Console.WriteLine("1. Nieuwe Enclave");
        Console.WriteLine("2. Nieuwe StadsEnclave");
        Console.WriteLine("3. Bouw in Enclave (geef naam)");
        Console.WriteLine("4. Toon Enclave");
        string keuze = Console.ReadLine();

        if (keuze == "1" || keuze == "2")
        {
            Console.Write("Naam voor de enclave: ");
            string naam = Console.ReadLine();
            if (keuze == "1") enclaves.Add(naam, new Enclave());
            else enclaves.Add(naam, new StadsEnclave());
        }
        else if (keuze == "3")
        {
            Console.Write("Welke naam? ");
            string naam = Console.ReadLine();
            if (enclaves.ContainsKey(naam)) enclaves[naam].BouwWoonst();
        }
        else if (keuze == "4")
        {
            Console.Write("Welke naam? ");
            string naam = Console.ReadLine();
            if (enclaves.ContainsKey(naam)) enclaves[naam].ToonEnclave();
        }
    }
}