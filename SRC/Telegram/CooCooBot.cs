using Command.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    public class CooCooBot: ITelegramBot
    {
        Telegram.Bot.TelegramBotClient bot = new Bot.TelegramBotClient("541502195:AAHLKL_xrP1r7N03ODDCEY3tjpjLXcxCSbg");

        public delegate void MessageRecievedHandler(Stream audio, string text);

        public event MessageRecievedHandler MessageRecieved;

        protected virtual void OnMessageRecieved(Stream audio,string text)
        {
            MessageRecieved?.Invoke(audio, text);
        }
        public CooCooBot()
        {
            bot.OnMessage += Bot_OnMessage;
            bot.StartReceiving();
        }

        private void Bot_OnMessage(object sender, Bot.Args.MessageEventArgs e)
        {

            if (e.Message.Audio!=null)
            OnMessageRecieved(e.Message.Audio.FileStream, "");
            else
            {
                    OnMessageRecieved(null, e.Message.Text);               

            }
        }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
