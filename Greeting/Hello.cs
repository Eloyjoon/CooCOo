using Command;
using Command.Abstracts;
using System;
using System.Collections.Generic;

namespace Greeting
{
    public class Hello:Command.CommandBase
    {
        public override List<string> Keys => 
            new List<string>
            {
                //@"\bHello\b.*\bCooCoo\b",
                //@"\bHello\b.*\bBoy\b",
                @"Salam KooKoo",
                "Salam",
                "Salam CooCoo",
                "Hello CooCoo"
            };
        public override List<string> Answers =>
            new List<string>
            {
                @"Hello! It is nice to meet you.",
                @"Hello. How are you?",
                @"Salam."
            };
        public override string OwnerPlugin => "Greeting";
        public override string Topic => "Hello";

        public override void DoJob()
        {
            base.DoJob();
            Requirements.TextToSpeech.Speak(GetRandomAnswer());
            
        }
        public Hello(IRequirements requirements) : base(requirements)
        {
        }
    }
}
