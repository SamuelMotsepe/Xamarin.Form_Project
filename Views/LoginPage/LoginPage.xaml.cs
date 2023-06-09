public class SignInViewModel : BaseViewModel
{
    private string username;
    public string Username
    {
        get { return username; }
        set { SetProperty(ref username, value); }
    }

    private string password;
    {
        get { return password; }
        set { SetProperty(ref password, value); }
    }

    public ICommand SignInCommand { get; private set; }

    public SignInViewModel()
    {
        SignInCommand = new Command(OnSignInClicked);
    }

    private void OnSignInClicked()
    {
        // Perform sign-in logic here, e.g. check username/password against hardcoded values
        if (Username == "test" && Password == "password")
        {
            // Navigate to the Homepage
            Application.Current.MainPage = new HomePage();
        }
        else
        {
            // Display an error message to the user
            DisplayAlert("Error", "Invalid username or password", "OK");
        }
    }
}

public partial class SignInPage : ContentPage
{
    public SignInPage()
    {
        InitializeComponent();
        BindingContext = new SignInViewModel();
    }
}
