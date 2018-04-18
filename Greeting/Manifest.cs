using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class Manifest : Command.PluginManifest
    {
        public override string PersianPluginName => "Brain";
        public override string EnglishPluginName => "CooCoo's Brain";
    }
}