namespace Maui_in_Action;

public partial class NavigationPage : ContentPage
{
	public NavigationPage()
	{
		InitializeComponent();
	}

	private async void GoHomeButton_Clicked(object sender, EventArgs e)
	{
		var param = "Hello MAUI!";
        await Shell.Current.GoToAsync($"//MainPage?p={param}");
    }
}