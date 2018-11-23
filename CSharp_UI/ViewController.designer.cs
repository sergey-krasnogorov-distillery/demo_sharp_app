// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CSharp_UI
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField mInputField { get; set; }

		[Outlet]
		AppKit.NSTextField mLabel { get; set; }

		[Outlet]
		AppKit.NSButton mSendButton { get; set; }

		[Action ("OnPushButtonClick:")]
		partial void OnPushButtonClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (mInputField != null) {
				mInputField.Dispose ();
				mInputField = null;
			}

			if (mLabel != null) {
				mLabel.Dispose ();
				mLabel = null;
			}

			if (mSendButton != null) {
				mSendButton.Dispose ();
				mSendButton = null;
			}
		}
	}
}
