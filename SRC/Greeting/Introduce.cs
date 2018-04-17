using Command;
using Command.Abstracts;
using System.Collections.Generic;

namespace Greeting
{
    public class Introduce : Command.CommandBase
    {
        public override List<string> Keys =>
            new List<string>
            {
                "khodeto moarrefi kon kookoo"
            };
        public override List<string> Answers =>
            new List<string>
            {
                @"My name is CooCoo. I am a personal assistant robot, Created to become more intelligent. Nice to meet You!"
            };

        public override string OwnerPlugin => "Greeting";
        public override string Topic => "Me";


        public override void DoJob()
        {
            base.DoJob();
            Requirements.TextToSpeech.Speak(GetRandomAnswer());

        }

        public Introduce(IRequirements requirements) : base(requirements)
        {
        }
    }
}