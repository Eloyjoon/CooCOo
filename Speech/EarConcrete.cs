using System;
using System.Collections.Generic;
using System.Speech.Recognition;
using CooCoo;
using CooCoo.Parts;

namespace Ear
{
    public class EarConcrete : IEar
    {
        private IBrain _brain;
        readonly SpeechRecognitionEngine _speechRecognizer = new SpeechRecognitionEngine();
        public void Init()
        {
            Grammar grammar = CreateGrammar(_brain);

            _speechRecognizer.UnloadAllGrammars();
            _speechRecognizer.LoadGrammar(grammar);
            _speechRecognizer.EndSilenceTimeout = new TimeSpan(0, 0, 0, 1);
            try
            {
                _speechRecognizer.SetInputToDefaultAudioDevice();

            }
            catch (Exception e)
            {
                throw new Exception("Plz Plugin the mic",e);
            }
            _speechRecognizer.SpeechDetected += _speechRecognizer_SpeechDetected;
            _speechRecognizer.SpeechRecognized += SpeechRecognizer_SpeechRecognized;
        }

        private void _speechRecognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            
        }

        public event CommandRecievedHandler CommandRecieved;
        protected virtual void OnCommandRecieved(string key)
        {
            CommandRecieved?.Invoke(key);
        }

        public EarConcrete(IBrain brain)
        {
            _brain = brain;
        }

        private Grammar CreateGrammar(IBrain brain)
        {
            List<string> lstChoices = new List<string>();
            
            foreach (var item in brain.Memory.Commands)
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
