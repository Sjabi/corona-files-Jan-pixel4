using System;

namespace Corona
{
    public class Virus
    {
        protected static Random rnd = new Random();

        public string Naam { get; private set; }

        protected int killcode;

        private int doomCountdown;
        public int DoomCountdown
        {
            get { return doomCountdown; }
            protected set  
            {
                doomCountdown = value;

                if (doomCountdown <= 0)
                {
                    Console.WriteLine($"Game over {Naam}");
                }
            }
        }


        public Virus()
        {
            DoomCountdown = rnd.Next(10, 21); 
            killcode = rnd.Next(0, 100);  
            Naam = GenerateName();
        }

        private string GenerateName()
        {
            string letters = "";

            for (int i = 0; i < 3; i++)
            {
                letters += (char)rnd.Next(65, 91); 
            }

            int number = rnd.Next(1, 100);

            return letters + number;
        }

        public virtual bool TryVaccin(Vaccin vaccin)
        {
            int poging = vaccin.TryKillCode();

            if (poging == killcode)
            {
                vaccin.Oplossing = poging;
                return true;
            }
            else
            {
                DoomCountdown--;
                return false;
            }
        }


        public int GetKillCode()
        {
            return killcode;
        }
    }
}
