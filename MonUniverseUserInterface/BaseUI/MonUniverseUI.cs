using MonUniverse.MonUniverseData.Tables;
using MonUniverse.MonUniverseRessources;
using System.Diagnostics;

namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {
        private bool firstCut = false;
        private bool secondCut = false;
        private void FirstCut()
        {
            if (!firstCut)
            {
                firstCut = true;
                var blue = new Panel
                {
                    Dock = DockStyle.Top,
                    BackColor = Settings.BLUE,
                    Height = this.ClientSize.Height / 2,
                    Width = this.ClientSize.Width
                };
                var pink = new Panel
                {
                    Dock = DockStyle.Top,
                    BackColor = Settings.PINK,
                    Height = this.ClientSize.Height / 2,
                    Width = this.ClientSize.Width
                };
                var client = new Panel
                {
                    BackColor = Settings.LINE,
                    Height = 494,//19
                    Width = 754 //29
                };
                client.Top = (this.ClientSize.Width - client.Width) / 2;
                client.Left = (this.ClientSize.Height - client.Height) / 2;
                this.Controls.Add(client);
                this.Controls.Add(pink);
                this.Controls.Add(blue);
                SecondCut(client);
            }
        }
        private void SecondCut(Panel clientPanel)
        {
            if (!secondCut)
            {
                secondCut = true;
                clientPanel.Controls.Add(CreateLeftPage());
                clientPanel.Controls.Add(CreateRightPage());
                clientPanel.Controls.Add(statusPanels[Enums.StatusControls.BOTLINE]);
                clientPanel.Controls.Add(CreateStatusBar());
                clientPanel.Controls.Add(statusPanels[Enums.StatusControls.TOPLINE]);
                clientPanel.Controls.Add(CreateDataBar());
            }
        }

    }
}