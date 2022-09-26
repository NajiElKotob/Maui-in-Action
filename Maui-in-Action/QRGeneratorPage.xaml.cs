using QRCoder;

namespace Maui_in_Action;

public partial class QRGeneratorPage : ContentPage
{
	public QRGeneratorPage()
	{
		InitializeComponent();
        SizeChanged += QRGeneratorPageSizeChanged;  
    }

    private void QRGeneratorPageSizeChanged(object sender, EventArgs e)
    {
        //Adaptive UI with Xamarin.Forms https://devblogs.microsoft.com/xamarin/adaptive-ui-xamarin-forms/
        QrImage.WidthRequest = Math.Min(this.Width, 400);
    }

    private void GenerateQRButton_Clicked(object sender, EventArgs e)
	{
        // Displaying Base64 encoded image in Xamarin.Forms https://blog.mzikmund.com/2018/01/displaying-base64-encoded-image-in-xamarin-forms/
        // Load Image from a Stream https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/image#load-an-image-from-a-stream
        Stream stream = new MemoryStream(GenerateQR(UrlEntry.Text.Trim()));
        var imageSource = ImageSource.FromStream(() => stream);
        QrImage.Source = imageSource;

    }

    private byte[] GenerateQR(string inputValue)
    {
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputValue, QRCodeGenerator.ECCLevel.Q);
        BitmapByteQRCode qrCode = new BitmapByteQRCode(qrCodeData);
        byte[] qrCodeImage = qrCode.GetGraphic(20);
        return qrCodeImage.ToArray();
    }
}