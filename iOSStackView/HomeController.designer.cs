// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSStackView
{
	[Register ("HomeController")]
	partial class HomeController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnLogout { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField lblUser { get; set; }

		[Action ("BtnLogout_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnLogout_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnLogout != null) {
				btnLogout.Dispose ();
				btnLogout = null;
			}
			if (lblUser != null) {
				lblUser.Dispose ();
				lblUser = null;
			}
		}
	}
}
