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
    [Activity(Label = "ForgotpassA")]
    public class ForgotpassA : Activity
    {
        Button button1;
        TextView txtforgot;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.forgot);
            // Create your application here

            txtforgot = FindViewById<TextView>(Resource.Id.txtforgot);
            button1 = FindViewById<Button>(Resource.Id.resetbtn);
            button1.Click += Reset_Click;

            TextPaint paint = txtforgot.Paint;
            float width = paint.MeasureText(txtforgot.Text);
            int[] vs = new int[]
            {
                Color.ParseColor("#4A148C"),
                Color.ParseColor("#4A148C"),
                Color.ParseColor("#00008B"),
                Color.ParseColor("#209FF1"),
                Color.ParseColor("#209FF1"),
            };
            Shader textshade = new LinearGradient(0, 0, width, txtforgot.TextSize, vs, null, Shader.TileMode.Clamp);
            txtforgot.Paint.SetShader(textshade);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Intent b = new Intent(this, typeof(MainActivity));
            StartActivity(b);
            Toast.MakeText(this, "Reset your Password Successfully" ,ToastLength.Short).Show();
        }
    }
}
