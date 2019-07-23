using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.Design.Widget;

namespace XamarianBottomNavView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);            
            SetContentView(Resource.Layout.activity_main);
            var bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottomNavigation.NavigationItemSelected += (s, e) => {

                switch (e.Item.ItemId)
                {
                    case Resource.Id.action_add:
                        Toast.MakeText(this, "Action Add Clicked", ToastLength.Short).Show();
                        break;
                    case Resource.Id.action_edit:
                        Toast.MakeText(this, "Action Edit Clicked", ToastLength.Short).Show();
                        break;
                    case Resource.Id.action_remove:
                        Toast.MakeText(this, "Action Remove Clicked", ToastLength.Short).Show();
                        break;
                }

            };
        }
    }
}