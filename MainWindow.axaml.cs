using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Threading;
using PlasticAvalonia;

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

            Border launcherPanel = new Border();
            launcherPanel.Width = 200;
            launcherPanel.Height = 100;
            launcherPanel.Background = Brushes.LightGray;
            launcherPanel.DoubleTapped += launcherPanel_DoubleTapped;
            TextBlock textBlock = new TextBlock();
            textBlock.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center;
            textBlock.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center;
            textBlock.Text = "Double click me";
            launcherPanel.Child = textBlock;

            panel.Children.Add(showModalButton);
            panel.Children.Add(showNoModalButton);
            panel.Children.Add(launcherPanel);

            Content = panel;
        }

        void launcherPanel_DoubleTapped(object? sender, RoutedEventArgs e)
        {
            Window newWindow = new Window();
            newWindow.Width = 400;
            newWindow.Height = 400;
            newWindow.Show();
        }

        private void ShowNoModalButton_Click(object? sender, RoutedEventArgs e)
        {
            Window newWindow = new Window();
            newWindow.Width = 400;
            newWindow.Height = 400;
            newWindow.Show();
        }

        private async void Button_Click(object? sender, RoutedEventArgs e)
        {
            using (AboutWindow newWindow = AboutWindow.BuildForPlastic(this))
            //Window newWindow = new Window();
            {
                newWindow.Width = 400;
                newWindow.Height = 400;
                //newWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                await newWindow.ShowDialog(this);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}