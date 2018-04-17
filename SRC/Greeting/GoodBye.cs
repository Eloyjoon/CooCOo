using Command;
using Command.Abstracts;
using System.Collections.Generic;

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
                "Goodbye CooCoo"
            };

        public override string OwnerPlugin => "Greeting";
        public override string Topic => "You said goodbye";

        public override void DoJob()
        {
            base.DoJob();
            Requirements.TextToSpeech.Speak("Goodbye. I shut myself down");
        }

        public GoodBye(IRequirements requirements) : base(requirements)
        {
        }
    }
}
