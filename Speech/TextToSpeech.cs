using Command.Abstracts;
using System.Speech.Synthesis;


namespace Speech.TTS
{
    public class TextToSpeech : ITextToSpeech
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
