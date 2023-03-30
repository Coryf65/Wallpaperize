using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Wallpaperize.UI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Button_Click(object sender, RoutedEventArgs e)
    {
        // change text on click
        var button = (Button)sender;
        button.Content = "Hello !";
    }
}