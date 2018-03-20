using UIKit;
using PureLayout.Net;

namespace BackNavigationTitle
{
    public class ThirdViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Third Page";
            View.BackgroundColor = UIColor.White;

            var label = new UILabel { Text = "Only back from here on..." };

            View.AddSubview(label);

            label.AutoCenterInSuperview();
        }
    }
}
