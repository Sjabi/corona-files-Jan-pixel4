using System;

namespace Corona
{
    public class Vaccin
    {
        private static Random rnd = new Random();

        public string Name { get; private set; }

        public int Oplossing { get; set; } = -1;

        public Vaccin(string name)
        {
            Name = name;
        }

        public Vaccin(string name, int oplossing) : this(name)
        {
            Oplossing = oplossing;
        }

        public virtual int TryKillCode()
        {
            if (Oplossing != -1)
                return Oplossing;

            return rnd.Next(1, 101);
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Vaccin: {Name} | Oplossing: {Oplossing}");
        }
    }
}