using Corona;

public class SlimVaccin : Vaccin
{
    private int huidigeIndex = 0;

    public SlimVaccin(string naam) : base(naam) { }

    public override int TryKillCode()
    {
        if (Oplossing != -1)
            return Oplossing;

        int waarde = (huidigeIndex % 10) * 10 + (huidigeIndex / 10);
        huidigeIndex++;

        return waarde;
    }
}
