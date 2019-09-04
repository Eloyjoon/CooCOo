namespace CooCoo
{
    public interface IRequirements
    {
        ITextToSpeech TextToSpeech { get;   }
        ITelegramBot TelegramBot { get;  }        

    }
}
