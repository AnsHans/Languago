using Remotion.Linq.Clauses;
using System;
using System.Collections.Generic;
using System.Text;
using Languago.Models.DataStructures;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using System.Security.Policy;
using Languago.Models.orm;

namespace Languago.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {

        EventHandler<UserApprovedArgs> onCredentialsApproved;
        EventHandler<int> onGoToSession;
        EventHandler<bool> onGoToAccount;
        public delegate void EventFunctions(object sender, UserApprovedArgs eventargs);
        LanguagoContext db;
        long UserID;
        bool _subbedGoToAccount = false;
        public string Login { get; set; }
        public BaseViewModel CurrentViewModel { get; set; }
        public MainWindowViewModel()
        {
            this.db = new LanguagoContext();
            CurrentViewModel = new LoginViewModel(db);
            onCredentialsApproved = this.changeToAccountView;
            (CurrentViewModel as LoginViewModel).CredentialsAreOk += onCredentialsApproved;
            onGoToSession = this.changeToSessionView;
        }
        public void changeToAccountView(object sender, UserApprovedArgs eventargs)
        {
            (CurrentViewModel as LoginViewModel).CredentialsAreOk -= onCredentialsApproved;
            this.UserID = (CurrentViewModel as LoginViewModel).UserID;
            CurrentViewModel = new AccountViewModel(UserID, this.db);
            OnPropertyChanged(nameof(CurrentViewModel));
            (CurrentViewModel as AccountViewModel).goToSession += onGoToSession;
        }
        public void changeToAccountViewFromSession(object sender, bool e)
        {
            CurrentViewModel = new AccountViewModel(UserID, db);
            OnPropertyChanged(nameof(CurrentViewModel));
            (CurrentViewModel as AccountViewModel).goToSession += onGoToSession;
        }
        public void changeToSessionView(object sender, int eventargs)
        {
            CurrentViewModel = new SessionViewModel(UserID,db,eventargs);
            OnPropertyChanged(nameof(CurrentViewModel));
    
            onGoToAccount = changeToAccountViewFromSession;
            (CurrentViewModel as SessionViewModel).GotoAccount += onGoToAccount;

        }

    }
}



