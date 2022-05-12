using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Speaker
    {
        public void VolumeUp(int volume)
        {
            Console.WriteLine("Speaker Volume Up by " + volume);
        }

        public void VolumeDown()
        {
            Console.WriteLine("Speaker Volume Down");
        }
    }
}
