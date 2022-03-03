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
    [Activity(Label = "ForgotpassA" , Theme = "@style/AppTheme")]
    public class ForgotpassA : Activity
    {
        Button buttonReset;
        TextView textViewForgot;
        EditText editTextNewPass, editTextConfirmPass;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.forgot);
            // Create your application here

            textViewForgot = FindViewById<TextView>(Resource.Id.textViewForgot);
            editTextNewPass = FindViewById<EditText>(Resource.Id.editTextNewPass);
            editTextConfirmPass = FindViewById<EditText>(Resource.Id.editTextConfirmPass);
            buttonReset = FindViewById<Button>(Resource.Id.buttonReset);

            buttonReset.Click += Reset_Click;
            MultiColor();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (editTextNewPass.Text == "")
            {
                editTextNewPass.Error = "Enter NewPass Password ";
            }
            else if (editTextConfirmPass.Text == "")
            {
                editTextConfirmPass.Error = "Enter ConfirmPass Password";
            }
            else if (editTextNewPass.Text != editTextConfirmPass.Text)
            {
                Toast.MakeText(this, "Your NewPass Or ConfirmPass Not Same.", ToastLength.Short).Show();
            }
            else
            {
                Intent b = new Intent(this, typeof(MainActivity));
                StartActivity(b);
                Toast.MakeText(this, "Reset your Password Successfully", ToastLength.Short).Show();
            }
            
        }
        private void MultiColor()
        {
            TextPaint paint = textViewForgot.Paint;
            float width = paint.MeasureText(textViewForgot.Text);
            int[] vs = new int[]
            {
                Color.ParseColor("#4A148C"),
                Color.ParseColor("#4A148C"),
                Color.ParseColor("#00008B"),
                Color.ParseColor("#3c70d9"),
                Color.ParseColor("#3c70d9"),
            };
            Shader textshade = new LinearGradient(0, 0, width, textViewForgot.TextSize, vs, null, Shader.TileMode.Clamp);
            textViewForgot.Paint.SetShader(textshade);
        }
        
    }
}
