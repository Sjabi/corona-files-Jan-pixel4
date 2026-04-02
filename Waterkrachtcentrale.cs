using Corona;

public class Waterkrachtcentrale : Gebouw
{
    public Waterkrachtcentrale(string naam, int x, int y) : base(naam, x, y) { }

    public override void PrintGebouw()
    {
        Console.SetCursorPosition(X, Y);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("G");
        Console.ResetColor();
    }

    public override string ToString() => base.ToString() + " - Gebruikt water voor energie!";
}
