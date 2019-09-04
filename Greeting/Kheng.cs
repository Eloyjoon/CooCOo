using Command;
using System.Collections.Generic;
using CooCoo;

namespace Greeting
{
    public class Kheng : CommandBase
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
        }

        public Kheng(IRequirements requirements) : base(requirements)
        {
        }
    }
}
