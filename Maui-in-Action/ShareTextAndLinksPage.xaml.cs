namespace Maui_in_Action;

public partial class ShareTextAndLinksPage : ContentPage
{
	public ShareTextAndLinksPage()
	{
		InitializeComponent();
	}

    // Share text and links https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/data/share?tabs=windows
    public async Task ShareText(string text)
    {
        await Share.Default.RequestAsync(new ShareTextRequest
        {
            Text = text,
            Title = "Share Text"
        });
    }

    public async Task ShareUri(string uri, IShare share)
    {
        await share.RequestAsync(new ShareTextRequest
        {
            Uri = uri,
            Title = "Share Web Link"
        });
    }

    private async void ShareLinkButton_Clicked(object sender, EventArgs e)
    {
        
       await ShareUri("https://www.microsoft.comm", Share.Default);
    }
}