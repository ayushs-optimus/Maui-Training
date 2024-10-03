using MAUIVerter.MVVM.Views;

namespace MAUIVerter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuItems());
        }
    }
}
