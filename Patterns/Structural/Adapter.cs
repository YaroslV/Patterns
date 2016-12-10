using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    class Target
    {
        public virtual void Request()
        {
            
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
        }
    }


    class Adapter: Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    class Usage
    {
        public static void Test()
        {
            var target = new Adapter();
            target.Request();
        }
    }
}
