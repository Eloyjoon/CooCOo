using System;
using CooCoo;
using Unity;

namespace CooCooUI
{
    partial class Program
    {
        private static IUnityContainer _Factory;
        public static IUnityContainer Factory
        {
            get
            {
                if (_Factory==null)
                {
                    _Factory = new UnityFactory().Factory;
                }

                return _Factory;

            }
        }
        static void Main(string[] args)
        {
            var test = Factory.Resolve<IModuleLoader>();
            test.LoadModules(Factory.Resolve<IRequirements>());

            //singleton
           
            Factory.Resolve<IEar>().CommandRecieved += Speech_CommandRecieved;
            Factory.Resolve<IEar>().StartRecognition();

            //singleton
            Factory.Resolve<ITelegramBot>().MessageRecieved += CooCooBot_MessageRecieved;

            Console.Read();

        }

        private static void CooCooBot_MessageRecieved(System.IO.Stream audio, string text)
        {
            //singleton
            Factory.Resolve<IEar>().StopRecognition();

            //singleton
            Factory.Resolve<ICommandProcessor>().ProcessCommands(text);

            //singleton
            Factory.Resolve<IEar>().StartRecognition();
        }

        private static void Speech_CommandRecieved(string key)
        {
            //singleton
            Factory.Resolve<IEar>().StopRecognition();

            //singleton
            Factory.Resolve<ICommandProcessor>().ProcessCommands(key);

            //singleton
            Factory.Resolve<IEar>().StartRecognition();            
        }
    }
}
