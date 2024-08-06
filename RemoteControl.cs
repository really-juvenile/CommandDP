using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    internal class RemoteControl
    {
        public ICommand Command { get; set; }

        public RemoteControl(ICommand command)
        {
            Command = command;
        }



        public void PressButton()
        {
            Command.Execute();
        }
    }
}
