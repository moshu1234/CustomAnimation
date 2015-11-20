using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CustomAnimation
{
	[Activity (Label = "CustomAnimation", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            var btnDemo = FindViewById<Button>(Resource.Id.btnDemo);
            btnDemo.Click += btnDemo_Click;

            var btnAbout = FindViewById<Button>(Resource.Id.btnAbout);
            btnAbout.Click += btnAbout_Click;
        }
        
        void btnDemo_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(DemoAnimationActivity));
        }

        void btnAbout_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(AboutActivity));
            this.OverridePendingTransition(Resource.Animation.card_open, Resource.Animation.card_close);
        }
	}
}