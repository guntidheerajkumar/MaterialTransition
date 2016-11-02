using Foundation;
using System;
using MaterialTransition;
using UIKit;

namespace Sample
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.View.BackgroundColor = UIColor.FromRGB(54f / 256f, 70f / 256f, 93f / 256f);
		}

		partial void BtnCancelTouchUpInside(UIButton sender)
		{
			this.DismissViewController(true, null);
		}
	}
}