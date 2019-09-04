using CooCoo;
using CooCoo.Parts;

namespace Command
{
    public class CommandProcessor : ICommandProcessor
    {
        private IModuleLoader _ModuleLoader;
        public IModuleLoader ModuleLoader => _ModuleLoader;
        public IBrain Brain { get; }
        public CommandProcessor(IModuleLoader moduleLoader, IBrain brain)
        {
            _ModuleLoader = moduleLoader;
            Brain = brain;
        }
        public void ProcessCommands(string key)
        {
            if (Brain.State == State.Disabled && (key.ToLower() != "start coocoo" && key.ToLower() != "state coocoo")) return;

            foreach (var command in ModuleLoader.CommandsList)
            {
                if (!command.Equals(key)) continue;
                command.DoJob();
                Brain.Memory.PreviousCommand = command;
                return;

            }
        }
    }
}
