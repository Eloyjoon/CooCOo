using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooCoo;

namespace Greeting
{
    public class Test:CommandBase
    {
        public override List<string> Answers =>
            new List<string>
            {
                "Yes He is great",
                "Yes baby"
            };

        public override List<string> Keys =>
            new List<string>
            {
                "Behtarin Sina"
            };

        public override string OwnerPlugin => "Greeting";

        public override string Topic => "Test";

        public Test(IRequirements requirements) : base(requirements)
        {
        }
    }
}
