using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Telephony;

namespace DependencyServiceSample.Droid
{
    [Activity(Label = "DependencyServiceSample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private static TelephonyManager _tm;
        public static TelephonyManager Tm { get => _tm; set => _tm = value; }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            Tm = (TelephonyManager)GetSystemService(TelephonyService);
            Declaration.ProviderString = Tm.NetworkOperatorName;
            Initial();
        }

        public void Initial()
        {
            FileOperations.PositionElementAddress = "Granitstrasse 9, 44627 Herne";
            FileOperations.InformationElementMcc = "001";
            FileOperations.InformationElementMnc = "001";
            FileOperations.InformationElementNwType = "UMTS";
            FileOperations.InformationElementSignal = "98";
            FileOperations.InformationElementDistance = 36.4;
            FileOperations.InformationElementRoaming = true;
        }
    }
}