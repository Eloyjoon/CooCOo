namespace CooCoo
{
    public interface IRequirements
    {
        IMouth TextToSpeech { get;   }
        ITelegramBot TelegramBot { get;  }        

    }
}
