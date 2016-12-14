using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioural
{
    abstract class Command
    {
        public Receiver Receiver { get; set; }
        public abstract void Execute();
    }

    class ConcreteCommand: Command
    {
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }

    class Invoker
    {
        public Command Command { get; set; }

        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
    

    class Receiver
    {
        public void Execote()
        {
            
        }
    }

    class CommandTest
    {
        public void Run()
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand();
            command.Receiver = receiver;
            Invoker invoker = new Invoker();
            invoker.Command = command;


        }
    }
    
}
