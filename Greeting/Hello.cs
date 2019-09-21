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
        public override string Topic => "Hello";
    }
}
