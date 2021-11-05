using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jtcREME
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            var nm = new LoginPage();
        }
       
        public void OnSignInClicked(object sender, EventArgs args)
        {
            //AppShell nm = new AppShell();
            Navigation.PushModalAsync(new NavigationPage(new AppShell()));
            //AppShell nm = new AppShell();
            //ContentPage nm = new ContentPage();
            
            //nm.Navigation.PushAsync(new AppShell());
        }
    }
}