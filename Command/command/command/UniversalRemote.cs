using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class UniversalRemote
    {
        private readonly Command _onCommand;
        private readonly Command _offCommand;
        private readonly Command _volumeUpCommand;
        private readonly Command _volumeDownCommand;

        public UniversalRemote(Command onCommand, Command offCommand,
            Command volumeUpCommand, Command volumeDownCommand)
        {
            _onCommand = onCommand;
            _offCommand = offCommand;
            _volumeDownCommand = volumeDownCommand;
            _volumeUpCommand = volumeUpCommand;
        }

        public void On()
        {
            _onCommand.Execute();
        }

        public void Off()
        {
            _offCommand.Execute();
        }

        public void VolumeUp()
        {
            _volumeUpCommand.Execute(); 
        }

        public void VolumeDown()
        {
            _volumeDownCommand.Execute();   
        }
    }
}
