namespace BusTransport.Mob.Views;

public partial class TicketValidationPage : ContentPage
{
    private bool isProcessingScan = false;
    public TicketValidationPage()
    {
        InitializeComponent();
        barcodeReader.Options = new ZXing.Net.Maui.BarcodeReaderOptions
        {
            Formats = ZXing.Net.Maui.BarcodeFormat.QrCode,
            AutoRotate = true,
            Multiple = false
            
        };
        barcodeReader.CameraLocation = ZXing.Net.Maui.CameraLocation.Rear;
    }

    private void barcodeReader_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        if (isProcessingScan) return;

        var first = e.Results?.FirstOrDefault();
        if (first is null) return;

        isProcessingScan = true; 

        Dispatcher.DispatchAsync(async () =>
        {
            await DisplayAlert("Zeskanowano bilet:", first.Value, "OK");
            isProcessingScan = false; 
        });
    }

    public static implicit operator View(TicketValidationPage v)
    {
        return v.Content;
    }
}