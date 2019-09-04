using System.Collections.Generic;
using CooCoo;

namespace Command.EmbededCommands
{
    public class Disable : CommandBase
    {
        public override List<string> Keys =>
            new List<string>
            {
                @"Stop coocoo",
            };
        public override List<string> Answers =>
            new List<string>
            {
                @"Sure. I turn the speech recognition off"
            };
        public override string OwnerPlugin => "Core";
        public override string Topic => "You turned me off";

        public override void DoJob()
        {
            base.DoJob();
            Brain.State = State.Disabled;
        }
        public Disable(IRequirements requirements) : base(requirements)
        {
        }
    }
}
