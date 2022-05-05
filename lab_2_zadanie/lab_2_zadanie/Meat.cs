namespace lab_2_zadanie
{
    public class Meat : Product
    {
        private double weight;
        public double Weight { get; set; }

        public Meat(string name, double weight) : base(name)
        {
            Weight = weight;
        }

        public override string Print()
        {
            return $"{base.Name} ({Weight} kg)";
        }
    }
}