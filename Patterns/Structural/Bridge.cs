using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    abstract class Implementor
    {
        public abstract void Operation();
    }

    abstract class Abstraction
    {
        public Implementor implementor { get; set; }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    class ConcreteImplementor : Implementor
    {
        public override void Operation()
        {
            // Smth
        }
    }

    class ConreteAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }

    class TestBridge
    {
        public static void Run()
        {
            var abstraction = new ConreteAbstraction();
            abstraction.implementor = new ConcreteImplementor();
            abstraction.Operation();
        }
    }
}
