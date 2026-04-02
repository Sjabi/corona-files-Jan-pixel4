using Corona;

public class Woonst : Gebouw
{
    public Woonst(string naam, int x, int y) : base(naam, x, y) { }

    public override void PrintGebouw()
    {
        Console.SetCursorPosition(X, Y);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("w");
        Console.ResetColor();
    }

    public override string ToString() => base.ToString() + " - Een gezellig huisje.";
}
