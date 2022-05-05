using ConsoleApp;

namespace lab_2_zadanie
{
    public abstract class Product : IThing
    {
        private string name = null!;

        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        public abstract string Print();

    }
}