using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Input;
using Languago.Models;
using Languago.Models.DataStructures;
using Languago.Models.orm;
using Languago.ViewModels.Commands;

namespace Languago.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {
        AccountModel Account;
        RelayCommand _startNewSessionCommand;
        public event EventHandler<int> goToSession;
        //Revision section
        public short WordsToLearnToday { get; set; }
        public short WordsToRevise1daysago { get; set; }
        public short WordsToRevise3daysago { get; set; }
        public short WordsToRevise7daysago { get; set; }
        public short WordsToRevise30daysago { get; set; }
        public short WordsToRevise90daysago { get; set; }

        //Commands
        public ICommand StartNewSessionCommand
        {
            get
            {
                if (_startNewSessionCommand == null)
                {
                    _startNewSessionCommand = new RelayCommand(CreateNewSession);
                }
                return _startNewSessionCommand;
            }
        }


        public AccountViewModel(long UserID, LanguagoContext db)
        {
            Account = new AccountModel(UserID, db);
            WordsToLearnToday = Account.getAmmountOfWordsFromSession(0);
            WordsToRevise1daysago = Account.getAmmountOfWordsFromSession(1);
            WordsToRevise3daysago = Account.getAmmountOfWordsFromSession(3);
            WordsToRevise7daysago = Account.getAmmountOfWordsFromSession(7);
            WordsToRevise30daysago = Account.getAmmountOfWordsFromSession(30);
            WordsToRevise90daysago = Account.getAmmountOfWordsFromSession(90);
        }

        void CreateNewSession(object parameter)
        {
            int sessionDate = Int32.Parse(parameter as string);
            if (sessionDate == 0)
            {
                if (true == Account.AddNewSessionToDb(WordsToLearnToday))
                {
                    this.WordsToLearnToday = Account.getAmmountOfWordsFromSession(0);
                    OnPropertyChanged(nameof(WordsToLearnToday));
                    goToSession?.Invoke(this, 0);
                }
                else
                {
                    this.WordsToLearnToday = Account.getAmmountOfWordsFromSession(0);
                    OnPropertyChanged(nameof(WordsToLearnToday));
                    goToSession?.Invoke(this, 0);
                }
            }
            else
            {
                if(Account.getAmmountOfWordsFromSession((short)(sessionDate)) > 0) goToSession?.Invoke(this, sessionDate);
            }
        }
    }
}
