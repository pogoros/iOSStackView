using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSStackView
{
	partial class HomeController : UIViewController
	{
		

		public HomeController (IntPtr handle) : base (handle)
		{
		}

		public string UserName;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			lblUser.Text = UserName;

		}

		partial void BtnLogout_TouchUpInside (UIButton sender)
		{
				ViewController controller =
				this.Storyboard.InstantiateViewController("login") as ViewController;

			this.NavigationController.PushViewController(controller, true);
		}
	}
}
