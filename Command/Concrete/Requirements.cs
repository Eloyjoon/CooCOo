using CooCoo;
using CooCoo.Parts;

namespace PluginBase.Concrete
{
    public class Requirements : IRequirements
    {
        private IMouth _TextToSpeech;
        private ITelegramBot _TelegramBot;
        private IBrain _Brain;


        public Requirements(IMouth tts,ITelegramBot telegramBot,IBrain brain)
        {
            _TextToSpeech = tts;
            _TelegramBot = telegramBot;
            _Brain = brain;
        }
        public ITelegramBot TelegramBot => _TelegramBot;
        public IMouth TextToSpeech => _TextToSpeech;
        public IBrain Brain => _Brain;
    }
}
