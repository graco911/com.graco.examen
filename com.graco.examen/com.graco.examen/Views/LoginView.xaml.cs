using com.graco.examen.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace com.graco.examen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginViewModel LoginViewModel { get; }

        public LoginView()
        {
            InitializeComponent();
            BindingContext = LoginViewModel = new LoginViewModel();
        }
    }
}