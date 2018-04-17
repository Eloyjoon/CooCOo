using Command.Abstracts;
using System.Collections.Generic;

namespace Command.EmbededCommands
{
    public class RecognitionState : CommandBase
    {
        public override List<string> Keys =>
            new List<string>
            {
                @"State coocoo",
            };
        public override List<string> Answers =>
            new List<string>
            {
                @""
            };
        public override string OwnerPlugin => "Core";
        public override string Topic => "You asked for the speech recognition state";

        public override void DoJob()
        {
            base.DoJob();
            switch (Brain.State)
            {
                case State.Enabled:
                    Requirements.TextToSpeech.Speak("My State is Enabled");
                    break;
                case State.Disabled:
                    Requirements.TextToSpeech.Speak("My State is Disabled");
                    break;
                default:
                    break;
            }
            Brain.State = State.Enabled;
        }
        public RecognitionState(IRequirements requirements) : base(requirements)
        {
        }
    }
}
