using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register
{
    [Activity(Label = "SplashA", MainLauncher = true, Theme = "@style/Theme.Splash", NoHistory = true)]
    public class SplashA : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected override async void OnResume()
        {

            base.OnResume();
            await SimulateStartup();

        }

        async Task SimulateStartup()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            //StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            Intent intent = new Intent(Application.Context, typeof(MainActivity));
            StartActivity(intent);
        }
    }
}
