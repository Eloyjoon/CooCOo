using System;
using System.Linq;
using Command;
using Command.Concrete;
using CooCoo;
using CooCoo.Parts;
using Telegram;
using Unity;
using Unity.RegistrationByConvention;

namespace CooCooUI
{
    partial class Program
    {
        public static IUnityContainer UnityContainer { get; private set; }

        static void Main(string[] args)
        {
            ComposeModel();

            var test = UnityContainer.Resolve<IModuleLoader>();
            test.LoadModules(UnityContainer.Resolve<IRequirements>());

            //singleton

            UnityContainer.Resolve<IEar>().CommandRecieved += Speech_CommandRecieved;
            UnityContainer.Resolve<IEar>().StartRecognition();

            //singleton
            UnityContainer.Resolve<ITelegramBot>().MessageRecieved += CooCooBot_MessageRecieved;

            Console.Read();

        }

        private static void ComposeModel()
        {
            UnityContainer = new UnityContainer();

            UnityContainer.RegisterType<IModuleLoader, ModuleLoader>(new Unity.Lifetime.ContainerControlledLifetimeManager());
            UnityContainer.RegisterType<IMouth, Mouth.TextToSpeech>(new Unity.Lifetime.ContainerControlledLifetimeManager());
            UnityContainer.RegisterType<IEar, Ear.EarConcrete>(new Unity.Lifetime.ContainerControlledLifetimeManager());
            UnityContainer.RegisterType(typeof(ITelegramBot), typeof(CooCooBot), new Unity.Lifetime.ContainerControlledLifetimeManager());
            UnityContainer.RegisterType(typeof(IRequirements), typeof(Requirements), new Unity.Lifetime.ContainerControlledLifetimeManager());
            UnityContainer.RegisterType(typeof(ICommandProcessor), typeof(CommandProcessor), new Unity.Lifetime.ContainerControlledLifetimeManager());


            UnityContainer.AddNewExtension<Brain.UnityExtension>();
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
