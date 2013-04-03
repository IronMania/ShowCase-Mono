using System;
using MonoTouch.UIKit;
namespace iPhone
{
	public class TabController : UITabBarController
	{


		public TabController ()
		{
			HelloWorldController world = new HelloWorldController();
			HellGpsController gps = new HellGpsController();
			HelloCamController cam = new HelloCamController();

			
			var tabs = new UIViewController[]{
				world,
				cam,
				gps

			};

			ViewControllers = tabs;
		}
	}
}

