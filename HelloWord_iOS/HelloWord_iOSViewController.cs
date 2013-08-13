using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWord_iOS
{
	public partial class HelloWord_iOSViewController : UIViewController
	{
		protected int _CntClickme = 0;
		public HelloWord_iOSViewController () : base ("HelloWord_iOSViewController", null)
		{
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
			this.btnClickme.TouchUpInside += (sender,e) => {
				this._CntClickme++;
				this.labOutput.Text = "Clicked [" + this._CntClickme.ToString () + "] times!";
			};
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
//		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
//		{
//			// Return true for supported orientations
//			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
//		}
		partial void actionBtn1(MonoTouch.Foundation.NSObject sender)
		{
			this.labOutput.Text="Action Button "+((UIButton)sender).CurrentTitle;
		}
		partial void actionBtn2(MonoTouch.Foundation.NSObject sender)
		{
			this.labOutput.Text="Action Button "+((UIButton)sender).CurrentTitle;
		}
	}
}

