namespace browser
{
    internal static class Browser
    {
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new BrowserForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unhandled exception: {ex}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}