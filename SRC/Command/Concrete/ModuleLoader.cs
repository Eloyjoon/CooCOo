using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Abstracts;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Command.Concrete
{
    public class ModuleLoader : Abstracts.IModuleLoader
    {
        private static List<CommandBase> _commandsList;

        public IEnumerable<CommandBase> CommandsList
        {
            get
            {
                return _commandsList;
            }
        }

        public void LoadModules(IRequirements requirements)
        {
            if (_commandsList != null) return;

            _commandsList = new List<CommandBase>();
            LoadEmbededModules(_commandsList, requirements);
            var directories = Directory.GetDirectories(Application.StartupPath + @"\Plugins");
            foreach (var directory in directories)
            {
                //تمام فایل های فولدر پلاگین را میخواند
                var files = Directory.GetFiles(directory).ToList();
                foreach (var file in files)
                {
                    if (!file.Contains(".dll") && !file.Contains(".coocoo")) continue;

                    if (file.Contains("coocoo"))//TODO: چک کند آیا فایل دی ال ال به ازای این مورد وجود دارد یا خیر. سپس بر اساس تاریخ آن معین کند که باید کامپایل بشود یا نه
                    {
                        continue;
                        var compiler = new RuntimeCompiler(File.ReadAllText(file), file);
                        compiler.Compile();

                        //فایل پلاگین را لود میکند
                        var newPluginAssembly = Assembly.LoadFile(file.Replace("coocoo", "dll"));
                        var newTypes = newPluginAssembly.GetTypes();
                        //اگر تایپ لود شده متناسب با تایپ مورد نظر ما بود، آنرا ست میکند
                        foreach (var item in newTypes)
                        {
                            var isTheRightType = item.BaseType == typeof(CommandBase);
                            if (!isTheRightType) continue;
                            var instance = Activator.CreateInstance(item, requirements) as CommandBase;
                            _commandsList.Add(instance);
                        }
                    }
                    else
                    {
                        //فایل پلاگین را لود میکند
                        var pluginAssembly = Assembly.LoadFile(file);
                        //تمام کلاس های داخل پلاگین را لود میکند
                        var types = pluginAssembly.GetTypes();

                        //اگر تایپ لود شده متناسب با تایپ مورد نظر ما بود، آنرا ست میکند
                        foreach (var item in types)
                        {
                            var isTheRightType = item.BaseType == typeof(CommandBase);
                            if (!isTheRightType) continue;
                            var instance = Activator.CreateInstance(item, requirements) as CommandBase;
                            _commandsList.Add(instance);
                        }
                    }
                }
            }
        }
        private void LoadEmbededModules(List<CommandBase> list, IRequirements requirements)
        {
            list.Add(new EmbededCommands.Disable(requirements));
            list.Add(new EmbededCommands.Enable(requirements));
            list.Add(new EmbededCommands.RecognitionState(requirements));
            list.Add(new EmbededCommands.ConversationTopic(requirements));
            list.Add(new EmbededCommands.Search(requirements));
        }
    }
}
