// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace HelloWord_iOS
{
	[Register ("HelloWord_iOSViewController")]
	partial class HelloWord_iOSViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnClickme { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labOutput { get; set; }

		[Action ("actionBtn1:")]
		partial void actionBtn1 (MonoTouch.Foundation.NSObject sender);

		[Action ("actionBtn2:")]
		partial void actionBtn2 (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btnClickme != null) {
				btnClickme.Dispose ();
				btnClickme = null;
			}

			if (labOutput != null) {
				labOutput.Dispose ();
				labOutput = null;
			}
		}
	}
}
