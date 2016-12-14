using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    abstract class Flyweight
    {
        public abstract void Operation();
    }

    class ConcretedFlyweight: Flyweight
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteFlyweight");
        }
    }

    class FlyweightFactory
    {
        private Hashtable _flyweights = new Hashtable();

        public FlyweightFactory()
        {
            _flyweights.Add('X', new ConcretedFlyweight());
            _flyweights.Add('C', new ConcretedFlyweight());
            _flyweights.Add('D', new ConcretedFlyweight());
            _flyweights.Add('E', new ConcretedFlyweight());
        }

        public Flyweight GetFlyweight(char key)
        {
            var flyweight = _flyweights[key];
            if (flyweight == null)
            {
                flyweight = new ConcretedFlyweight();
                _flyweights.Add(key, flyweight);
            }

            return (Flyweight) flyweight;
        }
    }

    class TestFlyweight
    {
        public static void Run()
        {
            var flyFactory = new FlyweightFactory();

            var getA = flyFactory.GetFlyweight('A');

            var getX = flyFactory.GetFlyweight('X');
        }
    }
}
