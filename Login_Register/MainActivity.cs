using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Login_Register
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]

    public class MainActivity : AppCompatActivity
    {
        TextView textView, textView2,textView3;
        Button button1, button2;
        ImageView imageView1, imageView2;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            UIReferences();
            UIClick();
        }

        private void UIReferences()
        {
            textView3 = FindViewById<TextView>(Resource.Id.txtRegister);
            textView = FindViewById<TextView>(Resource.Id.txtcreate);
            textView2 = FindViewById<TextView>(Resource.Id.forgotpass);
            button1 = FindViewById<Button>(Resource.Id.loginButton);
            button2 = FindViewById<Button>(Resource.Id.registerButton);
            imageView1 = FindViewById<ImageView>(Resource.Id.facebook);
            imageView2 = FindViewById<ImageView>(Resource.Id.google);

        }

        private void UIClick()
        {
            textView.Click += RegisterA_Click;
            textView2.Click += Forgot_Click;

            button1.Click += Login_Click;
            button2.Click += RegisterA_Click;
            imageView1.Click += facebook_Click;
            imageView2.Click += google_Click;
        }
        private void Login_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Login Successfully", ToastLength.Short).Show();
        }
        private void google_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Login With Google.?", ToastLength.Short).Show();
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Login With Facebook.?", ToastLength.Short).Show();
        }

        

        private void RegisterA_Click(object sender, EventArgs e)
        {
            Intent R = new Intent(this, typeof(RegisterA));
            StartActivity(R);
        }

        private void Forgot_Click(object sender, EventArgs e)
        {
            Intent a = new Intent(this, typeof(ForgotpassA));
            StartActivity(a);
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(RegisterA));
            StartActivity(i);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}