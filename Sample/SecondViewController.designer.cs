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
    [Register ("SecondViewController")]
    partial class SecondViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnCancel { get; set; }

        [Action ("BtnCancelTouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnCancelTouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BtnCancel != null) {
                BtnCancel.Dispose ();
                BtnCancel = null;
            }
        }
    }
}