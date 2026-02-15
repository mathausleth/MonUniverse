using MonUniverse.MonUniverseEngine;
using MonUniverse.MonUniverseFunction.SystemTray;
namespace MonUniverse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MonUniverseSystemTray.Load();
            Check.VerifyAllPath();
            Check.VerifyAllFiles();
            Application.Run();
        }
    }
}