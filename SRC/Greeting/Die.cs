using Command.Abstracts;
using System.Collections.Generic;
using Command;
using System;

namespace Greeting
{
    public class Die : Command.CommandBase
    {
        public override List<string> Answers =>
            new List<string>
            {
                "OK",
                "chashm"
            };

        public override List<string> Keys =>
            new List<string>
            {
                "\bBemir kookoo\b"                
            };

        public override string OwnerPlugin => "Greeting";

        public override string Topic => "My Life";

        public override void DoJob()
        {
            base.DoJob();
            Requirements.TextToSpeech.Speak(GetRandomAnswer());
        }

        public Die(IRequirements requirements) : base(requirements)
        {
        }
    }
}
