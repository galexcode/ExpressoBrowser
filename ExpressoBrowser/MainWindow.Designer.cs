namespace ExpressoBrowser
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.browser = new WebKit.WebKitBrowser();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.SystemColors.Control;
            this.navPanel.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_background;
            this.navPanel.Controls.Add(this.urlTextBox);
            this.navPanel.Controls.Add(this.settingsButton);
            this.navPanel.Controls.Add(this.forwardButton);
            this.navPanel.Controls.Add(this.backButton);
            this.navPanel.Controls.Add(this.stopButton);
            this.navPanel.Controls.Add(this.refreshButton);
            this.navPanel.Controls.Add(this.homeButton);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(823, 41);
            this.navPanel.TabIndex = 1;
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_settings;
            this.settingsButton.Location = new System.Drawing.Point(782, 9);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(29, 23);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // forwardButton
            // 
            this.forwardButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_forward;
            this.forwardButton.Location = new System.Drawing.Point(152, 9);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(29, 23);
            this.forwardButton.TabIndex = 4;
            this.forwardButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_back;
            this.backButton.Location = new System.Drawing.Point(117, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(29, 23);
            this.backButton.TabIndex = 3;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // stopButton
            // 
            this.stopButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_stop;
            this.stopButton.Location = new System.Drawing.Point(82, 9);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(29, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_reload;
            this.refreshButton.Location = new System.Drawing.Point(47, 9);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(29, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.UseVisualStyleBackColor = false;
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_home;
            this.homeButton.Location = new System.Drawing.Point(12, 9);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(29, 23);
            this.homeButton.TabIndex = 0;
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // browser
            // 
            this.browser.AutoScroll = true;
            this.browser.BackColor = System.Drawing.Color.White;
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 41);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(823, 468);
            this.browser.TabIndex = 0;
            this.browser.Url = new System.Uri("http://www.google.com/", System.UriKind.Absolute);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(187, 11);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(589, 20);
            this.urlTextBox.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(823, 509);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.navPanel);
            this.Name = "MainWindow";
            this.Text = "Expresso";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WebKit.WebKitBrowser browser;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TextBox urlTextBox;



    }
}

