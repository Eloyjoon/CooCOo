using System;
using Speech;
using Unity;
using Command.Abstracts;
using Command;

namespace CooCooUI
{
    partial class Program
    {
        static ICommandProcessor commandProcessor;
        static ISpeechRecognition speech;

        public static IUnityContainer Factory=>new UnityFactory().Factory;
        static void Main(string[] args)
        {
            Factory.Resolve<IModuleLoader>().LoadModules(Factory.Resolve<IRequirements>());
            commandProcessor = Factory.Resolve<ICommandProcessor>();



            speech = Factory.Resolve<SpeechRecognition>();
            speech.CommandRecieved += R_CommandRecieved;
            speech.StartRecognition();


          //  Telegram.CooCooBot cooCooBot = new Telegram.CooCooBot();
          //  cooCooBot.MessageRecieved += CooCooBot_MessageRecieved;

            Console.Read();

        }

        private static void CooCooBot_MessageRecieved(System.IO.Stream audio, string text)
        {
            speech.StopRecognition();
            
            commandProcessor.ProcessCommands(text);
            speech.StartRecognition();
        }

        private static void R_CommandRecieved(string key)
        {
            speech.StopRecognition();
            commandProcessor.ProcessCommands(key);
            speech.StartRecognition();            
        }
    }
}
