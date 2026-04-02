using System;

namespace Corona
{
    public abstract class Gebouw
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Naam { get; set; }

        public Gebouw(string naam, int x, int y)
        {
            Naam = naam;
            X = x;
            Y = y;
        }

        public abstract void PrintGebouw();

        public override string ToString()
        {
            return $"{Naam} (locatie: {X}, {Y})";
        }
    }
}