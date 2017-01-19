using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Com.Yalantis.Guillotine.Animation;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace ScratchBindingTestApp

{
    [Activity(Label = "ScratchBindingTestApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        FrameLayout root;
        Toolbar toolbar;
        View contentHamburger;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            root = FindViewById<FrameLayout>(Resource.Id.root);

            if (toolbar != null)
            {
                SetSupportActionBar(toolbar);
                SupportActionBar.Title = null;
            }

            View guillotineMenu = LayoutInflater.From(this).Inflate(Resource.Layout.gullotine, null);
            root.AddView(guillotineMenu);

            var view2 = guillotineMenu.FindViewById(Resource.Id.guillotine_hamburger);

            contentHamburger = FindViewById<ImageView>(Resource.Id.content_hamburger);

            new GuillotineAnimation.GuillotineBuilder(guillotineMenu, view2, contentHamburger)
            .SetClosedOnStart(true)
            .SetDuration(1000)
            .SetStartDelay(250)
            .SetActionBarViewForAnimation(toolbar)
            .Build();

        }
    }
}

