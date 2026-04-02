using Corona;

public class DomVirus : Virus
{
    private static Random rnd = new Random();

    public override bool TryVaccin(Vaccin vaccin)
    {
        bool resultaat = base.TryVaccin(vaccin);

        if (!resultaat)
        {
            if (rnd.Next(0, 2) == 0)
            {
                typeof(Virus)
                    .GetProperty("DoomCountdown")
                    .SetValue(this, this.DoomCountdown + 2);
            }
        }

        return resultaat;
    }
}
