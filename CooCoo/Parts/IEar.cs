namespace CooCoo.Parts
{
    public interface IEar
    {
        event CommandRecievedHandler CommandRecieved;
        void StartRecognition();
        void StopRecognition();
    }
}
