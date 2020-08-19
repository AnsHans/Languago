using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Languago.ViewModels.Commands;
using Languago.Models.Protector;
using Languago.Models;
using System.Reflection.Metadata;
using System.Windows.Controls;
using Languago.Models.orm;
using Languago.Models.DataStructures;

namespace Languago.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        
        //Variables
        string _login;
        RelayCommand _loginCommand;
        public event EventHandler<UserApprovedArgs> CredentialsAreOk;
        LanguagoContext db;
        public LoginViewModel(LanguagoContext db)
        {
            this.db = db;
        }

        //Properties
        public long UserID { get; set; }
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public ICommand LoginCommand
        {
            get
            {
                if(_loginCommand == null)
                {
                    _loginCommand = new RelayCommand(CheckPassword);
                }
                return _loginCommand;
            }
        }
        void CheckPassword(object parameter)
        {
            var passwordBox = parameter as PasswordBox;
            var password = passwordBox.Password;
            var Check = new LoginModel();
            UserID = Check.checkCredentials(Login, password,db);
  
            if (UserID >= 0) {
                CredentialsAreOk?.Invoke(this, new UserApprovedArgs(UserID));
            }
            else Login = "wrong credentials";

        }



    }
}