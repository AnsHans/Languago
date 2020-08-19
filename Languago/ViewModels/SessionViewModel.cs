using Languago.Models;
using Languago.Models.orm;
using Languago.ViewModels.Commands;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Windows.Input;
using System.Diagnostics;
using System.Security.Policy;
using System.Runtime.InteropServices;
using Languago.Models.Protector;

namespace Languago.ViewModels
{
    public class SessionViewModel : BaseViewModel
    {

        SessionModel Session;
        LanguagoContext db;
        SpeechRecognizer recognizer;
        SpeechSynthesizer synthesizer;
        EventHandler<SpeechRecognitionEventArgs> onSpeechRecognized;
        
        public event EventHandler<bool> GotoAccount;

        public short Progress { get; set; }
        public string French { get; set; }
        public string English { get; set; }
        public string Example { get; set; }
        public string Grammar { get; set; }
        public string Pronunciation { get; set; }
        public ushort Word
        {
            get { return (ushort)(WordIndex + 1); }
        }
        public ushort Range { get 
            {
                return (ushort)(Session.CurrSession.WordUpperBoundary - Session.CurrSession.WordLowerBoundary + 1);
            } 
        }
        public float ProgressBar { get; set; }
        public ushort WordIndex { get; set; }

        RelayCommand _checkPronunCommand;
        RelayCommand _hearPronunCommand;
        RelayCommand _nextWordCommand;
        RelayCommand _previousWordCommand;
        RelayCommand _exitSessionCommand;
        public ICommand CheckPronunCommand
        {
            get
            {
                if (_checkPronunCommand == null)
                {
                    _checkPronunCommand = new RelayCommand(Check);
                }
                return _checkPronunCommand;
            }
        }
        public ICommand HearPronunCommand
        {
            get
            {
                if (_hearPronunCommand == null)
                {
                    _hearPronunCommand = new RelayCommand(Hear);
                }
                return _hearPronunCommand;
            }
        }
        public ICommand NextWordCommand
        {
            get
            {
                if (_nextWordCommand == null)
                {
                    _nextWordCommand = new RelayCommand(Next);
                }
                return _nextWordCommand;
            }
        }
        public ICommand PreviousWordCommand
        {
            get
            {
                if (_previousWordCommand == null)
                {
                    _previousWordCommand = new RelayCommand(Previous);
                }
                return _previousWordCommand;
            }
        }
        public ICommand ExitSessionCommand
        {
            get
            {
                if (_exitSessionCommand == null)
                {
                    _exitSessionCommand = new RelayCommand(Exit);
                }
                return _exitSessionCommand;
            }
        }

        public SessionViewModel(long UserID, LanguagoContext db, int dayNum)
        {
            this.db = db;
            this.Session = new SessionModel(UserID, db, dayNum);

            /* Configuration of speech recognition services */
            var keyclass = new API_KEYS();
            var config = SpeechConfig.FromSubscription(keyclass.SpeechRecognitionAPI, keyclass.SpeechRecognitionZONE);
            var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            this.recognizer = new SpeechRecognizer(config, "fr-FR", audioConfig);

            var outConfig = AudioConfig.FromDefaultSpeakerOutput();
            var autoDetectSourceLanguageConfig =
                AutoDetectSourceLanguageConfig.FromOpenRange();

            this.synthesizer = new SpeechSynthesizer(config, autoDetectSourceLanguageConfig, outConfig);
            WordIndex = 0;
            populateViewModel(WordIndex);
            
        }

        public void populateViewModel(ushort num)
        {
            English = Session.dictionary[num].English;
            French = Session.dictionary[num].French;
            Example = Session.dictionary[num].Example;
            Grammar = Session.dictionary[num].Grammar;
            Pronunciation = "";
            OnPropertyChanged(nameof(French));
            OnPropertyChanged(nameof(English));
            OnPropertyChanged(nameof(Example));
            OnPropertyChanged(nameof(Grammar));
            OnPropertyChanged(nameof(Pronunciation));
        }
        public void Hear(object parameter)
        {
            synthesizer.SpeakTextAsync(this.French);
        }
        public void Check(object parameter)
        {
            var result = recognizer.RecognizeOnceAsync();
            this.Pronunciation = result.Result.Text;
            OnPropertyChanged(nameof(Pronunciation));

        }
        public void Next(object parameter)
        {
            if(WordIndex < (Session.CurrSession.WordUpperBoundary - Session.CurrSession.WordLowerBoundary)) WordIndex++;
            populateViewModel(WordIndex);
            OnPropertyChanged(nameof(Word));
            ProgressBar = ((float)(WordIndex + 1) / (float)(Range))*100;
            OnPropertyChanged(nameof(ProgressBar));

        }
        public void Previous(object parameter)
        {
            if(WordIndex > 0) WordIndex--;
            populateViewModel(WordIndex);
            OnPropertyChanged(nameof(Word));
            ProgressBar = ((float)(WordIndex + 1) / (float)(Range)) * 100;
            OnPropertyChanged(nameof(ProgressBar));
        }
        public void Exit(object parameter)
        {
            GotoAccount?.Invoke(this, true);
        }

    }
}
