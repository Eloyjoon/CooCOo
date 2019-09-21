using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooCoo;
using CooCoo.Parts;

namespace Brain
{
    public class MemoryConcrete:IMemory
    {
        public MemoryConcrete()
        {
            if (Commands==null)
                Commands=new List<CommandBase>();
        }
        public string Topic { get; set; }
        public CommandBase PreviousCommand { get; set; }
        public List<CommandBase> Commands { get; set; }
    }
}
