using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioural
{
    abstract class State
    {
        public abstract void Handle(Context c);
    }

    class ConscreteStateA: State
    {
        public override void Handle(Context c)
        {
            c.State1 = new ConscreteStateA();
        }
     }

    class ConcreteStateB : State
    {
        public override void Handle(Context c)
        {
            c.State1 = new ConcreteStateB();
        }
    }

    class Context
    {
        public State State1 { get; set; }

        public Context(State state)
        {
            State1 = state;
        }

        public void Request()
        {
            State1.Handle(this);
        }
    }
}
