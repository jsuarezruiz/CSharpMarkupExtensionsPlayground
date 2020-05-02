using CSharpMarkupPlayground.Views;
using Xamarin.Forms;

namespace CSharpMarkupPlayground
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new LoginXamlView();
            //MainPage = new LoginCSharpView();
            MainPage = new LoginCSharpMarkupView();
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
