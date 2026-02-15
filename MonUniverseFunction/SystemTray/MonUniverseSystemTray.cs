namespace MonUniverse.MonUniverseFunction.SystemTray
{
    internal static class  MonUniverseSystemTray
    {
        private static NotifyIcon trayIcon = new NotifyIcon()
        {
            Icon = SystemIcons.Application,
            Visible = true,
            Text = "MonUniverse"
        };

        static MonUniverseSystemTray()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Afficher le panneau", null, (s, e) => MonUniverseUI.MonUniverseUI.Instance.Show());
            contextMenu.Items.Add("Quitter", null, (s, e) =>
            {
                trayIcon.Visible = false;
                Application.Exit();
            });
            trayIcon.ContextMenuStrip = contextMenu;
        }

        public static void Load()
        {
            //MonUniverseSystemTray.trayIcon.ShowBalloonTip(300, "Hekk", "hhhh", ToolTipIcon.Info);
        }
    }
}