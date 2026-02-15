using MonUniverse.MonUniverseRessources;

namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {
        // 1er retourner un élément, 2nd, si j'utilise .Add
        // fonction car pas de nécessité de variable
        #region LEFT PAGE
        private Panel CreateLeftPage()
        {
            var leftPage = new Panel()
            {
                Dock = DockStyle.Left,
                Height = 658,
                Width = 376,
                BackColor = Settings.IVORY,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            leftPage.Controls.Add(RunStatePannel());
            leftPage.Controls.Add(LinePanel());
            leftPage.Controls.Add(NotificationPannel());
            leftPage.Controls.Add(LinePanel());
            FolderPanel p = new FolderPanel("applications listées:");
            p.SetFolder("D:\\Mon\\Folders\\Connections");
            leftPage.Controls.Add(p.GetB());
            return leftPage;
        }
        private static Panel LinePanel()
        {
            return new Panel()
            {
                Dock = DockStyle.Top,
                Height = 1,
                Width = 368,
                BackColor = Settings.LINE,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
        }
        private Panel NotificationPannel()
        {
            Panel parent = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 76,
                Width = 368,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            Panel volet1 = new Panel()
            {
                Dock = DockStyle.Left,
                Height = 76,
                Width = 184,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            Panel volet2 = new Panel()
            {
                Dock = DockStyle.Right,
                Height = 76,
                Margin = Settings.NOPADDING,
                Padding = new Padding(26, 16, 26, 16)
            };
            parent.Controls.Add(volet1);
            parent.Controls.Add(volet2);
            TableLayoutPanel panel = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                AutoSize = false,
                BackColor = Settings.IVORY,
                Padding = Settings.NOPADDING
            };
            for (int i = 1; i <= 2; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 2));
            }
            Panel[] panels = new Panel[2];
            for (int i = 0; i < 2; i++)
            {
                Panel btn = new Panel()
                {
                    Margin = Settings.NOPADDING,
                    Padding = Settings.NOPADDING
                };
                panels[i] = btn;
                panel.Controls.Add(btn, 0, i);
            }
            panels[0].Controls.Add(new Label()
            {
                Text = Texts.NOTIFICATIONS,
                Width = 264,
                ForeColor = Settings.BLUE,
                Font = Settings.FONT15,
                Dock = DockStyle.Bottom,
                Margin = Settings.NOPADDING,
                Padding = new Padding(6, 0, 0, 0),
                TextAlign = ContentAlignment.MiddleCenter
            });
            panels[1].Controls.Add(new Label()
            {
                Text = Texts.ZERO,
                ForeColor = Settings.BLUE,
                Font = Settings.FONT20,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopCenter
            });
            volet1.Controls.Add(panel);
            volet2.Controls.Add(clearNotificationButton);
            return parent;
        }
        private Panel RunStatePannel()
        {
            Panel parent = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 274,
                Width = 368,
                BackColor = Settings.IVORY,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            TableLayoutPanel panel = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 7,
                AutoSize = false,
                BackColor = Settings.IVORY,
                Margin = Settings.NOPADDING,
                Padding = new Padding(26)
            };
            for (int i = 1; i <= 7; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 7));
            }
            panel.Controls.Add(notRunningArrow, 0, 0);
            panel.Controls.Add(notRunningText, 1, 0);
            for (int i = 1; i <= Texts.RUNSERVICESTEPS.Count; i++)
            {
                panel.Controls.Add(runStateArrows[Texts.RUNSERVICESTEPS.ElementAt(i - 1).Value], 0, i);
                panel.Controls.Add(runStateTexts[Texts.RUNSERVICESTEPS.ElementAt(i - 1).Value], 1, i);
                panel.Controls.Add(runStateStatus[Texts.RUNSERVICESTEPS.ElementAt(i - 1).Value], 2, i);
            }
            parent.Controls.Add(panel);
            return parent;
        }
        #endregion
    }
}