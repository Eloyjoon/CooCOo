using Command;
using Command.Abstracts;
using Command.Concrete;
using Speech;
using Speech.TTS;
using Unity;
using Unity.Injection;
using Unity.Registration;

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

                Factory.RegisterType<ITextToSpeech, TextToSpeech>();
                Factory.RegisterType<ISpeechRecognition, SpeechRecognition>();
                Factory.RegisterType<ITelegramBot, Telegram.CooCooBot>();
                Factory.RegisterType<IModuleLoader, ModuleLoader>();
                
               // var tts=new InjectionParameter(Factory.Resolve<ITextToSpeech>());
               // var speech= new InjectionParameter(Factory.Resolve<SpeechRecognition>());
                Factory.RegisterType<IRequirements, Requirements>();

                Factory.RegisterType<ICommandProcessor, CommandProcessor>();


                



            }
        }
    }
}