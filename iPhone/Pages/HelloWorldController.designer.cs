// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace iPhone
{
	[Register ("HelloWorldController")]
	partial class HelloWorldController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField inputName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel outputField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton sayHelloButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (inputName != null) {
				inputName.Dispose ();
				inputName = null;
			}

			if (outputField != null) {
				outputField.Dispose ();
				outputField = null;
			}

			if (sayHelloButton != null) {
				sayHelloButton.Dispose ();
				sayHelloButton = null;
			}
		}
	}
}
