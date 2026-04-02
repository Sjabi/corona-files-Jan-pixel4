using System;
using System.Collections.Generic;

namespace Corona
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FASE 1 – Zoek vaccin ===");

            Virus virus = new Virus();
            Vaccin werkendVaccin = ZoekVaccin(virus);

            if (werkendVaccin == null)
            {
                Console.WriteLine("Geen vaccin gevonden. Start programma opnieuw.");
                return;
            }

            Console.WriteLine("\n=== FASE 2 – Vaccinatiecentra ===");


            VaccinatieCentrum.BewaarVaccin(werkendVaccin.Oplossing);

            VerspreidCentra();

            Console.WriteLine("\n=== NIEUWE TEST – SlimVaccin + DomVirus ===");

            TestSlimVaccinEnDomVirus();

            Console.WriteLine("\n=== DICTIONARY OPERATOR MENU ===");

            DictionaryMenu();
        }


        static Vaccin ZoekVaccin(Virus virus)
        {
            List<Vaccin> vaccins = new List<Vaccin>();

            for (int i = 1; i <= 5; i++)
            {
                vaccins.Add(new Vaccin($"Vaccin{i}"));
            }

            while (virus.DoomCountdown > 0)
            {
                foreach (Vaccin v in vaccins)
                {
                    if (virus.TryVaccin(v))
                    {
                        Console.WriteLine($"Werkend vaccin gevonden: {v.Name}");
                        return v;
                    }
                }
            }

            return null;
        }


        static void VerspreidCentra()
        {
            List<VaccinatieCentrum> centra = new List<VaccinatieCentrum>();
            List<Vaccin> alleVaccins = new List<Vaccin>();

            for (int i = 0; i < 5; i++)
            {
                centra.Add(new VaccinatieCentrum());
            }


            foreach (VaccinatieCentrum centrum in centra)
            {
                for (int i = 0; i < 7; i++)
                {
                    Vaccin v = centrum.GeefVaccin();
                    if (v != null)
                        alleVaccins.Add(v);
                }
            }

            Console.WriteLine("\nOverzicht van alle geproduceerde vaccins:");

            foreach (Vaccin v in alleVaccins)
            {
                v.ToonInfo();
            }
        }


        static void TestSlimVaccinEnDomVirus()
        {
            Virus domVirus = new DomVirus();

            List<Vaccin> slimmeVaccins = new List<Vaccin>();

            for (int i = 0; i < 5; i++)
            {
                slimmeVaccins.Add(new SlimVaccin($"SlimVaccin{i}"));
            }

            while (domVirus.DoomCountdown > 0)
            {
                foreach (Vaccin v in slimmeVaccins)
                {
                    if (domVirus.TryVaccin(v))
                    {
                        Console.WriteLine("Slim vaccin gevonden tegen DomVirus!");
                        return;
                    }
                }
            }

            Console.WriteLine("Geen vaccin gevonden tegen DomVirus.");
        }


        static void DictionaryMenu()
        {
            Dictionary<string, VaccinatieCentrum> centraDB =
                new Dictionary<string, VaccinatieCentrum>();

            while (true)
            {
                Console.WriteLine("\n1. Voeg centrum toe");
                Console.WriteLine("2. Toon alle centra");
                Console.WriteLine("3. Genereer vaccins in land");
                Console.WriteLine("4. Stop");

                string keuze = Console.ReadLine();

                if (keuze == "1")
                {
                    Console.Write("Land: ");
                    string land = Console.ReadLine().ToLower();

                    if (centraDB.ContainsKey(land))
                    {
                        Console.WriteLine("Dit land heeft al een centrum!");
                    }
                    else
                    {
                        centraDB.Add(land, new VaccinatieCentrum());
                        Console.WriteLine("Centrum succesvol toegevoegd.");
                    }
                }
                else if (keuze == "2")
                {
                    Console.WriteLine("Centra in volgende landen:");

                    foreach (var item in centraDB)
                    {
                        Console.WriteLine(item.Key);
                    }
                }
                else if (keuze == "3")
                {
                    Console.Write("Kies land: ");
                    string land = Console.ReadLine().ToLower();

                    if (centraDB.ContainsKey(land))
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Vaccin v = centraDB[land].GeefVaccin();
                            v?.ToonInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Land niet gevonden.");
                    }
                }
                else if (keuze == "4")
                {
                    break;
                }
            }
        }
    }
}
