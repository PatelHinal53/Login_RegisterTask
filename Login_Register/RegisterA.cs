using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
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
        TextView textView;
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
            textView = FindViewById<TextView>(Resource.Id.txtRegister);
            imageView1 = FindViewById<ImageView>(Resource.Id.facebook1);
            imageView2 = FindViewById<ImageView>(Resource.Id.google1);
            button1 = FindViewById<Button>(Resource.Id.registerb);


            TextPaint paint = textView.Paint;
            float width = paint.MeasureText(textView.Text);
            int[] vs = new int[]
            {
                Color.ParseColor("#301934"),
                Color.ParseColor("#00008B"),
                Color.ParseColor("#00008B"),
                Color.ParseColor("#209FF1"),
                Color.ParseColor("#209FF1"),
            };

            Shader textshade = new LinearGradient(0, 0, width, textView.TextSize, vs, null, Shader.TileMode.Clamp);
            textView.Paint.SetShader(textshade);

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
