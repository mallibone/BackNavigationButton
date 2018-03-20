using System;
using UIKit;
using PureLayout.Net;

namespace BackNavigationTitle
{
    public class MainViewController : UIViewController
    {
        public MainViewController()
        {
        }

		public override void ViewDidLoad()
        { 
            base.ViewDidLoad();
            Title = "First Page";

            View.BackgroundColor = UIColor.White;
            var button = new UIButton(UIButtonType.System);

            button.SetTitle("Go to next page", UIControlState.Normal);

            View.AddSubview(button);

            button.AutoCenterInSuperview();

            button.TouchUpInside += (s, e) => { 
                NavigationController.PushViewController(new SecondViewController(), true);
            };

            NavigationItem.BackBarButtonItem = new UIBarButtonItem {Title = "Back"};
		}
	}
}
