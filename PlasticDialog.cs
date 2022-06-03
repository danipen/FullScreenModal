using System.Reflection;
//using AppUiFramework.Exceptions;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;

//using AppUiFramework.Native.Windows;
using Avalonia.Interactivity;
/*using Codice.Utils;
using PlasticGui;*/

namespace AppUiFramework
{
    public class PlasticDialog : Window
    {
        public Panel ButtonsPanel { get { return mButtonsPanel; } }

        public PlasticDialog(Window owner)
        {
#if DEBUG
            this.AttachDevTools();
#endif
            SystemDecorations = SystemDecorations.Full;
            Padding = new Thickness(5);

            CanResize = false;
            SizeToContent = SizeToContent.Height;
            Owner = owner;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;

            /*Icon = PlasticImages.GetApplicationWindowIcon(
                Assembly.GetExecutingAssembly());*/

            BuildComponents();


        }

        protected void SetTitle(string title)
        {
            mHeaderPanel.IsVisible = true;

            TextBlock titleTextBlock =
                new TextBlock()
                {
                    Text = title
                };

            titleTextBlock.VerticalAlignment = VerticalAlignment.Center;

            DockPanel.SetDock(titleTextBlock, Dock.Top);
            mHeaderPanel.Children.Add(titleTextBlock);
        }

        protected void SetTitle(Control titleContent)
        {
            mHeaderPanel.IsVisible = true;

            titleContent.VerticalAlignment = VerticalAlignment.Center;

            DockPanel.SetDock(titleContent, Dock.Top);
            mHeaderPanel.Children.Add(titleContent);
        }

        protected void SetExplanation(string explanation)
        {
            mHeaderPanel.IsVisible = true;

            TextBlock explanationTextBlock =
            new TextBlock()
            {Text = explanation};
                

            explanationTextBlock.Margin = new Thickness(0, 2 * 5, 0, 0);
            explanationTextBlock.VerticalAlignment = VerticalAlignment.Center;
            DockPanel.SetDock(explanationTextBlock, Dock.Top);
            mHeaderPanel.Children.Add(explanationTextBlock);
        }

        protected void AddComponents(
            params Control[] controls)
        {
            /*EntriesPacker.SetComponentLayoutForDialog(false, controls);

            foreach (Control control in controls)
                mComponentsPanel.Children.Add(control);*/
        }

        protected void AddLeftPanelInButtonsArea(Control control)
        {
            control.Margin = new Thickness(0, 0, 5, 0);

            mBottomPanel.Children.Add(
                control);
        }

        protected void AddFillPanelInButtonsArea(Control control)
        {
            /*control.Margin = new Thickness(0, 0, ControlBuilder.Margin.Default, 0);

            mBottomPanel.LastChildFill = true;
            mBottomPanel.AddChildren(
                fill: control);*/
        }

        protected void AddButtons(
            Button acceptActionButton,
            Button cancelActionButton,
            Button thirdActionButton = null)
        {
            AddButtonsToPanel(
                mButtonsPanel,
                acceptActionButton,
                cancelActionButton,
                thirdActionButton);
        }

        public static void AddButtonsToPanel(
            Panel buttonsPanel,
            Button acceptActionButton,
            Button cancelActionButton,
            Button thirdActionButton = null)
        {
           
            AddButtonsToPanelInSpecificOrder(
                buttonsPanel,
                cancelActionButton,
                thirdActionButton,
                acceptActionButton);
        }

        void BuildComponents()
        {
            mHeaderPanel = new DockPanel();
            mHeaderPanel.IsVisible = false;

            mComponentsPanel = new DockPanel();
            mBottomPanel = new DockPanel();

            mButtonsPanel = new StackPanel();
            mButtonsPanel.Orientation = Orientation.Horizontal;
            mButtonsPanel.HorizontalAlignment = HorizontalAlignment.Right;

            /*mBottomPanel.AddChildren(
                right: new Control[] { mButtonsPanel });*/

            mHeaderPanel.Margin = new Thickness(BORDER_WIDTH);
            mComponentsPanel.Margin = new Thickness(BORDER_WIDTH);
            mBottomPanel.Margin = new Thickness(BORDER_WIDTH);

            DockPanel content = new DockPanel();

            /*content.AddChildren(
                top: new Control[] { mHeaderPanel },
                fill: mComponentsPanel,
                bottom: new Control[] { mBottomPanel });*/

            Content = content;
        }

        static void AddButtonsToPanelInSpecificOrder(
            Panel buttonsPanel,
            params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                if (button == null)
                    continue;

                /*button.Margin = new Thickness(ControlBuilder.Margin.Default, 0, 0, 0);
                button.MinWidth = ControlBuilder.Buttons.DIALOG_BUTTONS_MIN_WIDTH;*/
                buttonsPanel.Children.Add(button);
            }
        }

        DockPanel mHeaderPanel;
        DockPanel mComponentsPanel;
        DockPanel mBottomPanel;
        StackPanel mButtonsPanel;
        Button mCloseButton;
        const int BORDER_WIDTH = 10;

        //readonly ProtectedEventsTranslator mEventsTranslator = new ProtectedEventsTranslator();
    }
}