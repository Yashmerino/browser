using Microsoft.Extensions.Logging;

namespace browser
{
    public partial class BrowserForm : Form
    {
        private readonly ILogger logger;
        private readonly String LOG_FILE_PATH = "logs/log.txt";

        public BrowserForm()
        {
            InitializeComponent();

            ILoggerFactory factory = LoggerFactory.Create(builder =>
            {
                builder.AddFile(LOG_FILE_PATH);
                builder.AddConsole();
            });

            logger = factory.CreateLogger("Browser");

            logger.LogInformation("BrowserForm initialized.");

            tabControl.SelectedIndexChanged += (s, e) =>
            {
                logger.LogInformation("Tab with index {index} selected.", tabControl.SelectedIndex);
                var browser = GetCurrentBrowser();
                if (browser != null && browser.Source != null)
                {
                    urlField.Text = browser.Source.ToString();
                }
            };

            tabControl.MouseUp += TabControl_MouseUp;
        }

        private void TabControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < tabControl.TabCount; i++)
                {
                    Rectangle r = tabControl.GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        logger.LogInformation("Closing tab at index {index}.", i);
                        tabControl.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            logger.LogInformation("Back button pressed.");
            GetCurrentBrowser()?.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            logger.LogInformation("Forward button pressed.");
            GetCurrentBrowser()?.GoForward();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            logger.LogInformation("Refresh button pressed.");
            GetCurrentBrowser()?.Reload();
        }


        private void UrlField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logger.LogInformation("Search submitted and URL was changed to {url}.", urlField.Text);
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
                        logger.LogError("Search submitted with Malformed URL. {e}", ex);
                    }
                }
            }
        }

        private void NewTabButton_Click(object sender, EventArgs e)
        {
            logger.LogInformation("Creating new tab.");
            CreateNewTab("https://google.com");
            logger.LogInformation("New tab created.");
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
