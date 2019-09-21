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
        public override string Topic => "Parisa";
    }
}
