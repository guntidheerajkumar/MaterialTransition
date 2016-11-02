using Foundation;
using System;
using UIKit;
using MaterialTransition;
using CoreGraphics;

namespace Sample
{
	public partial class FirstViewController : UIViewController, IUIViewControllerAnimatedTransitioning, IUIViewControllerTransitioningDelegate
	{
		private JTMaterialTransition transition;
		public FirstViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			CreateTransition();
		}

		partial void BtnHomeTouchUpInside(UIButton sender)
		{
			var controller = UIStoryboard.FromName("Main", null).InstantiateViewController("SecondViewController");
			controller.ModalPresentationStyle = UIModalPresentationStyle.Custom;
			controller.TransitioningDelegate = this;
			this.PresentViewController(controller, true, null);
		}

		private void CreateTransition()
		{
			transition = new JTMaterialTransition(BtnHome);
		}

		public double TransitionDuration(IUIViewControllerContextTransitioning transitionContext)
		{
			return 1f;
		}

		public void AnimateTransition(IUIViewControllerContextTransitioning transitionContext)
		{
		}

		[Export("animationControllerForPresentedController:presentingController:sourceController:")]
		public IUIViewControllerAnimatedTransitioning GetAnimationControllerForPresentedController(UIViewController presented, UIViewController presenting, UIViewController source)
		{
			transition.Reverse = false;
			return transition;
		}

		[Export("animationControllerForDismissedController:")]
		public IUIViewControllerAnimatedTransitioning GetAnimationControllerForDismissedController(UIViewController dismissed)
		{
			transition.Reverse = true;
			return transition;
		}
	}
}