using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MaterialTransition
{
	// @interface JTMaterialTransition : NSObject <UIViewControllerAnimatedTransitioning>
	[BaseType(typeof(NSObject))]
	interface JTMaterialTransition : IUIViewControllerAnimatedTransitioning
	{
		// @property (nonatomic, weak) UIView * animatedView;
		[Export("animatedView", ArgumentSemantic.Weak)]
		UIView AnimatedView { get; set; }

		// @property (nonatomic) CGRect startFrame;
		[Export("startFrame", ArgumentSemantic.Assign)]
		CGRect StartFrame { get; set; }

		// @property (nonatomic) UIColor * startBackgroundColor;
		[Export("startBackgroundColor", ArgumentSemantic.Assign)]
		UIColor StartBackgroundColor { get; set; }

		// @property (getter = isReverse) BOOL reverse;
		[Export("reverse")]
		bool Reverse { [Bind("isReverse")] get; set; }

		// -(instancetype)initWithAnimatedView:(UIView *)animatedView;
		[Export("initWithAnimatedView:")]
		IntPtr Constructor(UIView animatedView);
	}
}
