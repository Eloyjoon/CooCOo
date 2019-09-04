using System.Speech.Synthesis;
using CooCoo;
using CooCoo.Parts;

namespace Mouth
{
    public class TextToSpeech : IMouth
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
