using BMI_Calculator.MVVM.Views;

namespace BMI_Calculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BMIView();
        }
    }
}
