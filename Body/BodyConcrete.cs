using CooCoo.Parts;

namespace Body
{
    internal class BodyConcrete:IBody
    {
        public BodyConcrete(IBrain brain, IEar ear, IMouth mouth)
        {
            Brain = brain;
            brain.LoadDataIntoMemory();

            Ear = ear;
            ear.Init();
            ear.CommandRecieved += Ear_CommandRecieved;
            ear.StartRecognition();

            Mouth = mouth;
        }

        private void Ear_CommandRecieved(string key)
        {
            Ear.StopRecognition();
            var answer=Brain.GetAnswer(key);
            Mouth.Speak(answer);
            Ear.StartRecognition();
        }

        public IBrain Brain { get; }
        public IEar Ear { get; }
        public IMouth Mouth { get; }

    }
}
