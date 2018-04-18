using System.Collections.Generic;
using Command.Abstracts;

namespace Command.Abstracts
{
    public interface ICommandProcessor
    {
        IModuleLoader ModuleLoader { get;}
        void ProcessCommands(string key);
    }
}