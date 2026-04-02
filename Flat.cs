using Corona;

public class Flat : Gebouw
{
    public Flat(string naam, int x, int y) : base(naam, x, y) { }

    public override void PrintGebouw()
    {
        Console.SetCursorPosition(X, Y);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("W");
        Console.ResetColor();
    }

    public override string ToString() => base.ToString() + " - Een grote flat met veel buren.";
}