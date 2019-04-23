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
    class RegistLoginViewModels : INotifyPropertyChanged
    {
        public ICommand SignInCommand { get; private set; }
        public ICommand SignUpCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public RegistLoginViewModels()
        {
            SignUpCommand = new Command(async () => await SignUp());
            SignInCommand = new Command(async () => await SignIn());
        }

        async Task SignUp() => await PopupNavigation.PushAsync(new SingUpPopUpView());

        async Task SignIn() => await PopupNavigation.PushAsync(new SignInPopUpView());
    }
}
