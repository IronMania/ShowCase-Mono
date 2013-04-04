
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iPhone
{
	public partial class HelloWorldController : UIViewController
	{
		public HelloWorldController () : base ("HelloWorldController", null)
		{
			Title="World";
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
			inputName.ShouldReturn = delegate {
				inputName.ResignFirstResponder();
				return true;
			};
			sayHelloButton.TouchUpInside += (object sender, EventArgs e) => {
				string name;
				if(inputName.Text.Length == 0){
					name = "World";
				}else
				{
					name = inputName.Text;
				}
				outputField.Text = string.Format("Hello {0}!",name);

			};

			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}