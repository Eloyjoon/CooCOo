using System.IO;

namespace CooCoo
{
    public delegate void CommandRecievedHandler(string key);
    public delegate void MessageRecievedHandler(Stream audio, string text);
}
