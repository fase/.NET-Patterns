using System;

namespace PatternsSandbox.Patterns
{
    class DecoratorPattern : IPattern
    {
        public void RunExample()
        {
            Laptop myLaptop = new Laptop("Base Laptop Configuration", null);
            Feature memory = new Feature("8GB DDR3 Memory", myLaptop);
            Feature processor = new Feature("Quad-core Processor", memory);

            Console.WriteLine("Here are my hardware specs:");
            processor.ShowSpec();
        }
    }

    abstract class Decorator
    {
        private readonly Decorator _decorator;

        public string Description { get; set; }

        protected Decorator(string description, Decorator decorator = null)
        {
            _decorator = decorator;
            Description = description;
        }

        public void ShowSpec()
        {
            if(_decorator != null)
                _decorator.ShowSpec();

            Console.WriteLine(" - {0}", Description);
        }
    }

    class Laptop : Decorator
    {
        public Laptop(string description, Decorator decorator)
            : base(description, decorator)
        {
            
        }
    }

    class Feature : Decorator
    {
        public Feature(string description, Decorator decorator)
            : base(description, decorator)
        {
            
        }
    }
}
