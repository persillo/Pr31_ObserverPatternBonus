namespace ObserverPatternBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GasCompany gc1 = new GasCompany("RocketFuel");

            Region r1 = new Region("Jylland");
            Region r2 = new Region("Fyn");
            Region r3 = new Region("Sjælland");

            GasStation gs1 = new GasStation(gc1, "Aalborg", r1);
            GasStation gs2 = new GasStation(gc1, "Odense", r2);
            GasStation gs3 = new GasStation(gc1, "Korsør", r3);

            gc1.Attach(gs1);
            gc1.Attach(gs2);
            gc1.Attach(gs3);

            gc1.Price = 14.79;
            gc1.Price = 17.23;
            gc1.Price = 12.88;
        }
    }
}
