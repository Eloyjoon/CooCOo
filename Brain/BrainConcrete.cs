using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
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
                        var isPlugin = item.BaseType == typeof(CommandBase);
                        if (!isPlugin) continue;
                        var instance = Activator.CreateInstance(item) as CommandBase;
                        Memory.Commands.Add(instance);
                    }

                }
            }
        }

        public string GetAnswer(string command)
        {
            var commandBase = Memory.Commands.First(a => a.Keys.Contains(command));
            return commandBase.Answers.First();
        }

        private void ClearMemory()
        {
            Memory.Commands.Clear();
        }
    }
}
