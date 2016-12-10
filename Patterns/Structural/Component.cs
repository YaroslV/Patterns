using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    abstract class Component
    {
        protected string Name;

        protected Component(string name)
        {
            Name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }

    class Composite : Component
    {
        private List<Component> _childrenComponents = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            _childrenComponents.Add(c);
        }

        public override void Remove(Component c)
        {
            _childrenComponents.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            _childrenComponents.ForEach(c => c.Display(depth + 2 ));
        }
    }

    class Leaf: Component {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Can not add to leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Can not remove from leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }

    public class TestComposite
    {
        public static void Run()
        {
            var composite = new Composite("SuperRoot");
            composite.Add(new Leaf("leaf 1"));
            for (int i = 2; i < 10; i++)
            {
                composite.Add(new Leaf($"leaf no.{i}"));
            }

            var childComposite = new Composite("ChildComposite");
            for (int i = 0; i < 3; i++)
            {
                childComposite.Add(new Leaf($"leaf 2{i}"));
            }
            composite.Add(childComposite);
            composite.Display(1);
        }
    }
}
