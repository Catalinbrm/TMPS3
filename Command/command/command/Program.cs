using Program;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            PanasonicTv tv = new PanasonicTv();
            Speaker speaker = new Speaker();

            Command onCommand = new OnCommand(tv);
            Command offCommand = new OffCommand(tv);

            Command volumeUpCommand = new VolumeUpCommand(speaker, 10);
            Command volumeDownCommand = new VolumeDownCommand(speaker);
            

            UniversalRemote remote = new UniversalRemote(onCommand, offCommand,
                volumeUpCommand, volumeDownCommand);

            remote.On();
            remote.VolumeUp();
        }
    }
}