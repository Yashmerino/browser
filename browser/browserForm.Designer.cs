using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            notifyIcon1 = new NotifyIcon(components);
            tabControl = new TabControl();
            panel = new Panel();
            RefreshButton = new Button();
            ForwardButton = new Button();
            BackButton = new Button();
            urlField = new TextBox();
            newTabButton = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 24);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(804, 448);
            tabControl.TabIndex = 0;
            // 
            // panel
            // 
            panel.Controls.Add(RefreshButton);
            panel.Controls.Add(ForwardButton);
            panel.Controls.Add(BackButton);
            panel.Controls.Add(urlField);
            panel.Controls.Add(newTabButton);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(804, 24);
            panel.TabIndex = 1;
            // 
            // RefreshButton
            // 
            RefreshButton.Dock = DockStyle.Left;
            RefreshButton.Font = new Font("Segoe UI", 7F);
            RefreshButton.Image = (Image)resources.GetObject("RefreshButton.Image");
            RefreshButton.Location = new Point(56, 0);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(28, 24);
            RefreshButton.TabIndex = 3;
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // ForwardButton
            // 
            ForwardButton.Dock = DockStyle.Left;
            ForwardButton.Image = (Image)resources.GetObject("ForwardButton.Image");
            ForwardButton.Location = new Point(28, 0);
            ForwardButton.Name = "ForwardButton";
            ForwardButton.Size = new Size(28, 24);
            ForwardButton.TabIndex = 2;
            ForwardButton.UseVisualStyleBackColor = true;
            ForwardButton.Click += ForwardButton_Click;
            // 
            // BackButton
            // 
            BackButton.Dock = DockStyle.Left;
            BackButton.Image = (Image)resources.GetObject("BackButton.Image");
            BackButton.Location = new Point(0, 0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(28, 24);
            BackButton.TabIndex = 1;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // urlField
            // 
            urlField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            urlField.BackColor = SystemColors.Menu;
            urlField.BorderStyle = BorderStyle.FixedSingle;
            urlField.Location = new Point(90, 0);
            urlField.Name = "urlField";
            urlField.Size = new Size(678, 23);
            urlField.TabIndex = 0;
            urlField.KeyDown += UrlField_KeyDown;
            // 
            // newTabButton
            // 
            newTabButton.Dock = DockStyle.Right;
            newTabButton.Image = (Image)(new Bitmap(Properties.Resources.addTab, new Size(16, 16)));
            newTabButton.Location = new Point(774, 0);
            newTabButton.Name = "newTabButton";
            newTabButton.Size = new Size(30, 24);
            newTabButton.TabIndex = 1;
            newTabButton.Click += NewTabButton_Click;
            // 
            // BrowserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 472);
            Controls.Add(tabControl);
            Controls.Add(panel);
            Name = "BrowserForm";
            Text = "Simple Browser";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private Panel panel;
        private TextBox urlField;
        private Button RefreshButton;
        private Button ForwardButton;
        private Button BackButton;
        private TabControl tabControl;
        private Button newTabButton;
    }
}
