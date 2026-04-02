using Corona;

public class Generator : Gebouw
{
    public Generator(string naam, int x, int y) : base(naam, x, y) { }

    public override void PrintGebouw()
    {
        Console.SetCursorPosition(X, Y);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("g");
        Console.ResetColor();
    }

    public override string ToString() => base.ToString() + " - Bromt een beetje, maar geeft stroom.";
}