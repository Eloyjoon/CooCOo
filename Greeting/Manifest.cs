using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginBase;

namespace Greeting
{
    public class Manifest : IPluginManifest
    {
        public string PersianPluginName => "احوالپرسی";
        public string EnglishPluginName => "Greeting";
        public string Description => "فرمان های مقدماتی مربوط به سلام و احوالپرسی و معرفی";
    }
}