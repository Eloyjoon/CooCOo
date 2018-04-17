using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Abstracts
{
    public delegate void CommandRecievedHandler(string key);
    public delegate void MessageRecievedHandler(Stream audio, string text);

}
