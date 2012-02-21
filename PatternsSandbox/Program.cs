using System;
using PatternsSandbox.Patterns;

namespace PatternsSandbox
{
    class Program
    {
        static void Main()
        {
            RunStrategy();
            RunObserver();
            RunDecorator();
            RunSingleton();
            RunSingleFactory();

            Console.ReadKey();
        }

        private static void RunStrategy()
        {
            Console.WriteLine("\n---------------------------STRATEGY---------------------------");

            StrategyPattern strat = new StrategyPattern();
            strat.RunExample();
            
            Console.WriteLine("--------------------------------------------------------------");
        }

        private static void RunObserver()
        {
            Console.WriteLine("\n---------------------------OBSERVER---------------------------");

            ObserverPattern observerPattern = new ObserverPattern();
            observerPattern.RunExample();

            Console.WriteLine("--------------------------------------------------------------");
        }

        public static void RunDecorator()
        {
            Console.WriteLine("\n---------------------------DECORATOR--------------------------");

            DecoratorPattern decoratorPattern = new DecoratorPattern();
            decoratorPattern.RunExample();

            Console.WriteLine("--------------------------------------------------------------");
        }

        public static void RunSingleton()
        {
            Console.WriteLine("\n---------------------------SINGLETON--------------------------");

            SingletonPattern singletonPattern = new SingletonPattern();
            singletonPattern.RunExample();

            Console.WriteLine("--------------------------------------------------------------");
        }

        public static void RunSingleFactory()
        {
            Console.WriteLine("\n------------------------SINGLE FACTORY------------------------");

            SingleFactoryPattern singleFactoryPattern = new SingleFactoryPattern();
            singleFactoryPattern.RunExample();

            Console.WriteLine("--------------------------------------------------------------");
        }
    }

    interface IPattern
    {
        void RunExample();
    }
}
