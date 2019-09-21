namespace CooCoo.Parts
{
    public interface IBrain
    {
        IMemory Memory { get; }
        State State { get; set; }
        void LoadDataIntoMemory();
    }
}