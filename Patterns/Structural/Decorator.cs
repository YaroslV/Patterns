using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    abstract class Decorator: DecComponent
    {
        protected DecComponent Component;
        public override void Operation()
        {
            Component?.Operation();
        }

        public Decorator(DecComponent c)
        {
            this.Component = c;
        }
    }

    abstract class DecComponent
    {
        public abstract void Operation();
    }

    class ConcretedDecComponent: DecComponent
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent operation");
        }
    }

    class ConcreteDecorator : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorator dehaviour added");
        }

        public ConcreteDecorator(DecComponent c) : base(c)
        {
        }
    }

    class ConcretedDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcretedDecoratorB behavoior");
        }

        public ConcretedDecoratorB(DecComponent c) : base(c)
        {
        }
    }

    class TestDecorator
    {
        public static void Run()
        {
            var d = new ConcretedDecoratorB(new ConcretedDecoratorB(new ConcretedDecComponent()));
            var moreDecorator = new ConcreteDecorator(d);
            moreDecorator.Operation();
        }
    }

}
