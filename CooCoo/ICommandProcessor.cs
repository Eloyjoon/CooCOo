namespace CooCoo
{
    public interface ICommandProcessor
    {
        IModuleLoader ModuleLoader { get;}
        void ProcessCommands(string key);
    }
}