using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooCoo;

namespace Greeting
{
    public class Hamid:CommandBase
    {
        public override List<string> Answers =>
            new List<string>
            {
                "OK"
            };

        public override string Topic => "asd";

        public override List<string> Keys =>
            new List<string>
            {
                "Chetori Hamid"
            };
    }
}
