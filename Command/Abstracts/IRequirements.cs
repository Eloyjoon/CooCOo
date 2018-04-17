using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Abstracts
{
    public interface IRequirements
    {
        ITextToSpeech TextToSpeech { get;   }
        ITelegramBot TelegramBot { get;  }        

    }
}
