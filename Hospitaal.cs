using Corona;

public class Hospitaal : Gebouw
{
    public Hospitaal(string naam, int x, int y) : base(naam, x, y) { }

    public override void PrintGebouw()
    {
        Console.SetCursorPosition(X, Y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("H");
        Console.ResetColor();
    }

    public override string ToString() => base.ToString() + " - Hier worden mensen beter.";
}