using com.graco.examen.Helpers;
using com.graco.examen.Interfaces;
using com.graco.examen.Views;
using Xamarin.Forms;

namespace com.graco.examen
{
    public partial class App : Application
    {
        public static Page ContextApp { get; set; }
        public static INavigationService NavigationService { get; } = new NavigationViewService();
        public App()
        {
            InitializeComponent();

            NavigationService.Configure("LoginPage", typeof(LoginView));

            MainPage = ((NavigationViewService)NavigationService).SetRootPage("LoginPage");

            ContextApp = App.Current.MainPage;
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
