using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public abstract class Product
    {

    }

    public class ComctreteProduct : Product
    {
        
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class  ConcreteCreator: Creator
    {
        public override Product FactoryMethod()
        {
            return new ComctreteProduct();
        }
    }

    static partial class Usage
    {
        public static void Test()
        {
            var creator = new ConcreteCreator();
            var concreteProduct = creator.FactoryMethod();
        }
    }
}
