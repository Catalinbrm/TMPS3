using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class VolumeUpCommand : Command 
    {
        private readonly Speaker _speaker;
        private readonly int _volume;
        public VolumeUpCommand(Speaker speaker, int volume)
        {
            _speaker = speaker;
            _volume = volume;   
        }

        public override void Execute()
        {
            _speaker.VolumeUp(_volume);
        }
    }
}
