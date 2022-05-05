using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    public class Fruit : Product
    {
        private int counter;

        public int Count { get; set; }

        public Fruit(string name, int count) : base(name)
        {
            Count = count;
        }

        public override string Print()
        {
            return($"{base.Name} ({Count} fruits)");
        }
    }
}