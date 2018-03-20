using Foundation;
using System;
using UIKit;

namespace BackNavigationStoryboardTitle
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            NavigationItem.BackBarButtonItem = new UIBarButtonItem { Title = "Zurück" };
		}
	}
}