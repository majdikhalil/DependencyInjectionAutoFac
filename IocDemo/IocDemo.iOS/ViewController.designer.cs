// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace IocDemo.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel containerLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel passwordLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel platformLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel userNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (containerLabel != null) {
                containerLabel.Dispose ();
                containerLabel = null;
            }

            if (passwordLabel != null) {
                passwordLabel.Dispose ();
                passwordLabel = null;
            }

            if (platformLabel != null) {
                platformLabel.Dispose ();
                platformLabel = null;
            }

            if (userNameLabel != null) {
                userNameLabel.Dispose ();
                userNameLabel = null;
            }
        }
    }
}