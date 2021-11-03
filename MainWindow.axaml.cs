using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace FullScreenModal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            StackPanel panel = new StackPanel();
            panel.Orientation = Avalonia.Layout.Orientation.Horizontal;
            panel.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center;
            panel.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center;

            Button showModalButton = new Button();
            showModalButton.Click += Button_Click;
            showModalButton.Content = "Show modal window";

            Button showNoModalButton = new Button();
            showNoModalButton.Click += ShowNoModalButton_Click;
            showNoModalButton.Content = "Show no modal window";

            panel.Children.Add(showModalButton);
            panel.Children.Add(showNoModalButton);

            Content = panel;
        }

        private void ShowNoModalButton_Click(object? sender, RoutedEventArgs e)
        {
            Window newWindow = new Window();
            newWindow.Width = 400;
            newWindow.Height = 400;
            newWindow.Show();
        }

        private void Button_Click(object? sender, RoutedEventArgs e)
        {
            Window newWindow = new Window();
            newWindow.Width = 400;
            newWindow.Height = 400;
            newWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            newWindow.ShowDialog(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}