using CooCoo.Parts;
using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Text;

namespace CooCoo.Mouth
{
    internal class Mouth : IMouth
    {
        public void Speak(string stringToSpeak)
        {
            var tts = new SpeechSynthesizer();
            // tts.SelectVoice("microsoft_sam");
            // tts.SelectVoiceByHints(VoiceGender.NotSet,VoiceAge.Senior);
            //var asd123 = tts.GetInstalledVoices();

            tts.Speak(stringToSpeak);
        }
    }
}
