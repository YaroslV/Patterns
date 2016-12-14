using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Structural;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDecorator.Run();
            Console.ReadKey();
        }
    }

    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    public abstract class AbstractProductB
    {
    }

    public abstract class AbstractProductA
    {
    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ProductB1: AbstractProductB
    {
    }

    public class ProductA1 : AbstractProductA
    {
    }
}
