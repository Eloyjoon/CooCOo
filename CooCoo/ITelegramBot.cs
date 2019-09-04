namespace CooCoo
{
    public interface ITelegramBot
    {
        event MessageRecievedHandler MessageRecieved;
        void SendMessage();
    }
}
