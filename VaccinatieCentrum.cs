using Corona;

public class VaccinatieCentrum
{
    public static int Oplossing { get; private set; } = -1;

    public static void BewaarVaccin(int oplossing)
    {
        Oplossing = oplossing;
    }

    public Vaccin GeefVaccin()
    {
        if (Oplossing == -1)
            return null;

        return new Vaccin("CentrumVaccin", Oplossing);
    }
}
