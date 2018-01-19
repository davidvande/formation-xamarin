using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

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
            var options = new ZXing.Mobile.MobileBarcodeScanningOptions();
            options.PossibleFormats = new List<ZXing.BarcodeFormat>() {
                    ZXing.BarcodeFormat.QR_CODE
                };
            
            var scanPage = new ZXingScannerPage(options);

            scanPage.OnScanResult += (result) => {
                // Stop scanning
                scanPage.IsScanning = false;

                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };
            
            await Navigation.PushAsync(scanPage);
        }
    }
}
