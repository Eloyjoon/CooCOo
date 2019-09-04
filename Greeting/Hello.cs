using Command;
using System;
using System.Collections.Generic;
using CooCoo;

namespace Greeting
{
    public class Hello:CommandBase
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
            
        }
        public Hello(IRequirements requirements) : base(requirements)
        {
        }


    }
}
