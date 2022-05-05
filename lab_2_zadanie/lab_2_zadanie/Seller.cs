namespace lab_2_zadanie
{
    public class Seller : Person
    {
        public Seller(string name, int age) : base(name, age)
        {
        }
        public override string Print()
        {
            return($"Seller: {base.Name} ({base.Age} y.o)");
        }
    }
}