namespace ObserverPatternBonus
{
    public class GasStation : IObserver
    {
        private GasCompany gasCompany;
        public string City { get; set; }
        public Region Region { get; set; }

        public GasStation(GasCompany gasCompany, string city, Region region)
        {
            this.gasCompany = gasCompany;
            City = city;
            Region = region;
        }

        public void Update()
        {
            double kero = gasCompany.Price;
            double hydro = gasCompany.Price * 1.1;
            double alco = gasCompany.Price * 0.9;

            switch (Region.Name)
            {
                case "Jylland":
                    Console.WriteLine($"{gasCompany.Name}'s tankstation i {City}, {Region.Name} har modtaget følgende priser: \n" +
                        $"KeroOxygen: {kero.ToString("#.##")}\n" +
                        $"HydroOxygen: {hydro.ToString("#.##")}\n" +
                        $"AlcoOxygen: {alco.ToString("#.##")}\n");
                    break;
                case "Fyn":
                    kero = kero * 0.95;
                    hydro = hydro * 0.95;
                    alco = alco * 0.95;
                    Console.WriteLine($"{gasCompany.Name}'s tankstation i {City}, {Region.Name} har modtaget følgende priser: \n" +
                        $"KeroOxygen: {kero.ToString("#.##")}\n" +
                        $"HydroOxygen: {hydro.ToString("#.##")}\n" +
                        $"AlcoOxygen: {alco.ToString("#.##")}\n");
                    break;
                case "Sjælland":
                    kero = kero * 1.05;
                    hydro = hydro * 1.05;
                    alco = alco * 1.05;
                    Console.WriteLine($"{gasCompany.Name}'s tankstation i {City}, {Region.Name} har modtaget følgende priser: \n" +
                       $"KeroOxygen: {kero.ToString("#.##")}\n" +
                       $"HydroOxygen: {hydro.ToString("#.##")}\n" +
                       $"AlcoOxygen: {alco.ToString("#.##")}\n");
                    break;
            }
        }
    }
}
