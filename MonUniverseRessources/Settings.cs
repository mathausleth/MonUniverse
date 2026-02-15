namespace MonUniverse.MonUniverseRessources
{
    internal class Settings
    {
        #region SETTINGS
        public static Color PINK = Couleurs.Couleurs.CEROSE;
        public static Color BLUE = Couleurs.Couleurs.CEBLEU;
        public static Color IVORY = Couleurs.Couleurs.IVOIRE;
        public static Color NOTIVORY = Color.FromArgb(255, 250, 240);
        public static Color LINE = Color.FromArgb(226, 226, 226);
        public static Color TEXTCOLOR = Color.FromArgb(180, 180, 180);
        public static Color RUNNING = Couleurs.Couleurs.VERT;
        public static Color STARTING = Couleurs.Couleurs.JAUNEVERT;
        public static Color STOPPING = Couleurs.Couleurs.ORANGE;
        public static Color STOPPED = Couleurs.Couleurs.SOMBROUGE;
        public static Font FONT9 = new Font("Consolas", 9, FontStyle.Bold);
        public static Font FONT10 = new Font("Consolas", 10, FontStyle.Bold);
        public static Font FONT13 = new Font("Consolas", 13, FontStyle.Bold);
        public static Font FONT13LINE = new Font("Consolas", 13, FontStyle.Bold | FontStyle.Underline);
        public static Font FONT15 = new Font("Consolas", 15, FontStyle.Bold);
        public static Font FONT16 = new Font("Consolas", 16, FontStyle.Bold);
        public static Font FONT18 = new Font("Consolas", 18, FontStyle.Bold);
        public static Font FONT20 = new Font("Consolas", 20, FontStyle.Bold);
        public static Padding NOPADDING = new Padding(0);
        public static Padding LOWPADDING = new Padding(0, 6, 0, 7);
        public static int WIDTH = 26;
        #endregion
    }
}