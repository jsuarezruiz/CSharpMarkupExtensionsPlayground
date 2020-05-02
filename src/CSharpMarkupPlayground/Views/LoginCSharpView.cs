using CSharpMarkupPlayground.ViewModels;
using Xamarin.Forms;

namespace CSharpMarkupPlayground.Views
{
    public class LoginCSharpView : ContentPage
    {
        public LoginCSharpView()
        {
            BindingContext = new LoginViewModel();
            BackgroundColor = Color.LightGray;

            var grid = new Grid
            {
                Padding = 12
            };

            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition());

            var logo = new Image
            {
                BackgroundColor = Color.Gray,
                HeightRequest = 100,
                WidthRequest = 100,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            grid.Children.Add(logo);
            Grid.SetRow(logo, 0);

            var usernameEntry = new Entry
            {
                Placeholder = "Username"
            };
            usernameEntry.SetBinding(Entry.TextProperty, "Username");
            grid.Children.Add(usernameEntry);
            Grid.SetRow(usernameEntry, 1);

            var passwordEntry = new Entry
            {
                IsPassword = true,
                Placeholder = "Password"
            };
            passwordEntry.SetBinding(Entry.TextProperty, "Password");
            grid.Children.Add(passwordEntry);
            Grid.SetRow(passwordEntry, 2);

            var forgotPassword = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                Text = "Forgot Password?",
                TextDecorations = TextDecorations.Underline,
                HorizontalOptions = LayoutOptions.End
            };
            grid.Children.Add(forgotPassword);
            Grid.SetRow(forgotPassword, 3);

            var signInGrid = new Grid();

            var signInButton = new Button
            {
                BackgroundColor = Color.White,
                CornerRadius = 24,
                HeightRequest = 60,
                Margin = new Thickness(24, 12),
                VerticalOptions = LayoutOptions.Center,
                Text = "LOGIN"
            };
            signInGrid.Children.Add(signInButton);

            grid.Children.Add(signInGrid);
            Grid.SetRow(signInGrid, 4);

            Content = grid;
        }
    }
}
