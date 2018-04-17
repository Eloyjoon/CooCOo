using Command.Abstracts;
using System.Collections.Generic;

namespace Command.EmbededCommands
{
    public class Search : CommandBase
    {
        public override List<string> Keys =>
            new List<string>
            {
                @"Search *",
            };
        public override List<string> Answers =>
            new List<string>
            {
                @"I will search"
            };
        public override string OwnerPlugin => "Core";
        public override string Topic => "You wanted to search";

        public override void DoJob()
        {
            base.DoJob();
            Requirements.TextToSpeech.Speak(GetRandomAnswer());
        }
        public Search(IRequirements requirements) : base(requirements)
        {
        }
    }
}
