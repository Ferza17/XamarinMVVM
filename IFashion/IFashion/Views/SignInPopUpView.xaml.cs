using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IFashion.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignInPopUpView : PopupPage
	{
		public SignInPopUpView ()
		{
			InitializeComponent();
            BtnLogin.Clicked +=  BtnLogin_Clicked;    
		}

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync(true);
        }
    }
}