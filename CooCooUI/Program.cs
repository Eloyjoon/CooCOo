using System;
using CooCoo;
using CooCoo.Parts;
using Unity;
//Comment
namespace CooCooUI
{
    class Program
    {
        public static IUnityContainer UnityContainer { get; set; }

        private static IBody Body { get; set; }

        static void Main(string[] args)
        {
            ComposeModel();

            Body = UnityContainer.Resolve<IBody>();

           // Body.Ear.CommandRecieved += Speech_CommandRecieved;
           // Body.Ear.StartRecognition();

            Console.Read();
        }

        private static void ComposeModel()
        {
            UnityContainer = new UnityContainer();

            UnityContainer.AddNewExtension<Brain.UnityExtension>();
            UnityContainer.AddNewExtension<Ear.UnityExtension>();
            UnityContainer.AddNewExtension<Mouth.UnityExtension>();
            UnityContainer.AddNewExtension<Body.UnityExtension>();
        }
    }
}
