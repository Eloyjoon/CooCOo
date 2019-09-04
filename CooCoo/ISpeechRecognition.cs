namespace CooCoo
{
    public interface ISpeechRecognition
    {
        event CommandRecievedHandler CommandRecieved;
        void StartRecognition();
        void StopRecognition();
    }
}