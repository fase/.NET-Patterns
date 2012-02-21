using System;
using System.Linq;

namespace PatternsSandbox.Patterns
{
    class SingleFactoryPattern : IPattern
    {
        public void RunExample()
        {
            ICreator[] creators = {new RiskCreator(), new ComplianceCreator()};

            foreach (IProgram program in creators.Select(creator => creator.CreateProgram()))
            {
                Console.WriteLine("Created object of type {0}.", program.GetType().Name);
            }
        }
    }

    internal interface IProgram
    {
    }

    class RiskProgram : IProgram
    {
    }

    class ComplianceProgram : IProgram
    {
    }


    internal interface ICreator
    {
        IProgram CreateProgram();
    }

    class RiskCreator : ICreator
    {
        public IProgram CreateProgram()
        {
            return new RiskProgram();
        }
    }

    class ComplianceCreator : ICreator
    {
        public IProgram CreateProgram()
        {
            return new ComplianceProgram();
        }
    }
}
