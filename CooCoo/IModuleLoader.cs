using System.Collections.Generic;

namespace CooCoo
{
    public interface IModuleLoader
    {
        IEnumerable<CommandBase> CommandsList { get; }
        void LoadModules(IRequirements requirements);
    }
}
