using System;
using System.Collections.Generic;
using System.Speech.Recognition;
using CooCoo;
using CooCoo.Parts;

namespace Ear
{
    public class EarConcrete : IEar
    {
        readonly SpeechRecognitionEngine _speechRecognizer = new SpeechRecognitionEngine();        
        public event CommandRecievedHandler CommandRecieved;
        protected virtual void OnCommandRecieved(string key)
        {
            CommandRecieved?.Invoke(key);
        }

        public EarConcrete(IModuleLoader moduleLoader)
        {
            Grammar grammar = CreateGrammar(moduleLoader);

            _speechRecognizer.UnloadAllGrammars();
            _speechRecognizer.LoadGrammar(grammar);
            _speechRecognizer.EndSilenceTimeout = new TimeSpan(0, 0, 0, 1);
            _speechRecognizer.SetInputToDefaultAudioDevice();
            _speechRecognizer.SpeechRecognized += SpeechRecognizer_SpeechRecognized;
        }

        private Grammar CreateGrammar(IModuleLoader moduleLoader)
        {
            List<string> lstChoices = new List<string>();
            
            foreach (var item in moduleLoader.CommandsList)
            {
                lstChoices.AddRange(item.Keys);
            }
            Choices choices = new Choices(lstChoices.ToArray());
            GrammarBuilder builder = new GrammarBuilder(choices);
            Grammar grammar = new Grammar(builder);
            return grammar;
        }

        public void StartRecognition()
        {
            _speechRecognizer.RecognizeAsync(RecognizeMode.Multiple); 
        }
        public void StopRecognition()
        {
            _speechRecognizer.RecognizeAsyncCancel();
        }
        private void SpeechRecognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            var test = e.Result.Text;
            OnCommandRecieved(test);
        }
    }
}
