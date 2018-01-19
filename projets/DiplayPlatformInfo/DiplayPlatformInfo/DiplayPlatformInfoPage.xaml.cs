using DiplayPlatformInfo.Interfaces;
using Xamarin.Forms;

namespace DiplayPlatformInfo
{
    public partial class DiplayPlatformInfoPage : ContentPage
    {
        public DiplayPlatformInfoPage()
        {
            InitializeComponent();

            IDisplayPlatformInfo platformInfo = DependencyService.Get<IDisplayPlatformInfo>();
            modelLabel.Text = platformInfo.GetModel();
            versionLabel.Text = platformInfo.GetVersion();
            modelCestQui.Text = platformInfo.CestQui();
        }
    }
}
