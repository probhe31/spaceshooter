using System;


namespace SpaceShooter.SpaceShooter
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Settings.Instance == null)
            {
                Settings.Instance = new Settings();
                Settings.Instance.Initialize();
            }
                

            using (var game = new SpaceShooter())
                game.Run();
        }
    }
#endif
}
