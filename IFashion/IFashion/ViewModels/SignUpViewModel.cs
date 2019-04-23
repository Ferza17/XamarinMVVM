using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;

using IFashion.Models;
using IFashion.Views;


namespace IFashion.ViewModels
{
    class SignUpViewModel : INotifyPropertyChanged
    {
        public ICommand SignUpCommand { get; private set; }
        private user _model;




        public bool isBusy;
        private string _username;
        private string _password;
        private string _email;
        private string _gender;
        private string _confirmPassowrd;

        public string Username
        {
            get { return _username; }
            set{ _username = value; OnPropertyChanged();}
        }
        public string Password
        {
            get{return _password;}
            set{ _password = value; OnPropertyChanged();}
        }
        public string Email
        {
            get{return _email;}
            set{_email = value;OnPropertyChanged();}
        }
        public string Gender
        {
            get{return _gender;}
            set{_gender = value; OnPropertyChanged();}
        }

        public string ConfirmPassowrd
        {
            get { return _confirmPassowrd; }
            set { _confirmPassowrd = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;




        public SignUpViewModel()
        {
            _model = new user();
            SignUpCommand = new Command(LogUser);
            
            isBusy = false;
        }



        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void LogUser()
        {
            _model.email = _email;
            _model.username = _username;
            _model.gender = Gender;
            _model.password = _password;

           
            
        }

    }
}
