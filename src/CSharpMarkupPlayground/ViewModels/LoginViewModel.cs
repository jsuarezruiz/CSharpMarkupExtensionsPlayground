using System.Windows.Input;
using Xamarin.Forms;

namespace CSharpMarkupPlayground.ViewModels
{
    public class LoginViewModel : BindableObject
    {
        string _username;
        string _password;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public ICommand SignInCommand => new Command(OnSignIn);

        void OnSignIn()
        {
            // TODO: Sign In        
        }
    }
}