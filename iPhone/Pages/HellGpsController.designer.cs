// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace iPhone
{
	[Register ("HellGpsController")]
	partial class HellGpsController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton startLocatingButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel statusLavel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel longLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel latLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (startLocatingButton != null) {
				startLocatingButton.Dispose ();
				startLocatingButton = null;
			}

			if (statusLavel != null) {
				statusLavel.Dispose ();
				statusLavel = null;
			}

			if (longLabel != null) {
				longLabel.Dispose ();
				longLabel = null;
			}

			if (latLabel != null) {
				latLabel.Dispose ();
				latLabel = null;
			}
		}
	}
}
