using System.Collections.Generic;
using CooCoo;

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
        }
        public Search(IRequirements requirements) : base(requirements)
        {
        }
    }
}
