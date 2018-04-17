using Command.Abstracts;
using System.Collections.Generic;

namespace Command.EmbededCommands
{
    public class Enable : CommandBase
    {
        public override List<string> Keys =>
            new List<string>
            {
                @"Start coocoo",
            };
        public override List<string> Answers =>
            new List<string>
            {
                @"Sure. I turn the speech recognition on"
            };
        public override string OwnerPlugin => "Core";
        public override string Topic => "You turned me on";
        public override void DoJob()
        {
            base.DoJob();
            Requirements.TextToSpeech.Speak(GetRandomAnswer());
            Brain.State = State.Enabled;
        }
        public Enable(IRequirements requirements) : base(requirements)
        {
        }
    }
}
