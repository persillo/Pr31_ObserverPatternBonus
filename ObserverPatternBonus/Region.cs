namespace ObserverPatternBonus
{
    public class Region
    {
        public string Name { get; set; }
        //public List<string> Cities { get; set; } = new List<string>();

        public Region(string name)
        {
            Name = name;
        }

        //public List<string> Fyn { get; set; } = new List<string>
        //{
        //    "Odense",
        //    "Middelfart",
        //    "Svendborg"
        //};

        //public List<string> Sjælland { get; set; } = new List<string>
        //{
        //    "Korsør",
        //    "København",
        //    "Roskilde"
        //};
    }
}
