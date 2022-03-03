using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Login_Register
{
    [Activity(Label = "RegisterA", Theme = "@style/AppTheme")]
    public class RegisterA : AppCompatActivity
    {
        ImageView imageViewFacebook1, imageViewGoogle1;
        TextView textViewRegister;
        Button buttonRegisterB;
        EditText editTextRegName, editTextEmail, editTextUsername, editTextPassword;
        Regex EmailRegex = new Regex(@"^[a-z]([\w\.\-]+)@([\w\-]+)((\.)+)com$+");
        Regex UserRegex = new Regex("^[a-z-A-Z- .]*$");
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.register);
            // Create your application here

            UIReferences();
            UIClickEvents();
            MultiColor();

        }
        private void UIReferences()
        {
            textViewRegister = FindViewById<TextView>(Resource.Id.textViewRegister);
            imageViewFacebook1 = FindViewById<ImageView>(Resource.Id.imageViewFacebook1);
            imageViewGoogle1 = FindViewById<ImageView>(Resource.Id.imageViewGoogle1);
            buttonRegisterB = FindViewById<Button>(Resource.Id.buttonRegisterB);
            editTextRegName = FindViewById<EditText>(Resource.Id.editTextRegName);
            editTextEmail = FindViewById<EditText>(Resource.Id.editTextEmail);
            editTextUsername = FindViewById<EditText>(Resource.Id.editTextUsername);
            editTextPassword = FindViewById<EditText>(Resource.Id.editTextPassword);
        }

        private void UIClickEvents()
        {
            buttonRegisterB.Click += RegisterA_Click;
            imageViewGoogle1.Click += google1_Click;
            imageViewFacebook1.Click += facebook1_Click;
        }

        private void RegisterA_Click(object sender, EventArgs e)
        {
            if (editTextRegName.Text == "" && editTextEmail.Text == "" && editTextUsername.Text == "" && editTextPassword.Text == "")
            {
                Toast.MakeText(this, "Please Enter the Details", ToastLength.Short).Show();
                editTextRegName.Error = "Please Enter the Details";
                editTextEmail.Error = "Please Enter the Details";
                editTextUsername.Error = "Please Enter the Details";
                editTextPassword.Error = "Entert Password";
            }
            
            else if (editTextRegName.Text == "")
            {
                editTextRegName.Error = "Enter the Name of  User";
            }
            else if (!ValidateUser(editTextRegName.Text))
            {
                editTextRegName.Error = "Please Enter the Valid  Name of  User";
            }

            else if (editTextEmail.Text == "")
            {
                editTextEmail.Error = "Enter the EmailAddress";
            }

            else if (!ValidateEmail(editTextEmail.Text))
            {
                editTextEmail.Error = "Please Enter the Valid EmailAddress";
            }

            else if (editTextUsername.Text == "")
            {
                editTextUsername.Error = "Enter Username";
            }
            else if (!ValidateUser(editTextUsername.Text))
            {
                editTextUsername.Error = "Please Enter the Valid Username";
            }
            
            else if (editTextPassword.Text == "")
            {
                editTextPassword.Error = "Entert Password";
            }
            else if (editTextPassword.Text.Length < 8)
            {
                editTextPassword.Error = "Password length is 8";
            }
            else
            {
                Toast.MakeText(this, "Register Successfully", ToastLength.Short).Show();
                Intent l = new Intent(this, typeof(MainActivity));
                StartActivity(l);
                Finish();
            }
        }

        private void google1_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Register With Google1.", ToastLength.Short).Show();
        }

        private void facebook1_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Register With Facebook1.", ToastLength.Short).Show();
        }

        bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return EmailRegex.IsMatch(email);
        }
        bool ValidateUser(string user)
        {
            if (string.IsNullOrWhiteSpace(user))
                return false;

            return UserRegex.IsMatch(user);
        }
        private void MultiColor()
        {
            TextPaint paint = textViewRegister.Paint;
            float width = paint.MeasureText(textViewRegister.Text);
            int[] vs = new int[]
            {
                Color.ParseColor("#4A148C"),
                Color.ParseColor("#4A148C"),
                Color.ParseColor("#00008B"),
                Color.ParseColor("#3c70d9"),
                Color.ParseColor("#3c70d9"),
            };
            Shader textshade = new LinearGradient(0, 0, width, textViewRegister.TextSize, vs, null, Shader.TileMode.Clamp);
            textViewRegister.Paint.SetShader(textshade);
        }
    }
}
