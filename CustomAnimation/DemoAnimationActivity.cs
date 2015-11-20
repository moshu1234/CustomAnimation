
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Views.Animations;

namespace CustomAnimation
{
    [Activity(Label = "DemoAnimationActivity", ParentActivity = typeof(MainActivity))]			
	public class DemoAnimationActivity : Activity
	{
        ImageView image; 
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Demo);

            image = FindViewById<ImageView>(Resource.Id.imgIcon);

            var btnFlipCard = FindViewById<Button>(Resource.Id.btnFlipCard);
            btnFlipCard.Click +=btnFlipCard_Click;
		}

        void btnFlipCard_Click(object sender, EventArgs e)
        {
            var cardAnimation = AnimationUtils.LoadAnimation(this, Resource.Animation.card_open);
            image.StartAnimation(cardAnimation);
        }
	}
}