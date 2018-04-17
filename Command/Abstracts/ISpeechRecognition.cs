namespace Command.Abstracts
{
    public interface ISpeechRecognition
    {
        ICommandProcessor CommandProcessor { get;}
        event CommandRecievedHandler CommandRecieved;
        void StartRecognition();
        void StopRecognition();
    }
}