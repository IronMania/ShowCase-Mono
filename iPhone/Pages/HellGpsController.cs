
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Geolocation;

namespace iPhone
{
	public partial class HellGpsController : UIViewController
	{
		private Geolocator geolocator;
		public HellGpsController () : base ("HellGpsController", null)
		{
			Title = "GPS";
			TabBarItem.Image = UIImage.FromFile("Images/second.png");
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			geolocator = new Geolocator(){DesiredAccuracy = 50};
			geolocator.PositionError += OnListeningError;
			geolocator.PositionChanged += OnLocationChanged;
			startLocatingButton.TouchUpInside  +=toggleGeolocation;
			// Perform any additional setup after loading the view, typically from a nib.
		}


		private void toggleGeolocation (object sender, EventArgs e)
		{
			if(!this.geolocator.IsListening){
//				if (!this.geolocator.IsGeolocationAvailable || !this.geolocator.IsGeolocationEnabled)
//				{
//					return;
//				}
				startLocatingButton.SetTitle("stop Locating", UIControlState.Normal);
				this.geolocator.StartListening(minTime:30000,minDistance:0);
			}else
			{
				startLocatingButton.SetTitle("start Locating", UIControlState.Normal);
				this.geolocator.StopListening();
				statusLavel.Text = "stopped Locating";

			}
		}

		void OnListeningError (object sender, PositionErrorEventArgs e)
		{
			statusLavel.Text = e.Error.ToString();
		}

		void OnLocationChanged (object sender, PositionEventArgs e)
		{
			latLabel.Text = e.Position.Latitude.ToString();
			longLabel.Text = e.Position.Longitude.ToString();
			statusLavel.Text = "received Location";
		}
	}
}

