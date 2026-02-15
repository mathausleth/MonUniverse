using MonUniverse.Enums;
using MonUniverse.MonUniverseRessources;

namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {
        #region CREATE SELECTABLE CONTROLS FUNCTIONS
        private static Button CreateCorellationButton()
        {
            Button btn = new Button()
            {
                Text = "CORRELATION",
                Dock = DockStyle.Fill,
                BackColor = Settings.NOTIVORY,
                ForeColor = Settings.TEXTCOLOR,
                FlatStyle = FlatStyle.Flat,
                Margin = Settings.LOWPADDING,
                Font = Settings.FONT13
            };
            btn.FlatAppearance.BorderColor = Settings.LINE;
            btn.FlatAppearance.BorderSize = 1;
            return btn;
        }
        private static Button CreateImageButton()
        {
            Button btn = new Button()
            {
                Dock = DockStyle.Fill,
                Size = new Size(100, 52),
                FlatStyle = FlatStyle.Flat,
                Margin = Settings.LOWPADDING
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }
        private static Button CreateClearNotificationButton()
        {
            Button btn = new Button()
            {
                Text = Texts.CLEAR,
                Dock = DockStyle.Fill,
                BackColor = Settings.NOTIVORY,
                ForeColor = Settings.BLUE,
                FlatStyle = FlatStyle.Flat,
                Margin = Settings.LOWPADDING,
                Font = Settings.FONT13
            };
            btn.FlatAppearance.BorderColor = Settings.BLUE;
            btn.FlatAppearance.BorderSize = 1;
            return btn;
        }
        private static Button CreateStartButton()
        {
            Button btn = new Button()
            {
                Text = Texts.START,
                Dock = DockStyle.Fill,
                BackColor = Settings.NOTIVORY,
                ForeColor = Settings.BLUE,
                FlatStyle = FlatStyle.Flat,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING,
                Font = Settings.FONT9,
                TextAlign = ContentAlignment.TopCenter
            };
            btn.FlatAppearance.BorderColor = Settings.STOPPED;
            btn.FlatAppearance.BorderSize = 2;
            return btn;
        }



        private static Label CreateNoficationCounter()
        {
            return new Label()
            {
                Dock = DockStyle.Fill,
                Text = Texts.ZERO,
                ForeColor = Settings.BLUE,
                Font = Settings.FONT20,
                TextAlign = ContentAlignment.TopCenter
            };
        }
        private static Label CreateNotRunningArrow()
        {
            return new Label
            {
                Dock = DockStyle.Fill,
                Text = Texts.ARROW,
                AutoSize = false,
                Width = Settings.WIDTH,
                ForeColor = Settings.STOPPED,
                Font = Settings.FONT15,
                Margin = Settings.NOPADDING
            };
        }
        private static Label CreateNotRunningText()
        {
            return new Label
            {
                Dock = DockStyle.Fill,
                Text = Texts.NOTRUNNING,
                AutoSize = false,
                Width = 212,
                ForeColor = Settings.STOPPED,
                Font = Settings.FONT13,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
        }
        private static Label CreateStatusText()
        {
            return new Label()
            {
                Dock = DockStyle.Fill,
                Text = Enums.RunStates.STOPPED.ToString(),
                AutoSize = false,
                Size = new Size(96, 30),
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING,
                Font = Settings.FONT13,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }
        private static Label CreateStatusSeparator()
        {
            return new Label()
            {
                Dock = DockStyle.Fill,
                Text = Texts.SEPARATOR,
                AutoSize = false,
                Size = new Size (18, 30),
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING,
                Font = Settings.FONT18,
                TextAlign = ContentAlignment.TopRight
            };
        }
        #endregion
    }
}