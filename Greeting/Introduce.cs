using Command;
using System.Collections.Generic;
using CooCoo;

namespace Greeting
{
    public class Introduce : CommandBase
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

        }

        public Introduce(IRequirements requirements) : base(requirements)
        {
        }
    }
}