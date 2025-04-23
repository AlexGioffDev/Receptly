using Foundation;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using UIKit;

namespace Recept;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        var result = base.FinishedLaunching(application, launchOptions);

        UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.DarkContent;

        if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
        {
            var windowScene = UIApplication.SharedApplication.ConnectedScenes
                .OfType<UIWindowScene>()
                .FirstOrDefault();

            var window = windowScene?
                .Windows
                .FirstOrDefault(w => w.IsKeyWindow);

            if (window != null)
            {
                var statusBarHeight = window.WindowScene?.StatusBarManager?.StatusBarFrame.Height ?? 0;

                var statusBarView = new UIView(new CoreGraphics.CGRect(0, 0, window.Frame.Width, statusBarHeight))
                {
                    BackgroundColor = UIColor.FromRGB(251, 233, 208)
                };

                window.RootViewController?.View?.AddSubview(statusBarView);
            }
        }

        return result;
    }


}
