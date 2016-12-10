using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    abstract class Prototype
    {
        public string Id { get; private set; }

        public Prototype(string id)
        {
            Id = id;
        }

        public abstract Prototype Clone();
    }

    class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();
        }
    }

    partial class Usage
    {
        public static void TestPrototype()
        {
            var p1 = new ConcretePrototype("rer");
            ConcretePrototype c1 = (ConcretePrototype)p1.Clone();
        }
    }
}
