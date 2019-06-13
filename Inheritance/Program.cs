using System;

namespace Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Cat cat = new Cat("Kisik", 24, "white", 12);

            //Console.WriteLine(cat.Name);
            //cat.Name = "Kisik";
            //cat.LengthTail = 12;
            //cat.Weight = 24;
            //cat.Color = "white";

            Person evgeny = new Person("Evgeny");
            Person alimar = new Person("Alimar");
            ChangeRequest c1 = new FeatureRequest(
                "Volume knob shoud go to eleven",
                "It's one louder",
                evgeny,
                alimar);

            ChangeRequest c2 = new DefectFixRequest(
                "Power switch can electrocute user",
                "Very dangerous",
                evgeny,
                alimar);

            ChangeRequest c3 = null;


            FeatureRequest f1 = (FeatureRequest)c1;
            FeatureRequest f2 = (FeatureRequest)c2;
            FeatureRequest f3 = (FeatureRequest)c3;

            if (c1 is FeatureRequest)
            {
                FeatureRequest f = (FeatureRequest)c1;
                Console.WriteLine(f.RequestedBy.Name);
            }

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
        public DefectFixRequest(string title, string description, Person implementer, Person reporter)
            : base(title, description, implementer)
        {
            this.Reporter = reporter;
        }
        public string ExpectedBehavior { get; set; }
        public string ObservedBehavior { get; set; }
        public Person Reporter { get; set; }
    }

    class FeatureRequest : ChangeRequest
    {
        public FeatureRequest(string title, string description, Person implementer, Person requestedBy)
            : base(title, description, implementer)
        {
            this.RequestedBy = requestedBy;
        }
        public Person RequestedBy { get; set; }
    }

    class Animal
    {
        public Animal(string name, int weight, string color)
        {
            this.Name = name;
            this.Weight = weight;
            this.Color = color;
        }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
    }

    class Cat : Animal
    {
        public Cat(string name, int weight, string color, int lengthTail)
                : base(name, weight, color)
            {
                this.LengthTail = lengthTail;
            }
            // _name = name;
           // weight = weigth;
           // this.Color = color;
           // _lengthTail = lengthTail; 
       
         public int LengthTail { get; set; }
    }
}
