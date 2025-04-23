using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;


namespace Recept;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        On<iOS>().SetUseSafeArea(false);
    }
}
