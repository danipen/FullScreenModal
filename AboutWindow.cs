using System;
using System.Reflection;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

/*using Codice.Utils;
using PlasticGui;
using PlasticGui.WorkspaceWindow;*/
using AppUiFramework;
using Avalonia.Input;
using Avalonia.Controls.Primitives;
/*using AppUiFramework.Exceptions;
using AppUiFramework.Theme;*/

namespace PlasticAvalonia
{
    internal class AboutWindow : PlasticDialog, IDisposable
    {
        public static AboutWindow BuildForGluon(Window parent)
        {
            return new AboutWindow(parent, true);
        }

        public static AboutWindow BuildForPlastic(Window parent)
        {
            return new AboutWindow(parent, false);
        }

        AboutWindow(Window parent, bool bIsGluon) : base(parent)
        {

            InitializeWindow(bIsGluon);

            BuildComponents(bIsGluon);

            System.Threading.Thread.Sleep(100);
        }

        protected override void OnTemplateApplied(TemplateAppliedEventArgs e)
        {
            base.OnTemplateApplied(e);

            //System.Threading.Thread.Sleep(100);
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            //System.Threading.Thread.Sleep(100);
            return base.MeasureOverride(availableSize);


        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            //System.Threading.Thread.Sleep(100);
            return base.ArrangeOverride(finalSize);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void ReleaseNameLink_Click(object sender, EventArgs e)
        {
            //OpenBrowser.TryOpen(GetAboutDialogData.SpotifyLink());
        }

        void ReleaseNotesLink_Click(object sender, EventArgs e)
        {
            //OpenBrowser.TryOpen(GetAboutDialogData.ReleaseNotesLink());
        }

        void VisitUsLink_Click(object sender, EventArgs e)
        {
            //OpenBrowser.TryOpen(mVisitUsLinkLabel.Content as string);
        }

        void MeetUsNotesLink_Click(object sender, EventArgs e)
        {
            //OpenBrowser.TryOpen(mMeetUsLinkLabel.Content as string);
        }

        void IDisposable.Dispose()
        {
            /*EventExceptionsCatcher.UnsetClickEvent(
                mOkButton, OkButton_Click, mEventsTranslator);
            EventExceptionsCatcher.UnsetClickEvent(
                mReleaseNameLinkLabel, ReleaseNameLink_Click, mEventsTranslator);
            EventExceptionsCatcher.UnsetClickEvent(
                mReleaseNotesLinkLabel, ReleaseNotesLink_Click, mEventsTranslator);
            EventExceptionsCatcher.UnsetClickEvent(
                mVisitUsLinkLabel, VisitUsLink_Click, mEventsTranslator);
            EventExceptionsCatcher.UnsetClickEvent(
                mMeetUsLinkLabel, MeetUsNotesLink_Click, mEventsTranslator);*/
        }

        void InitializeWindow(bool bIsGluon)
        {
            SizeToContent = SizeToContent.WidthAndHeight;
            Padding = new Thickness(0);

            Title = "Plastic";
        }

        static void AdjustRowHeights(
            Grid bodyContent,
            double height)
        {
            bodyContent.RowDefinitions.Add(
                new RowDefinition(height, GridUnitType.Pixel));
            bodyContent.RowDefinitions.Add(
                new RowDefinition(height, GridUnitType.Pixel));
            bodyContent.RowDefinitions.Add(
                new RowDefinition(height, GridUnitType.Pixel));
            bodyContent.RowDefinitions.Add(
                new RowDefinition(height, GridUnitType.Pixel));
        }

        void BuildComponents(bool bIsGluon)
        {
            Grid bodyContent = CreateBodyArea();

            StackPanel content= new StackPanel();

            content.Children.Add(
                CreateHeaderArea(bIsGluon));
                content.Children.Add(
                bodyContent);
                content.Children.Add(
                    CreateBottomArea());

            Content = content;

            

            /*AdjustRowHeights(
                bodyContent, mVisitUsLinkLabel.MinHeight);*/
        }

        Panel CreateHeaderArea(bool bIsGluon)
        {
            Panel solidColorPanel = new Panel();
            solidColorPanel.Background = Brushes.White;

            Panel imagePanel = new Panel();

            /*IImage aboutIcon = PlasticImages.GetAboutIcon(
                Assembly.GetExecutingAssembly());*/

            //Image aboutImage = ControlBuilder.Images.CreateImage(aboutIcon);

            /*imagePanel.Width = aboutIcon.Size.Width;
            imagePanel.Height = aboutIcon.Size.Height;*/

            //imagePanel.Children.Add(aboutImage);
            imagePanel.Children.Add(CreateHeaderContentPanel(bIsGluon));
            solidColorPanel.Children.Add(imagePanel);

            return solidColorPanel;
        }

        Panel CreateHeaderContentPanel(bool bIsGluon)
        {
            DockPanel result = new DockPanel();

            TextBlock plasticScmLabel = new TextBlock()
            {

            
               Text =  bIsGluon ? "Gluon" : "Plastic SCM"
            };
            plasticScmLabel.FontSize = 25;
            plasticScmLabel.FontWeight = FontWeight.Bold;

            TextBox releaseNumberLabel = new TextBox()
            {
                Text= "1,1,1,1,"
            };
            releaseNumberLabel.FontSize = 14;

            string releaseNameText = "RELEASE NAME";

            /*mReleaseNameLinkLabel = ControlBuilder.Buttons.CreateLinkLabel(releaseNameText);
            EventExceptionsCatcher.SetClickEvent(
                mReleaseNameLinkLabel, ReleaseNameLink_Click, mEventsTranslator);
            mReleaseNameLinkLabel.Margin = new Thickness(0, -7, 0, 0);

            Panel releaseNumberAndName = EntriesPacker.CreateHPanel(
                ControlBuilder.Margin.Default, releaseNumberLabel, mReleaseNameLinkLabel);

            string releaseNotesText = PlasticLocalization.GetString(
                PlasticLocalization.Name.ReleaseNotesLinkText);*/

            /*mReleaseNotesLinkLabel = ControlBuilder.Buttons.CreateLinkLabel(releaseNotesText);
            EventExceptionsCatcher.SetClickEvent(
                mReleaseNotesLinkLabel, ReleaseNotesLink_Click, mEventsTranslator);
            mReleaseNotesLinkLabel.VerticalAlignment = VerticalAlignment.Bottom;
            mReleaseNotesLinkLabel.HorizontalAlignment = HorizontalAlignment.Left;

            DockPanel.SetDock(plasticScmLabel, Dock.Top);
            DockPanel.SetDock(releaseNumberAndName, Dock.Top);
            DockPanel.SetDock(mReleaseNotesLinkLabel, Dock.Top);

            result.Children.Add(plasticScmLabel);
            result.Children.Add(releaseNumberAndName);
            result.Children.Add(mReleaseNotesLinkLabel);

            result.Margin = new Thickness(ControlBuilder.Margin.DefaultDialogMargin);*/

            return result;
        }

        Grid CreateBodyArea()
        {
            TextBlock copyrightLabel = new TextBlock()
            {
                Text = "CCCCC"
            };
                
            copyrightLabel.VerticalAlignment = VerticalAlignment.Center;
            /*copyrightLabel.MinHeight = ThemeMetrics.GetMetric(
                ThemeMetrics.Name.LinkLabelMinHeight);*/

            Panel visitUsPanel = CreateVisitUsPanel();

            Panel meetUsPanel = CreateMeetUsPanel();

            /*TextBlock designedInLabel = ControlBuilder.TextBlocks.CreateTextBlock(
                PlasticLocalization.GetString(PlasticLocalization.Name.DesignedInText));
            designedInLabel.VerticalAlignment = VerticalAlignment.Center;
            designedInLabel.MinHeight = ThemeMetrics.GetMetric(
                ThemeMetrics.Name.LinkLabelMinHeight);**/

            Grid result = new Grid();

            Grid.SetRow(copyrightLabel, 0);
            Grid.SetRow(visitUsPanel, 1);
            Grid.SetRow(meetUsPanel, 2);
            //Grid.SetRow(designedInLabel, 3);

            result.Children.Add(copyrightLabel);
            result.Children.Add(visitUsPanel);
            result.Children.Add(meetUsPanel);
            //result.Children.Add(designedInLabel);

            result.Margin = new Thickness(
                5);

            return result;
        }

        Panel CreateMeetUsPanel()
        {
            StackPanel result = new StackPanel();
            result.Orientation = Orientation.Horizontal;
            result.VerticalAlignment = VerticalAlignment.Center;

            /*TextBlock meetUsLabel = ControlBuilder.TextBlocks.CreateTextBlock(
                PlasticLocalization.GetString(PlasticLocalization.Name.MeetUsText));
            meetUsLabel.Margin = new Thickness(0, 0, ControlBuilder.Margin.Default, 0);
            meetUsLabel.VerticalAlignment = VerticalAlignment.Center;

            mMeetUsLinkLabel = ControlBuilder.Buttons.CreateLinkLabel(
                PlasticLocalization.GetString(PlasticLocalization.Name.MeetUsLink));
            mMeetUsLinkLabel.VerticalAlignment = VerticalAlignment.Center;
            EventExceptionsCatcher.SetClickEvent(
                mMeetUsLinkLabel, MeetUsNotesLink_Click, mEventsTranslator);

            result.Children.Add(meetUsLabel);
            result.Children.Add(mMeetUsLinkLabel);

            meetUsLabel.MinHeight = ThemeMetrics.GetMetric(
                ThemeMetrics.Name.LinkLabelMinHeight);*/

            return result;
        }

        Panel CreateVisitUsPanel()
        {
            StackPanel result = new StackPanel();
            result.Orientation = Orientation.Horizontal;
            result.VerticalAlignment = VerticalAlignment.Center;

            /*TextBlock visitUsLabel = ControlBuilder.TextBlocks.CreateTextBlock(
                PlasticLocalization.GetString(PlasticLocalization.Name.VisitUsText));
            visitUsLabel.Margin = new Thickness(0, 0, ControlBuilder.Margin.Default, 0);
            visitUsLabel.VerticalAlignment = VerticalAlignment.Center;

            mVisitUsLinkLabel = ControlBuilder.Buttons.CreateLinkLabel(
                PlasticLocalization.GetString(PlasticLocalization.Name.WebsiteLink));
            mVisitUsLinkLabel.VerticalAlignment = VerticalAlignment.Center;
            EventExceptionsCatcher.SetClickEvent(
                mVisitUsLinkLabel, VisitUsLink_Click, mEventsTranslator);

            result.Children.Add(visitUsLabel);
            result.Children.Add(mVisitUsLinkLabel);

            visitUsLabel.MinHeight = ThemeMetrics.GetMetric(
                ThemeMetrics.Name.LinkLabelMinHeight);*/

            return result;
        }

        Panel CreateBottomArea()
        {
            mOkButton = new Button()
                
                {
                    Content = "OK"
                };
            mOkButton.IsDefault = true;
            mOkButton.IsCancel = true;
            /*EventExceptionsCatcher.SetClickEvent(
                mOkButton, OkButton_Click, mEventsTranslator);*/

            //mOkButton.MinWidth = ControlBuilder.Buttons.DIALOG_BUTTONS_MIN_WIDTH;

            Panel result = new StackPanel();
            result.Children.Add(mOkButton);

            result.Margin = new Thickness(
                5);

            return result;
        }

        Button mOkButton;
        Button mReleaseNameLinkLabel;
        Button mReleaseNotesLinkLabel;
        Button mVisitUsLinkLabel;
        Button mMeetUsLinkLabel;

        //ProtectedEventsTranslator mEventsTranslator = new ProtectedEventsTranslator();
    }
}