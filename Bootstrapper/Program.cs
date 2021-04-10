using CooCoo.Parts;
using System;
using Unity;

namespace Bootstrapper
{
    class Program
    {
        private static IUnityContainer UnityContainer { get; set; }

        static void Main(string[] args)
        {
            ComposeModel();

            var Body = UnityContainer.Resolve<IBody>();

             Body.Ear.CommandRecieved += Speech_CommandRecieved;
             Body.Ear.StartRecognition();

            Console.Read();

            Console.WriteLine("Hello World!");
        }

        private static void Speech_CommandRecieved(string key)
        {
            throw new NotImplementedException();
        }

        private static void ComposeModel()
        {
            UnityContainer = new UnityContainer();

            UnityContainer.AddNewExtension<CooCoo.Body.Extensions>();
            UnityContainer.AddNewExtension<CooCoo.Brain.Extensions>();
            UnityContainer.AddNewExtension<CooCoo.Ear.Extensions>();
            UnityContainer.AddNewExtension<CooCoo.Memory.Extensions>();
            UnityContainer.AddNewExtension<CooCoo.Mouth.Extensions>();
        }
    }
}
