﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;

namespace xamarin.Droid
{
    [Activity(Label = "xamarin", Icon = "@mipmap/icon", Theme = "@style/splashscreen", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            global::Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.SetTheme(Resource.Style.MainTheme);

            base.OnCreate(savedInstanceState, persistentState);
        }
    }
}