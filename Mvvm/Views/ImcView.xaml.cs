namespace MauiApp1.Mvvm.Views;

public partial class ImcView : ContentPage
{
	public ImcView()
	{
        InitializeComponent();
        BindingContext = new ViewModels.ImcViewModels();
    }

}