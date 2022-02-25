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

namespace Login_Register
{
    [Activity(Label = "ForgotpassA")]
    public class ForgotpassA : Activity
    {
        Button button1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.forgot);
            // Create your application here

            button1 = FindViewById<Button>(Resource.Id.resetbtn);
            button1.Click += Reset_Click;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Intent b = new Intent(this, typeof(MainActivity));
            StartActivity(b);
            Toast.MakeText(this, "Reset your Password Successfully" ,ToastLength.Short).Show();
        }
    }
}