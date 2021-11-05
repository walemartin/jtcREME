using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jtcREME
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute("AppShell", typeof(AppShell));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }
         
        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
