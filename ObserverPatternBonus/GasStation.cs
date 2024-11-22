namespace ObserverPatternBonus
{
    public class GasStation : IObserver
    {
        private GasCompany gasCompany;
        private string city;
        private Region region;

        public GasStation(GasCompany gasCompany, string city, Region region)
        {
            this.gasCompany = gasCompany;
            this.city = city;
            this.region = region;
        }

        public void Update()
        {
            double kero = gasCompany.Price;
            double hydro = gasCompany.Price * 1.1;
            double alco = gasCompany.Price * 0.9;

            switch (region.Name)
            {
                case "Jylland":
                    Console.WriteLine($"{gasCompany.Name}'s tankstation i {city}, {region.Name} har modtaget følgende priser: \n" +
                        $"KeroOxygen: {kero.ToString("#.##")}\n" +
                        $"HydroOxygen: {hydro.ToString("#.##")}\n" +
                        $"AlcoOxygen: {alco.ToString("#.##")}\n");
                    break;
                case "Fyn":
                    kero = kero * 0.95;
                    hydro = hydro * 0.95;
                    alco = alco * 0.95;
                    Console.WriteLine($"{gasCompany.Name}'s tankstation i {city}, {region.Name} har modtaget følgende priser: \n" +
                        $"KeroOxygen: {kero.ToString("#.##")}\n" +
                        $"HydroOxygen: {hydro.ToString("#.##")}\n" +
                        $"AlcoOxygen: {alco.ToString("#.##")}\n");
                    break;
                case "Sjælland":
                    kero = kero * 1.05;
                    hydro = hydro * 1.05;
                    alco = alco * 1.05;
                    Console.WriteLine($"{gasCompany.Name}'s tankstation i {city}, {region.Name} har modtaget følgende priser: \n" +
                       $"KeroOxygen: {kero.ToString("#.##")}\n" +
                       $"HydroOxygen: {hydro.ToString("#.##")}\n" +
                       $"AlcoOxygen: {alco.ToString("#.##")}\n");
                    break;
            }
        }
    }
}
