using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class PluginManifest
    {
        private string _persianPluginName;
        private string _englishPluginName;

        public virtual string PersianPluginName
        {
            get { return _persianPluginName; }
           // set { _persianPluginName = value; }
        }

        public virtual string EnglishPluginName
        {
            get { return _englishPluginName; }
           // set { _englishPluginName = value; }
        }
    }
}
