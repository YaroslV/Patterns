using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Test
    {
        public void TestMethod()
        {
            Builder b = new SnowBuilder();
            Director d = new Director();
            d.Construct(b);

            var r = b.GetResult();

        }
    }


    public abstract class Builder
    {
        public abstract void BuildPart1();
        public abstract void BuildPart2();
        public abstract Something GetResult();
    }

    public class Director
    {
        public Director()
        {
        }

        public void Construct(Builder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
        }
    }

    public class SnowBuilder :  Builder
    {
        private Something _product = new Something();
        public override void BuildPart1()
        {
            _product.partOne = "PartOneAdded";
        }

        public override void BuildPart2()
        {
            _product.partTwo = "PartTwo";
        }

        public override Something GetResult()
        {
            return _product;
        }
    }

    public class Something
    {
        public string partOne { get; set; }
        public string partTwo { get; set; }
    }
}
