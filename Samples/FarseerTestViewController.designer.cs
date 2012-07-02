// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace FarseerTest
{
	[Register ("FarseerTestViewController")]
	partial class FarseerTestViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton fallingButton { get; set; }

		[Action ("fallingButtonPressed:")]
		partial void fallingButtonPressed (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (fallingButton != null) {
				fallingButton.Dispose ();
				fallingButton = null;
			}
		}
	}
}
