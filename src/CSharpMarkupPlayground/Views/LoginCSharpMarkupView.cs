using CSharpMarkupPlayground.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using static Xamarin.Forms.Markup.GridRowsColumns;

namespace CSharpMarkupPlayground.Views
{
    public class LoginCSharpMarkupView : ContentPage
    {
        enum Row { Logo, Username, Password, Forgot, SignIn };

        public LoginCSharpMarkupView()
        {
            var vm = new LoginViewModel();
            BindingContext = vm;
            BackgroundColor = Color.LightGray;

            Content = new Grid
            {
                Padding = 12,
                RowDefinitions = Rows.Define(
                    (Row.Logo, GridLength.Star),
                    (Row.Username, GridLength.Auto),
                    (Row.Password, GridLength.Auto),
                    (Row.Forgot, GridLength.Auto),
                    (Row.SignIn, GridLength.Star)),
                Children =
                {
                    new Image
                    {
                        BackgroundColor = Color.Gray,
                        HeightRequest = 100,
                        WidthRequest = 100,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    }.Row(Row.Logo),
                    new Entry
                    {
                        Placeholder = "Username"
                    }.Row(Row.Username).Bind(nameof(vm.Username)),
                    new Entry
                    {
                        IsPassword = true,
                        Placeholder = "Password"
                    }.Row(Row.Password).Bind(nameof(vm.Password)),
                    new Label
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                        Text = "Forgot Password?",
                        TextDecorations = TextDecorations.Underline,
                        HorizontalOptions = LayoutOptions.End
                    }.Row(Row.Forgot),
                    new Button
                    {
                        BackgroundColor = Color.White,
                        CornerRadius = 24,
                        HeightRequest = 60,
                        Margin = new Thickness(24, 12),
                        VerticalOptions = LayoutOptions.Center,
                        Text = "LOGIN"
                    }.Row(Row.SignIn).Bind(nameof(vm.SignInCommand))
                }
            };
        }
    }
}