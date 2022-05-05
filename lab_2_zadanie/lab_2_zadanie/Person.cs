using ConsoleApp;

namespace lab_2_zadanie
{
    public abstract class Person : IThing
    {
        private string name = null!;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string Print();
     

    }
}
