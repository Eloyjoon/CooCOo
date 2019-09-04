using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooCoo;

namespace Command.Concrete
{
    public class Requirements : IRequirements
    {
        private IMouth _TextToSpeech;
        private ITelegramBot _TelegramBot;


        public Requirements(IMouth tts,ITelegramBot telegramBot)
        {
            _TextToSpeech = tts;
            _TelegramBot = telegramBot;
        }
        public ITelegramBot TelegramBot => _TelegramBot;
        public IMouth TextToSpeech => _TextToSpeech;
    }
}
