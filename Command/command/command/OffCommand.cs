using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class OffCommand : Command 
    {
        private readonly PanasonicTv _tv;

        public OffCommand(PanasonicTv tv)
        {
            _tv = tv;
        }

        public override void Execute()
        {
            _tv.Off();
        }
    }
}
