using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;

namespace Homework_2;

public partial class MainWindow : Window
{
    private readonly Rectangle? _rectangle;

    public MainWindow()
    {
        InitializeComponent();

        Width = 600;
        Height = 400;

        MinWidth = 300;
        MinHeight = 300;

        _rectangle = this.FindControl<Rectangle>("Rectangle");
    }

    private void ClickHandler(object sender, RoutedEventArgs args)
    {
        var clickedButton = (Button)sender;
        var buttonColor = clickedButton.Background;
        if (_rectangle != null) _rectangle.Fill = buttonColor;
    }
}