

namespace Maui_in_Action;


[QueryProperty(nameof(Param), "p")]
public partial class MainPage : ContentPage
{

    public string Param
    {
        set
        {
            HelloWorldLabel.Text = value;
        }
    }

    int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

