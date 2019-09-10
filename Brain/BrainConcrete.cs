using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Windows.Forms;
using Command;
using CooCoo;
using CooCoo.Parts;

namespace Brain
{
    internal class BrainConcrete : IBrain
    {
        public BrainConcrete(IMemory memory)
        {
            Memory = memory;
        }

        public IMemory Memory { get;}

        public State State { get; set; }

        public void LoadDataIntoMemory()
        {
            ClearMemory();

            var directories = Directory.GetDirectories(Application.StartupPath + @"\Plugins");

            foreach (var directory in directories)
            {
                //تمام فایل های فولدر پلاگین را میخواند
                var files = Directory.GetFiles(directory).ToList();
                foreach (var file in files)
                {
                    if (!file.Contains(".dll")) continue;

                    //فایل پلاگین را لود میکند
                    var pluginAssembly = Assembly.LoadFile(file);
                    //تمام کلاس های داخل پلاگین را لود میکند
                    var types = pluginAssembly.GetTypes();

                    //اگر تایپ لود شده متناسب با تایپ مورد نظر ما بود، آنرا ست میکند
                    foreach (var item in types)
                    {
                        var isManifest = item.BaseType == typeof(IPluginManifest);

                        if (isManifest)
                        {
                            var manifest = Activator.CreateInstance(item) as IPluginManifest;
                            Memory.Plugins.Add(manifest);
                        }
                        else
                        {
                            var isPlugin = item.BaseType == typeof(CommandBase);
                            if (!isPlugin) continue;
                            var instance = Activator.CreateInstance(item) as CommandBase;
                            Memory.Commands.Add(instance);
                        }
                    }

                }
            }
        }

        private void ClearMemory()
        {
            Memory.Plugins.Clear();
            Memory.Commands.Clear();
        }
    }
}
