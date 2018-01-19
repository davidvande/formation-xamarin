using System;
using UIKit;
using DiplayPlatformInfo.Interfaces;
using Xamarin.Forms;
using DiplayPlatformInfo.Models;

[assembly: Dependency(typeof(DiplayPlatformInfo.iOS.Models.PlatformInfo))]

namespace DiplayPlatformInfo.iOS.Models
{
    public partial class PlatformInfo : PlatformInfoCommon, IDisplayPlatformInfo
    {
        UIDevice device = new UIDevice();

        public string GetModel()
        {
            return device.Model.ToString();
        }

        public string GetVersion()
        {
            return string.Format("{0} {1}",
                                 device.SystemName,
                                 device.SystemVersion);
        }

        public override string CestQui()
        {
            return "Bein ouais c'est me";
        }
    }
}
