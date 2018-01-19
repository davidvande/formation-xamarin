using System;
using Android.OS;
using Xamarin.Forms;
using DiplayPlatformInfo.Interfaces;
using DiplayPlatformInfo.Models;

[assembly: Dependency(typeof(DisplayPlatformInfo.Droid.Models.PlatformInfo))]

namespace DisplayPlatformInfo.Droid.Models
{
    public partial class PlatformInfo : PlatformInfoCommon, IDisplayPlatformInfo
    {
        public string GetModel()
        {
            return String.Format("{0} {1}", Build.Manufacturer,
                                            Build.Model);
        }

        public string GetVersion()
        {
            return Build.VERSION.Release.ToString();
        }
    }
}