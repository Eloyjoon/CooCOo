using System;
using System.Linq;
using Command;
using CooCoo;
using CooCoo.Parts;
using PluginBase.Concrete;
using Unity;

namespace CooCooUI
{
    class Program
    {
        public static IUnityContainer UnityContainer { get; set; }

        static void Main(string[] args)
        {
            ComposeModel();

            var body = UnityContainer.Resolve<IBody>();

            UnityContainer.Resolve<IEar>().CommandRecieved += Speech_CommandRecieved;
            UnityContainer.Resolve<IEar>().StartRecognition();

            //singleton
            UnityContainer.Resolve<ITelegramBot>().MessageRecieved += CooCooBot_MessageRecieved;

            Console.Read();
        }

        private static void ComposeModel()
        {
            UnityContainer = new UnityContainer();
            
            UnityContainer.RegisterType(typeof(IRequirements), typeof(Requirements), new Unity.Lifetime.ContainerControlledLifetimeManager());
            UnityContainer.RegisterType(typeof(ICommandProcessor), typeof(CommandProcessor), new Unity.Lifetime.ContainerControlledLifetimeManager());

            UnityContainer.AddNewExtension<Brain.UnityExtension>();
            UnityContainer.AddNewExtension<Ear.UnityExtension>();
            UnityContainer.AddNewExtension<Mouth.UnityExtension>();
            UnityContainer.AddNewExtension<Body.UnityExtension>();
        }

        private static void CooCooBot_MessageRecieved(System.IO.Stream audio, string text)
        {
            //singleton
            UnityContainer.Resolve<IEar>().StopRecognition();

            //singleton
            UnityContainer.Resolve<ICommandProcessor>().ProcessCommands(text);

            //singleton
            UnityContainer.Resolve<IEar>().StartRecognition();
        }

        private static void Speech_CommandRecieved(string key)
        {
            //singleton
            UnityContainer.Resolve<IEar>().StopRecognition();

            //singleton
            UnityContainer.Resolve<ICommandProcessor>().ProcessCommands(key);

            //singleton
            UnityContainer.Resolve<IEar>().StartRecognition();            
        }
    }
}
