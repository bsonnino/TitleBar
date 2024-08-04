using Microsoft.UI;
using Microsoft.UI.Input;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using System;
using Windows.Foundation;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TitleBarColors
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private AppWindow _appWindow;
        private AppWindowTitleBar _titleBar;

        public MainWindow()
        {
            _appWindow = this.AppWindow;
            _appWindow.Title = "My new WinUI App";
            _appWindow.SetIcon("AppIcon.ico");
            if (AppWindowTitleBar.IsCustomizationSupported())
            {
                _titleBar = _appWindow.TitleBar;
                SetTitleBarColors();
            }
        }
        
        private void SetTitleBarColors()
        {
            if (AppWindowTitleBar.IsCustomizationSupported())
            {
                var titleBar = AppWindow.TitleBar;
                // Set active window colors.
                titleBar.ForegroundColor = Colors.White;
                titleBar.BackgroundColor = ColorHelper.FromArgb(0xff, 0xb0, 0x0e, 0x25);
                titleBar.ButtonForegroundColor = Colors.White;
                titleBar.ButtonBackgroundColor = ColorHelper.FromArgb(0xff, 0xb0, 0x0e, 0x25);
                titleBar.ButtonHoverForegroundColor = Colors.White;
                titleBar.ButtonHoverBackgroundColor = ColorHelper.FromArgb(0xff, 0x82, 0x03, 0x1c);
                titleBar.ButtonPressedForegroundColor = Colors.White;
                titleBar.ButtonPressedBackgroundColor = ColorHelper.FromArgb(0xff, 0x82, 0x03, 0x1c);

                // Set inactive window colors.
                titleBar.InactiveForegroundColor = Colors.Black;
                titleBar.InactiveBackgroundColor = ColorHelper.FromArgb(0xff, 0xfe, 0xc1, 0xc1);
                titleBar.ButtonInactiveForegroundColor = Colors.Black;
                titleBar.ButtonInactiveBackgroundColor = ColorHelper.FromArgb(0xff, 0xfe, 0xc1, 0xc1);
            }
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
        }
    }
}
