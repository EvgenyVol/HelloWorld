using System;

namespace Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cat cat = new Cat("Kisik", 24, "white", 12);

            Console.WriteLine(cat.Name);
            //cat.Name = "Kisik";
            //cat.LengthTail = 12;
            //cat.Weight = 24;
            //cat.Color = "white";

        }
    }

    class Person { }

    class ChangeRequest
    {
        public ChangeRequest(string title, string description, Person implementer)
        {
            this.Title = title;
            this.Description = description;
            this.Implementer = implementer;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public Person Implementer { get; set; }
    }

    class DefectFixRequest : ChangeRequest
    {
        public string ExpectedBehavior { get; set; }
        public string ObservedBehavior { get; set; }
        public Person Reporter { get; set; }
    }

    class FeatureRequest : ChangeRequest
    {
        public Person RequestedBy { get; set; }
    }

    class Animal
    {
        public string _name { get; set; }
        public int weight { get; set; }
        public string Color { get; set; }
    }

    class Cat : Animal
    {
        public Cat(string name, int weigth, string color, int lengthTail)
        {
             _name = name;
            weight = weigth;
            this.Color = color;
            _lengthTail = lengthTail; 
        }
        private int _lengthTail { get; set; }
    }
}
