using System.Collections.Generic;
using CooCoo;

namespace Command.EmbededCommands
{
    public class ConversationTopic : CommandBase
    {
        public override List<string> Keys =>
            new List<string>
            {
                @"What is the topic coocoo",
            };
        public override List<string> Answers =>
            new List<string>
            {
                @""
            };
        public override string OwnerPlugin => "Core";
        public override string Topic => "You asked for the topic";
        public override void DoJob()
        {
            base.DoJob();
            if (Brain.Memory.PreviousCommand == null)
                Requirements.TextToSpeech.Speak("we have no topic yet");
            else
                Requirements.TextToSpeech.Speak("the topic is:" + Brain.Memory.PreviousCommand.Topic);

        }
        public ConversationTopic(IRequirements requirements) : base(requirements)
        {
        }
    }
}
