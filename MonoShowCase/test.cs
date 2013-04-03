using System.Linq;
using System.Text;
using Android.App;
using Android.Locations;
using Android.OS;
using Android.Widget;
using Java.IO;

namespace MonoShowCase
{

   //public class LocationActivity : ILocationListener
   // {
   //     private TextView _locationText;
   //     private LocationManager _locationManager;
   //     private StringBuilder _builder;
   //     private Geocoder _geocoder;

   //     public LocationActivity(LocationManager locationManager)
   //     {



   //         _builder = new StringBuilder();
   //         _geocoder = new Geocoder(this);


   //         _locationManager = locationManager;

   //         var criteria = new Criteria() { Accuracy = Accuracy.NoRequirement };
   //         string bestProvider = _locationManager.GetBestProvider(criteria, true);

   //         Location lastKnownLocation = _locationManager.GetLastKnownLocation(bestProvider);

   //         if (lastKnownLocation != null)
   //         {
   //             _locationText.Text = string.Format("Last known location, lat: {0}, long: {1}",
   //                                                lastKnownLocation.Latitude, lastKnownLocation.Longitude);
   //         }

   //         _locationManager.RequestLocationUpdates(bestProvider, 5000, 2, this);
   //     }

   //     public void OnLocationChanged(Location location)
   //     {
   //         _builder.AppendLine(
   //             string.Format("Location updated, lat: {0}, long: {1}",
   //                       location.Latitude, location.Longitude)
   //             );

   //         try
   //         {
   //             Address address =
   //                 _geocoder
   //                     .GetFromLocation(location.Latitude, location.Longitude, 1)
   //                     .FirstOrDefault();

   //             if (address != null)
   //             {
   //                 _builder.AppendLine(" -> " + address.CountryName);
   //             }
   //         }
   //         catch (IOException io)
   //         {
   //             Android.Util.Log.Debug("LocationActivity", io.Message);
   //         }

   //         _locationText.Text = _builder.ToString();
   //     }

   //     void ILocationListener.OnLocationChanged(Location location)
   //     {
   //         throw new System.NotImplementedException();
   //     }

   //     void ILocationListener.OnProviderDisabled(string provider)
   //     {
   //         throw new System.NotImplementedException();
   //     }

   //     void ILocationListener.OnProviderEnabled(string provider)
   //     {
   //         throw new System.NotImplementedException();
   //     }

   //     void ILocationListener.OnStatusChanged(string provider, Availability status, Bundle extras)
   //     {
   //         throw new System.NotImplementedException();
   //     }

   //     void System.IDisposable.Dispose()
   //     {
   //         throw new System.NotImplementedException();
   //     }

   //     System.IntPtr Android.Runtime.IJavaObject.Handle
   //     {
   //         get { throw new System.NotImplementedException(); }
   //     }
   // }
}

