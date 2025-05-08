namespace browser
{
    public partial class BrowserForm : Form
    {


        public BrowserForm()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            WebBrowser.Reload();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            WebBrowser.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            WebBrowser.GoForward();
        }

        private void UrlField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    WebBrowser.Source = new UriBuilder(urlField.Text).Uri;
                    WebBrowser.Focus();
                }
                catch (UriFormatException ex)
                {
                    Console.WriteLine("Malformed URL: " + ex);
                    return;
                }
            }
        }
    }
}
