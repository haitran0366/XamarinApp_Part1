using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace XamarinApp_Part1__.ViewModel
{
    class LoginPageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Command cmdLogin { get; set; }
        public Command cmdCreateAccount { get; set; }
        public Command cmdForgotPassword { get; set; }
        public Command cmdSetting { get; set; }

        //ILoginService ilog = DependencyService.Get<ILoginService>(); //todo

        public LoginPageViewModel()
        {
            cmdLogin = new Command(gotoMainPage);
            cmdCreateAccount = new Command(gotoCreateAccount);
            cmdForgotPassword = new Command(gotoForgotPassword);
            cmdSetting = new Command(gotoSetting);
        }

        private void gotoSetting(object obj)
        {
            TurnLoginMessage = true;
            //App.Current.MainPage.Navigation.PushAsync(new SettingPage());
            LoginMessage = "Setting function will be done in next video.";
        }

        private void gotoForgotPassword(object obj)
        {
            TurnLoginMessage = true;
            //App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());//todo
            LoginMessage = "Forgot password function will be done in next video.";
        }

        private void gotoCreateAccount(object obj)
        {
            TurnLoginMessage = true;
            //App.Current.MainPage.Navigation.PushAsync(new CreateAccountPage()); //todo
            LoginMessage = "Create account function will be done in next video.";
        }

        private void gotoMainPage(object obj)
        {
            /*
            if (ilog.login(UserName, Password))
            {
                App.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else
            {
                LoginMessage = "Please enter a valid user name and password!";
                TurnLoginMessage = true;
            }
            */
            TurnLoginMessage = true;
            LoginMessage = "gotoMainPage function will be done in next video.";

        }
        //----------------------------------
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserName"));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
            }
        }

        private string loginMessage;
        public string LoginMessage
        {
            get { return loginMessage; }
            set
            {
                loginMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoginMessage"));
            }
        }

        private bool turnLoginMessage = false;
        public bool TurnLoginMessage
        {
            get { return turnLoginMessage; }
            set
            {
                turnLoginMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TurnLoginMessage"));
            }
        }
    }
}
