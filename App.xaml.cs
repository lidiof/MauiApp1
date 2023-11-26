using MauiApp1.Mvvm.Views;

namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new ImcView());
	}
}
