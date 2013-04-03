
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Threading.Tasks;
using Xamarin.Media;

namespace iPhone
{
	public partial class HelloCamController : UIViewController
	{
	
		private Xamarin.Media.MediaPicker picker;
		private readonly TaskScheduler uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

		public HelloCamController () : base ("HelloCamController", null)
		{
			Title = "Cam";
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
			picker = new MediaPicker();
			takePictureButton.TouchUpInside += TakePicture;

			// Perform any additional setup after loading the view, typically from a nib.
		}

		private void TakePicture (object sender, EventArgs e)
		{
			if(!picker.IsCameraAvailable || !picker.PhotosSupported)
			{
				var alert = new UIAlertView("Device Unsupported", "Your device does not support this feature",new UIAlertViewDelegate(), "OK");
				alert.Show();
				return;
			}

			picker.TakePhotoAsync(new Xamarin.Media.StoreCameraMediaOptions
			                      {
				Name = "test.jpg",
				Directory ="MediaPickerSampel"
			}).ContinueWith(t=>
			                {
				if(t.IsCanceled)
				{	
					return;
				}
				showPhoto(t.Result);

			}, uiScheduler);
		}

		private void showPhoto (MediaFile result)
		{
			imageView.ContentMode = UIViewContentMode.ScaleAspectFit;
			imageView.Image = UIImage.FromFile( result.Path);
		}
	}
}

