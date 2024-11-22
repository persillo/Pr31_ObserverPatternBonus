namespace ObserverPatternBonus
{
    public class GasCompany : ISubject
    {
        private List<IObserver> gasStations = new List<IObserver>();
        public string Name { get; }
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; Notify(); }
        }


        public GasCompany(string name)
        {
            Name = name;
        }

        public void Attach(IObserver o)
        {
            gasStations.Add(o);
        }

        public void Detach(IObserver o)
        {
            gasStations.Remove(o);
        }

        public void Notify()
        {
            foreach (GasStation g in gasStations)
            {
                g.Update();
            }
        }
    }
}
