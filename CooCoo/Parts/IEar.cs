namespace CooCoo.Parts
{
    public interface IEar
    {
        void Init();

        event CommandRecievedHandler CommandRecieved;
        void StartRecognition();
        void StopRecognition();
    }
}
