namespace Command.Abstracts
{
    public interface ISpeechRecognition
    {
        event CommandRecievedHandler CommandRecieved;
        void StartRecognition();
        void StopRecognition();
    }
}