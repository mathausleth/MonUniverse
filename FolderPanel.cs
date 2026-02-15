using MonUniverse.MonUniverseRessources;
using System.Diagnostics;

namespace MonUniverse
{
    internal class FolderPanel
    {
        Panel barre = new Panel()
        {
            Dock = DockStyle.Top,
            Height = 52,
            Width = 376,
            Margin = Settings.NOPADDING,
            Padding = Settings.NOPADDING
        };
        PictureBox pic = new PictureBox()
        {
            Size = new Size(52, 52),
            Image = new Icon(@"MonUniverseRessources/folder.ico").ToBitmap(),
            SizeMode = PictureBoxSizeMode.CenterImage,
            Margin = Settings.NOPADDING,
            Padding = Settings.NOPADDING,
        };

        string folder = string.Empty;

        Label fileCounter = new Label
        {
            Dock = DockStyle.Left,
            Size = new Size(52, 52),
            Text = Texts.ZERO,
            ForeColor = Settings.BLUE,
            Location = new Point(368 - 50, (52 - 24) / 2),
            BackColor = Settings.IVORY,
            Margin = Settings.NOPADDING,
            Padding = Settings.NOPADDING,
            Font = Settings.FONT16,
            TextAlign = ContentAlignment.MiddleCenter
        };

        public FolderPanel(string texte)
        {
            var PAN = new Panel()
            {
                Dock = DockStyle.Left,
                Size = new Size(52, 52),
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING
            };

            Label label = new Label
            {
                Dock = DockStyle.Left,
                Size = new Size(272, 52),
                Text = texte.ToUpper(),
                AutoSize = false,
                ForeColor = Settings.TEXTCOLOR,
                Margin = Settings.NOPADDING,
                Padding = Settings.NOPADDING,
                Font = Settings.FONT16,
                TextAlign = ContentAlignment.MiddleLeft
            };
            barre.Controls.Add(fileCounter);
            barre.Controls.Add(label);
            barre.Controls.Add(PAN);
            PAN.Controls.Add(pic);
            pic.Click += Pic_Click;
        }

        private void Pic_Click(object? sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(folder) && Directory.Exists(folder))
            {
                Process.Start("explorer.exe", folder);
            }
        }

        public void SetFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                int filecounte = Directory.GetFiles(folderPath).Length;
                fileCounter.Text = filecounte.ToString();
                folder = folderPath;
            }
        }

        public Panel GetB()
        {
            return barre;
        }
    }
}