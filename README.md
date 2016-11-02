# MaterialTransition
Material Transition

This is Obj-C Binding project based on https://github.com/jonathantribouharet/JTMaterialTransition.

### First View Controller

```
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
```
### Second View Controller

```
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
```

### Output

![](https://github.com/guntidheerajkumar/MaterialTransition/blob/master/Output.gif)
