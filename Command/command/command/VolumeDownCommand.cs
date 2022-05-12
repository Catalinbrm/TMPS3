using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class VolumeDownCommand : Command
    {
        private readonly Speaker _speaker;
        public VolumeDownCommand(Speaker speaker)
        {
            _speaker = speaker;
        }

        public override void Execute()
        {
            _speaker.VolumeDown();
        }
    }
}
