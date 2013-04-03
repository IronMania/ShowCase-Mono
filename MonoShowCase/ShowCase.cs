using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MonoShowCase.Tabs;

namespace MonoShowCase
{
    [Activity(
        Label = "@string/app_name", 
        MainLauncher = true, Theme = "@android:style/Theme.Holo")]
    public class ShowCase : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            
            //Add World Tab
            AddTab("World", Resource.Drawable.Icon, new WorldTab());

            //Add Geo Tab
            AddTab("Geo", Resource.Drawable.Icon, new GeoTab());

            //add Cam Tab
            AddTab("Cam", Resource.Drawable.Icon, new CamTab());
        }

        private void AddTab(string name, int icon, Fragment tabContent) {
            //Add World Tab
            var tab = this.ActionBar.NewTab();
            tab.SetText(name);
            tab.SetIcon(icon);
            tab.TabSelected += delegate(object sender, ActionBar.TabEventArgs e)
            {
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer,
                    tabContent);
            };
            tab.TabUnselected += delegate(object sender, Android.App.ActionBar.TabEventArgs e)
            {
                e.FragmentTransaction.Remove(tabContent);
            };

            this.ActionBar.AddTab(tab);

        }
    }
}


