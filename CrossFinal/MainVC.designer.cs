// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CrossFinal
{
    [Register ("MainVC")]
    partial class MainVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TestLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TestLabel != null) {
                TestLabel.Dispose ();
                TestLabel = null;
            }
        }
    }
}