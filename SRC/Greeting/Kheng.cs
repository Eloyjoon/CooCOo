using Command;
using Command.Abstracts;
using System.Collections.Generic;

namespace Greeting
{
    public class Kheng : Command.CommandBase
    {
        public override List<string> Answers =>
            new List<string>
            {
                "Yes I am",
                "midoonam"
            };

        public override List<string> Keys =>
            new List<string>
            {
                "kheylii khengii Kookoo",
                "cheraa enghaad to kengii KooKoo?"
            };

        public override string OwnerPlugin => "Greeting";
        public override string Topic => "Me";
        public override void DoJob()
        {
            base.DoJob();
            Requirements.TextToSpeech.Speak(GetRandomAnswer());
        }

        public Kheng(IRequirements requirements) : base(requirements)
        {
        }
    }
}
