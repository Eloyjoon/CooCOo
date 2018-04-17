using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Abstracts
{
    public interface ITelegramBot
    {
        event MessageRecievedHandler MessageRecieved;
        void SendMessage();
    }
}
