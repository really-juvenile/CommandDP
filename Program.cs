namespace CommandDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();   

            ICommand onCommand = new OnCommand(tv);
            ICommand offCommand = new OffCommand(tv);

            RemoteControl remoteControl1 = new RemoteControl();

            remoteControl1.SetCommand(onCommand);
            remoteControl1.SetCommand(offCommand);

            remoteControl1.PressButton();
            remoteControl1.PressButton();
        }
    }
}
