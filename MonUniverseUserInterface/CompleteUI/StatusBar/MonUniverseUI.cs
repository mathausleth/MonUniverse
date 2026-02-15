using MonUniverse.MonUniverseRessources;

namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {
        private Panel CreateStatusBar()
        {
            Panel statusBar = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 30,
                Width = 754,
                BackColor = Settings.IVORY,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            var ariane = new Panel()
            {
                Dock = DockStyle.Left,
                Height = 26,
                Width = 442,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            var arianeContent = new FlowLayoutPanel()
            {
                AutoSize = true,
                WrapContents = false,
                FlowDirection = FlowDirection.LeftToRight,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            int count = mainStateTexts.Count;
            mainStateArrows = new Label[count - 1];
            int y = 0;
            for (int i = 0; i < count; i++)
            {

                arianeContent.Controls.Add(mainStateTexts.ElementAt(i).Value);
                if (i < count - 1)
                {
                    Label arrow = new Label
                    {
                        Text = Texts.ARROW,
                        AutoSize = true,
                        MinimumSize = new Size(0, 26),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Settings.STOPPED,
                        Font = Settings.FONT15,
                        Margin = Settings.NOPADDING,
                        Padding = Settings.NOPADDING
                    };
                    arianeContent.Controls.Add(arrow);
                    mainStateArrows[y] = arrow;
                    y++;
                }
            }
            ariane.Controls.Add(arianeContent);
            var last = new Panel()
            {
                Dock = DockStyle.Right,
                Height = 26,
                Width = 172,
                Margin = Settings.NOPADDING,
                Padding = new Padding(52, 2, 52, 2),
            };
            last.Controls.Add(startButton);
            statusBar.Controls.Add(last);
            statusBar.Controls.Add(ariane);
            statusBar.Controls.Add(statusPanels[Enums.StatusControls.SEPARATOR]);
            statusBar.Controls.Add(statusPanels[Enums.StatusControls.TEXT]);
            statusBar.Controls.Add(statusPanels[Enums.StatusControls.ICON]);
            foo();
            startButton.Click += StartButtonClick;
            corellationButton.Click += CorrelationButtonClick;
            showTrustedDb.Click += TrustedDbButtonClick;
            showViewDb.Click += ViewDbButtonClick;
            ShowListButtonsClick();
            return statusBar;
        }
    }
}