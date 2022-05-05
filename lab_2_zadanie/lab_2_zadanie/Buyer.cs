using System;
using System.Collections.Generic;

namespace lab_2_zadanie
{
    public class Buyer : Person
    {
        protected List<Product> tasks = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {
        }

        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }

        public void RemoveProduct(int index)
        {
            tasks.RemoveAt(index);
        }

        public override string Print()
        {
            Console.Write($"Buyer: {base.Name} ({base.Age} y.o)");
            if (tasks.Count > 0)
            {
                Console.Write("\n            -- Products: --");
                foreach (Product v in tasks)
                {
                    Console.Write($"\n            {v.Print()}");
                }
            }
            return null;
        }
    }
}