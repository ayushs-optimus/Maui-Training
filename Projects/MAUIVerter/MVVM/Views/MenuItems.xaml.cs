using MAUIVerter.MVVM.ViewModels;

namespace MAUIVerter.MVVM.Views;

public partial class MenuItems : ContentPage
{
	public MenuItems()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		var grid = (Grid)sender;
		var element = ((Label)grid.Children.LastOrDefault()!).Text;
		var converterView = new ConverterView
		{
			BindingContext = new ConverterViewModel(element)
		};
		Navigation.PushAsync(converterView);
    }
}