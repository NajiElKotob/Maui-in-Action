namespace Maui_in_Action;

public partial class TextToSpeechPage : ContentPage
{
	public TextToSpeechPage()
	{
		InitializeComponent();
	}

	private void SayHelloButton_Clicked(object sender, EventArgs e)
	{
		Speak();
    }

    // Text-to-Speech https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/device-media/text-to-speech
    public async void Speak() =>
    await TextToSpeech.Default.SpeakAsync("Hello MAUI");
}