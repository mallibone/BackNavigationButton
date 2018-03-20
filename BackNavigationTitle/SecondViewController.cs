using UIKit;
using PureLayout.Net;

namespace BackNavigationTitle
{
    public class SecondViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Second Page";
            View.BackgroundColor = UIColor.White;

            var button = new UIButton(UIButtonType.System);

            button.SetTitle("Go to next page", UIControlState.Normal);

            View.AddSubview(button);

            button.AutoCenterInSuperview();

            button.TouchUpInside += (s, e) =>
            {
                NavigationController.PushViewController(new ThirdViewController(), true);
            };

            NavigationItem.BackBarButtonItem = new UIBarButtonItem { Title = "Zurück" };
        }
    }
}
