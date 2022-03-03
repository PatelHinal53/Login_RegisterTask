using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Text.RegularExpressions;

namespace Login_Register
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]

    public class MainActivity : AppCompatActivity
    {
        TextView textViewCreate, textViewForgotPass, textViewLogin;
        Button buttonLogin, buttonRegister;
        ImageView imageViewFacebook, imageViewGoogle;
        EditText editTextUserLogin, editTextUserPass;
        Regex UserRegex = new Regex("^[a-z-A-Z- .]*$");
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            UIReferences();
            UIClick();
            MultiColor();
        }

        
        private void UIReferences()
        {
            textViewLogin = FindViewById<TextView>(Resource.Id.textViewLogin);
            textViewCreate = FindViewById<TextView>(Resource.Id.textViewCreate);
            textViewForgotPass = FindViewById<TextView>(Resource.Id.textViewForgotPass);
            buttonLogin = FindViewById<Button>(Resource.Id.buttonLogin);
            buttonRegister = FindViewById<Button>(Resource.Id.buttonRegister);
            imageViewFacebook = FindViewById<ImageView>(Resource.Id.imageViewFacebook);
            imageViewGoogle = FindViewById<ImageView>(Resource.Id.imageViewGoogle);

            editTextUserLogin = FindViewById<EditText>(Resource.Id.editTextUserLogin);
            editTextUserPass = FindViewById<EditText>(Resource.Id.editTextUserPass);

            
        }

        private void UIClick()
        {
            textViewCreate.Click += RegisterA_Click;
            textViewForgotPass.Click += Forgot_Click;

            buttonLogin.Click += Login_Click;
            buttonRegister.Click += RegisterA_Click;
            imageViewFacebook.Click += facebook_Click;
            imageViewGoogle.Click += google_Click;
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
        private void Login_Click(object sender, EventArgs e)
        {
            if(editTextUserLogin.Text == "" && editTextUserPass.Text == "")
            {

                editTextUserLogin.Error = "Please Enter Details";
                editTextUserPass.Error = "Please Enter Details";

            }
            else if (editTextUserLogin.Text == "")
            {
                editTextUserLogin.Error = "Enter Username";
            }
            else if (!ValidateUser(editTextUserLogin.Text))
            {
                editTextUserLogin.Error = "Please Enter the Valid Username";
            }
            else if (editTextUserPass.Text == "")
            {
                editTextUserPass.Error = "Entert Password";
            }
            else if (editTextUserPass.Text.Length < 8)
            {
                editTextUserPass.Error = "Password length is 8";
            }
            else
            {
                Toast.MakeText(this, "Login Successfully", ToastLength.Short).Show();
            }

            bool ValidateUser(string user)
            {
                if (string.IsNullOrWhiteSpace(user))
                    return false;

                return UserRegex.IsMatch(user);
            }
        }
        private void google_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Login With Google.", ToastLength.Short).Show();
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Login With Facebook.", ToastLength.Short).Show();
        }
        private void MultiColor()
        {
            TextPaint paint = textViewLogin.Paint;
            float width = paint.MeasureText(textViewLogin.Text);
            int[] vs = new int[]
            {
                Color.ParseColor("#4A148C"),
                Color.ParseColor("#4A148C"),
                Color.ParseColor("#00008B"),
                Color.ParseColor("#3c70d9"),
                Color.ParseColor("#3c70d9"),
            };
            Shader textshade = new LinearGradient(0, 0, width, textViewLogin.TextSize, vs, null, Shader.TileMode.Clamp);
            textViewLogin.Paint.SetShader(textshade);
        }


    }
}
