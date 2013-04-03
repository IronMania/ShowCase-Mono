using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Media;
using Android.Graphics;
using Xamarin.Geolocation;

namespace MonoShowCase.Tabs
{
    public class GeoTab : Fragment
    {
        #region Fields
        //private LocationManager locationManager;
        private Geolocator geolocator;
        private Button startGeo;
        private TextView geoLong;
        private TextView geoLat;
        private TextView status;
        #endregion

        public override View OnCreateView(LayoutInflater inflater,
       ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(
                Resource.Layout.Activity_geo_fragment, container, false);

            startGeo = view.FindViewById<Button>(Resource.Id.geo);
            geoLong = view.FindViewById<TextView>(Resource.Id.geolong);
            geoLat = view.FindViewById<TextView>(Resource.Id.geolat);
            status = view.FindViewById<TextView>(Resource.Id.geostatus);

            startGeo.Click += new EventHandler(takePicture);

            return view;
        }
        private void Setup()
        {
            if (this.geolocator != null)
                return;

            geolocator = new Geolocator(this.Activity.BaseContext) { DesiredAccuracy = 50 };
            geolocator.PositionError += OnListeningError;
            geolocator.PositionChanged += OnLocationChanged;
        }

        private void takePicture(object sender, EventArgs e)
        {
            Setup();

            if (!this.geolocator.IsListening)
            {
                if (!this.geolocator.IsGeolocationAvailable || !this.geolocator.IsGeolocationEnabled)
                {
                    Toast.MakeText(this.Activity.BaseContext, "Geolocation is unavailable", ToastLength.Long).Show();
                    return;
                }

                startGeo.Text = "Stop Locating";
                this.geolocator.StartListening(minTime: 30000, minDistance: 0);
            }
            else
            {
                startGeo.Text = "Start Locating";
                this.geolocator.StopListening();
            }
        }

        private void OnLocationChanged(object sender, PositionEventArgs location)
        {

            geoLat.Text = location.Position.Latitude.ToString();
            geoLong.Text = location.Position.Longitude.ToString();
            status.Text = "Received Location";
        }

        private void OnListeningError(object sender, PositionErrorEventArgs error)
        {
            status.Text = error.Error.ToString();
        }
    }
}