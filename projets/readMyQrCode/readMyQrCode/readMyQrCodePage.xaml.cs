using System;
using Xamarin.Forms;
using ZXing.Mobile;

namespace readMyQrCode
{
    public partial class readMyQrCodePage : ContentPage
    {
        public readMyQrCodePage()
        {
            InitializeComponent();
        }

        async protected void btScan_Clicked(Object sender, EventArgs e)
        {
            #if __ANDROID__
                // Initialize the scanner first so it can track the current context
                MobileBarcodeScanner.Initialize(Application);
            #endif
            
            var scanner = new ZXing.Mobile.MobileBarcodeScanner();
            var result = await scanner.Scan();

            if (result != null)
                Console.WriteLine("Scanned Barcode: " + result.Text);
        }
    }
}
