using Command;
using System.Collections.Generic;
using CooCoo;

namespace Greeting
{
    public class GoodBye:CommandBase
    {
        public override List<string> Keys => 
            new List<string>
            {
                //@"\bGoodBye\b.*\bCooCoo\b",
                //@"\bBye\b.*\bCooCoo\b",
                //@"\bKhodafez\b.*\bCooCoo\b"
                
                "Khodafez CooCoo"
            };

        public override List<string> Answers =>
            new List<string>
            {
                "Goodbye. I shut myself down"
            };

        public override string OwnerPlugin => "Greeting";
        public override string Topic => "You said goodbye";

        public override void DoJob()
        {
            base.DoJob();
        }

        public GoodBye(IRequirements requirements) : base(requirements)
        {
        }
    }
}
