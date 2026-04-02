using Corona;

public class Enclave
{
    protected List<Gebouw> gebouwen = new List<Gebouw>();
    protected static Random rnd = new Random();

    public Enclave()
    {
        // Startgebouwen op random locaties (tussen 0 en 20 voor de demo)
        gebouwen.Add(new Hospitaal("Basis Hospitaal", rnd.Next(0, 20), rnd.Next(0, 10)));
        gebouwen.Add(new Generator("Hoofd Generator", rnd.Next(0, 20), rnd.Next(0, 10)));
        for (int i = 0; i < 3; i++) BouwWoonst();
    }

    public virtual void BouwWoonst()
    {
        int x, y;
        bool plekVrij;
        do
        {
            x = rnd.Next(0, 30);
            y = rnd.Next(0, 15);
            plekVrij = true;
            foreach (var g in gebouwen)
                if (g.X == x && g.Y == y) plekVrij = false;
        } while (!plekVrij);

        gebouwen.Add(new Woonst("Huisje", x, y));
    }

    public virtual void ToonEnclave()
    {
        Console.Clear();
        foreach (var g in gebouwen)
        {
            g.PrintGebouw();
        }
        // Even naar beneden springen voor de tekst
        Console.SetCursorPosition(0, 16);
        Console.WriteLine($"--- Gebouwen in deze enclave ---");
        foreach (var g in gebouwen) Console.WriteLine(g.ToString());
    }
}