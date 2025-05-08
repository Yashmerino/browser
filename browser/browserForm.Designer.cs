namespace browser
{
    partial class BrowserForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            notifyIcon1 = new NotifyIcon(components);
            panel1 = new Panel();
            panel2 = new Panel();
            RefreshButton = new Button();
            ForwardButton = new Button();
            BackButton = new Button();
            urlField = new TextBox();
            WebBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WebBrowser).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 26);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(RefreshButton);
            panel2.Controls.Add(ForwardButton);
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(urlField);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 24);
            panel2.TabIndex = 1;
            // 
            // RefreshButton
            // 
            RefreshButton.Dock = DockStyle.Left;
            RefreshButton.Location = new Point(56, 0);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(28, 24);
            RefreshButton.TabIndex = 3;
            RefreshButton.Text = "button3";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // ForwardButton
            // 
            ForwardButton.Dock = DockStyle.Left;
            ForwardButton.Location = new Point(28, 0);
            ForwardButton.Name = "ForwardButton";
            ForwardButton.Size = new Size(28, 24);
            ForwardButton.TabIndex = 2;
            ForwardButton.Text = "button2";
            ForwardButton.UseVisualStyleBackColor = true;
            ForwardButton.Click += ForwardButton_Click;
            // 
            // BackButton
            // 
            BackButton.Dock = DockStyle.Left;
            BackButton.Location = new Point(0, 0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(28, 24);
            BackButton.TabIndex = 1;
            BackButton.Text = "button1";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // urlField
            // 
            urlField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            urlField.Location = new Point(90, 0);
            urlField.Name = "urlField";
            urlField.Size = new Size(710, 23);
            urlField.TabIndex = 0;
            urlField.KeyDown += UrlField_KeyDown;
            // 
            // WebBrowser
            // 
            WebBrowser.AllowExternalDrop = true;
            WebBrowser.CreationProperties = null;
            WebBrowser.DefaultBackgroundColor = Color.White;
            WebBrowser.Dock = DockStyle.Fill;
            WebBrowser.Location = new Point(0, 50);
            WebBrowser.Name = "WebBrowser";
            WebBrowser.Size = new Size(800, 400);
            WebBrowser.Source = new Uri("https://google.com", UriKind.Absolute);
            WebBrowser.TabIndex = 2;
            WebBrowser.ZoomFactor = 1D;
            // 
            // BrowserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WebBrowser);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BrowserForm";
            Text = "Simple Browser";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WebBrowser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private Panel panel1;
        private Panel panel2;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebBrowser;
        private TextBox urlField;
        private Button RefreshButton;
        private Button ForwardButton;
        private Button BackButton;
    }
}
