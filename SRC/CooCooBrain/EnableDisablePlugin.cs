using Command.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooCooBrain
{
    public class EnableDisablePlugin:Command.CommandBase
    {
        public EnableDisablePlugin(ITextToSpeech tts) : base(tts)
        {
        }

        public override List<string> Keys =>
            new List<string>
            {
                "Enable"
            };
        public override List<string> Answers { get; }
        public override string OwnerPlugin { get; }
        public override void DoJob()
        {
            throw new NotImplementedException();
        }
    }
}
