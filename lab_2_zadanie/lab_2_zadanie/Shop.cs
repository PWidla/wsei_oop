using ConsoleApp;

namespace lab_2_zadanie
{
    public class Shop : IThing
    {
        private string name;
        private Person[] people;
        private Product[] products;

        public string Name { get => name; set => name = value; }

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }

        public void Print()
        {
            System.Console.WriteLine($"Shop: {name}");
            System.Console.WriteLine("-- People: --");
            foreach (var v in people)
            {
                System.Console.Write("      ");
                System.Console.WriteLine(v.Print());
            }
            System.Console.WriteLine("-- Products: --");
            foreach (var v in products)
            {
                System.Console.Write("      ");
                System.Console.WriteLine(v.Print());
            }
        }
    }
}