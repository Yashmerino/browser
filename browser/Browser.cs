namespace browser
{
    internal static class Browser
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new BrowserForm());
        }
    }
}