using LearnMaui5.ViewModels;

namespace LearnMaui5.Pages;

public partial class PartsPage : ContentPage
{
	public PartsPage()
	{
		InitializeComponent();

        BindingContext = new PartsViewModel();
    }
}