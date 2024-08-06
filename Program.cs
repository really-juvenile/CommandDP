namespace CommandDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();   

            ICommand onCommand = new OnCommand(tv);
            ICommand offCommand = new OffCommand(tv);

            RemoteControl remoteControl1 = new RemoteControl(onCommand);
            RemoteControl remoteControl2 = new RemoteControl(offCommand);

            remoteControl1.PressButton();
            remoteControl2.PressButton();
        }
    }
}
