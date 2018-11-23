using System;
using System.Collections;
using AppKit;
using Foundation;

namespace CSharp_UI
{
    public partial class ViewController : NSViewController
    {
        private ArrayList mMessageList = new ArrayList(){"Hello! How are you?", "What is your name?", "I'm tired. Let's finish this. \nBut this logic is placed in C# code without ObjectiveC"};
        private int mMessageIndex = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            mSendButton.Enabled = false;
            this.Invoke(SayHello, 1.0f);
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void OnPushButtonClick(Foundation.NSObject sender)
        {
            mLabel.StringValue = mLabel.StringValue + "\n" + mInputField.StringValue;
            if (mMessageIndex < mMessageList.Count)
            {
                mLabel.StringValue = mLabel.StringValue + "\n" + mMessageList[mMessageIndex].ToString();
                mMessageIndex++;
            }
            else
            {
                mLabel.StringValue = mLabel.StringValue + "\n" + "I'm tired. Go away!";
            }
            mInputField.StringValue = "";
        }

        public void SayHello()
        {
            mSendButton.Enabled = true;
            mLabel.StringValue = mMessageList[mMessageIndex].ToString();
            mMessageIndex++;
        }
    }
}
