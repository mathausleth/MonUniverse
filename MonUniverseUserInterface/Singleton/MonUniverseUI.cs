namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {
        #region SINGLETON
        private static MonUniverseUI? _instance = null;
        private static readonly object _lock = new();
        public static MonUniverseUI Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null || _instance.IsDisposed) _instance = new MonUniverseUI();
                    return _instance;
                }
            }
        }
        #endregion
    }
}