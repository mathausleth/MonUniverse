using MonUniverse.MonUniverseRessources;

namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {
        private Panel CreateDataBar()
        {
            var dataBar = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 52,
                BackColor = Settings.NOTIVORY
            };
            dataBar.Controls.Add(CreateLeftMenu());
            dataBar.Controls.Add(CreateRightMenu());
            return dataBar;
        }

        private Panel CreateLeftMenu()
        {
            var panel = new Panel()
            {
                Dock = DockStyle.Left,
                Height = 52,
                Width = 376,
                BackColor = Settings.IVORY,
                Margin = Settings.NOPADDING,
                Padding = new Padding(26, 6, 26, 7)
            };
            panel.Controls.Add(this.corellationButton);
            return panel;
        }

        private Panel CreateRightMenu()
        {
            var panel = new Panel()
            {
                Dock = DockStyle.Right,
                Height = 52,
                Width = 376,
                BackColor = Settings.IVORY,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            var leftPanel = new Panel()
            {
                Dock = DockStyle.Left,
                Height = 52,
                Width = 188,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            var rightPanel = new Panel()
            {
                Dock = DockStyle.Right,
                Height = 52,
                Width = 188,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            panel.Controls.Add(leftPanel);
            panel.Controls.Add(rightPanel);
            showTrustedDb.Image = Properties.Resources.ButtonTrusted;
            showViewDb.Image = Properties.Resources.ButtonView;
            leftPanel.Controls.Add(showTrustedDb);
            rightPanel.Controls.Add(showViewDb);
            return panel;
        }
    }
}