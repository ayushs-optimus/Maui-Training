using MobileCalculator.MVVM.ViewModels;

namespace MobileCalculator.MVVM.View;

public partial class CalculatorView : ContentPage
{
	public CalculatorView()
	{
		InitializeComponent();
		BindingContext = new CalculatorViewModel();
	}
}