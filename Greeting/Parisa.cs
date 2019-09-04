using Command;
using System.Collections.Generic;
using CooCoo;

namespace Greeting
{
    public class Parisa : CommandBase
    {
        public override List<string> Keys =>
            new List<string>
            {
                //@"\bHello\b.*\bCooCoo\b",
                //@"\bHello\b.*\bBoy\b",
                @"Parisa kiye KooKoo?"
                //"Salam",
                //"Salam kookoo",
                //"Hello CooCoo"
            };

        public override List<string> Answers =>
            new List<string>
            {
                @"Parisa is my mom."
            };
        public override string OwnerPlugin => "Greeting";
        public override string Topic => "Parisa";
        public override void DoJob()
        {
            base.DoJob();
        }
        public Parisa(IRequirements requirements) : base(requirements)
        {
        }
    }
}
