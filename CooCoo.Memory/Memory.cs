using CooCoo.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CooCoo.Memory
{
    internal class Memory : IMemory
    {
        public Memory()
        {
            if (Commands == null)
                Commands = new List<CommandBase>();
        }
        public string Topic { get; set; }
        public CommandBase PreviousCommand { get; set; }
        public List<CommandBase> Commands { get; set; }
    }
}
