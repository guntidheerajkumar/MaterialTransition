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

namespace Sample
{
    [Register ("FirstViewController")]
    partial class FirstViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnHome { get; set; }

        [Action ("BtnHomeTouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnHomeTouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BtnHome != null) {
                BtnHome.Dispose ();
                BtnHome = null;
            }
        }
    }
}