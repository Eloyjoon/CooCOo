using System.Collections.Generic;
using CooCoo;

namespace Greeting
{
    public class Die : CommandBase
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
                "Bemir kookoo"                
            };

        public override string Topic => "My Life";
    }
}
