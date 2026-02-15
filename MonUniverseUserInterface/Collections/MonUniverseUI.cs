using MonUniverse.MonUniverseRessources;

namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {

        #region CREATE SELECTABLE COLLECTIONS FUNCTIONS
        private void CreateMainStateLabels()
        {
            if (mainStateTexts.Count == 0)
            {
                mainStateTexts.Add(ServiceGenerique.State.INIT, CreateMainStateLabel(Texts.INIT));
                mainStateTexts.Add(ServiceGenerique.State.CHECK, CreateMainStateLabel(Texts.CHECK));
                mainStateTexts.Add(ServiceGenerique.State.RUN, CreateMainStateLabel(Texts.RUN));
                mainStateTexts.Add(ServiceGenerique.State.CLEAN, CreateMainStateLabel(Texts.CLEAN));
                mainStateTexts.Add(ServiceGenerique.State.RESET, CreateMainStateLabel(Texts.RESET));
                mainStateTexts.Add(ServiceGenerique.State.STOP, CreateMainStateLabel(Texts.STOP));
            }
        }
        private static Label CreateMainStateLabel(string text)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                MinimumSize = new Size(0, Settings.WIDTH),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Settings.BLUE,
                Font = Settings.FONT13,
                Margin = Settings.NOPADDING
            };
        }
        private void CreateRunStateControls()
        {
            if (runStateArrows.Count == 0 && runStateStatus.Count == 0 && runStateTexts.Count == 0)
            {
                foreach (KeyValuePair<string, MonUniverseService.State> item in Texts.RUNSERVICESTEPS)
                {
                    Label arrow = new Label
                    {
                        Text = Texts.ARROW,
                        AutoSize = false,
                        Width = Settings.WIDTH,
                        ForeColor = Settings.IVORY,
                        Font = Settings.FONT15,
                        Margin = Settings.NOPADDING,
                        Padding = Settings.NOPADDING //todo: or ?
                    };
                    Label status = new Label
                    {
                        Text = Texts.NOSTATUS,
                        AutoSize = false,
                        Width = 130,
                        ForeColor = Settings.LINE, //todo
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = Settings.FONT15,
                        Margin = Settings.NOPADDING,
                        Padding = Settings.NOPADDING //todo: or ?
                    };
                    Label text = new Label
                    {
                        Text = item.Key,
                        AutoSize = false,
                        Width = 212,
                        ForeColor = Settings.PINK,
                        Font = Settings.FONT13,
                        Margin = Settings.NOPADDING,
                        Padding = Settings.NOPADDING
                    };
                    runStateArrows[item.Value] = arrow;
                    runStateStatus[item.Value] = status;
                    runStateTexts[item.Value] = text;
                }
            }
        }
        private void CreateStatusPanel()
        {
            if (statusPanels.Count == 0)
            {
                statusPanels[Enums.StatusControls.TOPLINE] = new Panel()
                {
                    Dock = DockStyle.Top,
                    Height = 4,
                    BackColor = Settings.STOPPED
                };
                statusPanels[Enums.StatusControls.ICON] = new Panel()
                {
                    Dock = DockStyle.Left,
                    Size = new Size(30, 30),
                    Margin = Settings.NOPADDING,
                    Padding = Settings.NOPADDING,
                    ForeColor = Settings.STOPPED
                };
                statusPanels[Enums.StatusControls.TEXT] = new Panel()
                {
                    Dock = DockStyle.Left,
                    Size = new Size(96, 30),
                    Margin = Settings.NOPADDING,
                    Padding = Settings.NOPADDING,
                    ForeColor = Settings.STOPPED
                };
                statusPanels[Enums.StatusControls.SEPARATOR] = new Panel()
                {
                    Dock = DockStyle.Left,
                    Size = new Size(18, 30),
                    Margin = Settings.NOPADDING,
                    Padding = Settings.NOPADDING,
                    ForeColor = Settings.STOPPED
                };
                statusPanels[Enums.StatusControls.BOTLINE] = new Panel()
                {
                    Dock = DockStyle.Top,
                    Height = 4,
                    BackColor = Settings.STOPPED
                };

                statusPanels[Enums.StatusControls.ICON].Controls.Add(new Label()
                {
                    Dock = DockStyle.Fill,
                    Text = "\u26AB",
                    Size = new Size(30, 30),
                    TextAlign = ContentAlignment.MiddleRight,
                    Font = Settings.FONT10,
                });
                statusPanels[Enums.StatusControls.TEXT].Controls.Add(this.statusText);
                statusPanels[Enums.StatusControls.SEPARATOR].Controls.Add(CreateStatusSeparator());
            }
        }
        private void CreateShowTextButtons()
        {
            if (showListButtons.Count == 0)
            {
                foreach (KeyValuePair<Enums.ListingButtons, string> textfile in Texts.TEXTFILES)
                {
                    Button btn = new Button()
                    {
                        Text = textfile.Key.ToString(),
                        Dock = DockStyle.Fill,
                        BackColor = Settings.NOTIVORY,
                        ForeColor = Settings.BLUE,
                        FlatStyle = FlatStyle.Flat,
                        Margin = Settings.LOWPADDING,
                        Padding = Settings.NOPADDING,
                        Font = Settings.FONT13
                    };
                    btn.FlatAppearance.BorderColor = Settings.BLUE;
                    btn.FlatAppearance.BorderSize = 2;
                    showListButtons[textfile.Key] = btn;
                    //btn.Click += ShowListButtonsClick;
                }
            }
        }
        #endregion
    }
}