using MonUniverse.Enums;
using MonUniverse.MonUniverseRessources;

namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {
        private Panel CreateRightPage()
        {
            var rightPage = new Panel()
            {
                Dock = DockStyle.Right,
                Height = 404,
                Width = 376,
                BackColor = Settings.IVORY,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            var tablePanel = new TableLayoutPanel()
            {
                Dock = DockStyle.Top,
                Height = 300,
                Width = 368,
                BackColor = Settings.IVORY,
                Padding = new Padding(52, 30, 52, 30)
            };
            int count = Texts.TEXTFILES.Count;
            for (int i = 1; i <= count; i++)
            {
                tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / count));
                tablePanel.Controls.Add(showListButtons.ElementAt(i - 1).Value);
            }
            var cc = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 50,
                Width = 368,
                BackColor = Settings.NOTIVORY,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };
            rightPage.Controls.Add(cc);
            rightPage.Controls.Add(LinePanel());
            rightPage.Controls.Add(tablePanel);
            rightPage.Controls.Add(LinePanel());
            FolderPanel p = new FolderPanel("ip connues:");
            p.SetFolder("D:\\Mon\\Folders\\IpInfos");
            rightPage.Controls.Add(p.GetB());
            return rightPage;
        }
    }
}