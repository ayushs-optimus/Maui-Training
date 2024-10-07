using MobileCalculator.MVVM.View;

namespace MobileCalculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new CalculatorView();
        }
    }
}
