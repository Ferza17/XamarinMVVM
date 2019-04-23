using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using IFashion.ViewModels;

namespace IFashion.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistLoginView : ContentPage
	{
		public RegistLoginView ()
		{
			InitializeComponent ();


		}

        /*
        private void ButtonSignUp_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new SingUpPopUpView());
        }

        private void ButtonSignIn_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new SignInPopUpView());
        }
        */
    }
}