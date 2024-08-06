using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    internal class OnCommand : ICommand
    {
        private Television _tv { get; set; }
        public OnCommand(Television tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.On();
        }

    }
}
