using System.Windows.Forms;

namespace browser
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();

            tabControl.SelectedIndexChanged += (s, e) =>
            {
                var browser = GetCurrentBrowser();
                if (browser != null && browser.Source != null)
                {
                    urlField.Text = browser.Source.ToString();
                }
            };
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser()?.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser()?.GoForward();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser()?.Reload();
        }


        private void UrlField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var browser = GetCurrentBrowser();
                if (browser != null)
                {
                    try
                    {
                        browser.Source = new UriBuilder(urlField.Text).Uri;
                        browser.Focus();
                    }
                    catch (UriFormatException ex)
                    {
                        Console.WriteLine("Malformed URL: " + ex);
                    }
                }
            }
        }

        private void NewTabButton_Click(object sender, EventArgs e)
        {
            CreateNewTab("https://google.com");
        }

        private async void CreateNewTab(string url)
        {
            var tabPage = new TabPage("New Tab");

            var browser = new Microsoft.Web.WebView2.WinForms.WebView2
            {
                Dock = DockStyle.Fill,
                ZoomFactor = 1.0,
                CreationProperties = null,
                DefaultBackgroundColor = Color.White
            };

            tabPage.Controls.Add(browser);
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            await browser.EnsureCoreWebView2Async();
            browser.Source = new Uri(url);

            browser.NavigationCompleted += (s, ev) =>
            {
                tabPage.Text = browser.Source?.Host ?? "New Tab";
                if (tabControl.SelectedTab == tabPage)
                {
                    urlField.Text = browser.Source.ToString();
                }
            };
        }

        private Microsoft.Web.WebView2.WinForms.WebView2? GetCurrentBrowser()
        {
            if (tabControl.SelectedTab?.Controls.Count > 0 &&
                tabControl.SelectedTab.Controls[0] is Microsoft.Web.WebView2.WinForms.WebView2 browser)
            {
                return browser;
            }
            return null;
        }

    }
}
