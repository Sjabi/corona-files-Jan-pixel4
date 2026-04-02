public class StadsEnclave : Enclave
{
    private int woonstTeller = 0;

    public StadsEnclave() : base()
    {
        gebouwen.Add(new Waterkrachtcentrale("Grote Dam", rnd.Next(0, 30), rnd.Next(0, 15)));
        gebouwen.Add(new Hospitaal("Extra Kliniek", rnd.Next(0, 30), rnd.Next(0, 15)));
        gebouwen.Add(new Flat("Eerste Flat", rnd.Next(0, 30), rnd.Next(0, 15)));
    }

    public override void BouwWoonst()
    {
        woonstTeller++;
        if (woonstTeller >= 3)
        {
            gebouwen.RemoveAll(g => g is Woonst);
            gebouwen.Add(new Flat("Nieuwe Flat", rnd.Next(0, 30), rnd.Next(0, 15)));
            woonstTeller = 0;
            Console.WriteLine("3 woningen vervangen door een Flat!");
        }
        else
        {
            base.BouwWoonst();
        }
    }
}