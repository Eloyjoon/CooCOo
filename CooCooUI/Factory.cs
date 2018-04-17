using Command;
using Command.Abstracts;
using Command.Concrete;
using Speech;
using Speech.TTS;
using Telegram;
using Unity;
using Unity.Injection;
using Unity.Registration;
using Unity.Resolution;

namespace CooCooUI
{
    partial class Program
    {
        public class UnityFactory
        {
            public IUnityContainer Factory { get; }

            public UnityFactory()
            {
                if (Factory!=null) return;

                Factory=new UnityContainer();

                Factory.RegisterType<IModuleLoader, ModuleLoader>(new Unity.Lifetime.ContainerControlledLifetimeManager());                
                Factory.RegisterType<ITextToSpeech, TextToSpeech>(new Unity.Lifetime.ContainerControlledLifetimeManager());
                Factory.RegisterType<ISpeechRecognition, SpeechRecognition>(new Unity.Lifetime.ContainerControlledLifetimeManager());
                Factory.RegisterType(typeof(ITelegramBot), typeof(CooCooBot), new Unity.Lifetime.ContainerControlledLifetimeManager());
                Factory.RegisterType(typeof(IRequirements), typeof(Requirements), new Unity.Lifetime.ContainerControlledLifetimeManager());
                Factory.RegisterType(typeof(ICommandProcessor), typeof(CommandProcessor), new Unity.Lifetime.ContainerControlledLifetimeManager() ); 
            }
        }
    }
}