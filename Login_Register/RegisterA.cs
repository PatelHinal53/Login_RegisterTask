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
    [Activity(Label = "RegisterA")]
    public class RegisterA : Activity
    {
        ImageView imageView1, imageView2;
        Button button1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.register);
            // Create your application here

            UIReferences();
            UIClickEvents();

        }
        private void UIReferences()
        {
            imageView1 = FindViewById<ImageView>(Resource.Id.facebook1);
            imageView2 = FindViewById<ImageView>(Resource.Id.google1);
            button1 = FindViewById<Button>(Resource.Id.registerb);
        }

        private void UIClickEvents()
        {
            imageView1.Click += facebook1_Click;
            imageView2.Click += google1_Click;
            button1.Click += RegisterA_Click;
        }

        

        private void google1_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Login With Google1.?", ToastLength.Short).Show();
        }

        private void facebook1_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Login With Facebook1.?", ToastLength.Short).Show();
        }
        private void RegisterA_Click(object sender, EventArgs e)
        {
            Intent l = new Intent(this, typeof(MainActivity));
            StartActivity(l);
            Toast.MakeText(this, "Register Successfully", ToastLength.Short).Show();
        }

    }
}