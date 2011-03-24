﻿namespace ExpressoBrowser
{
    partial class MainForm
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
            this.addressBox = new System.Windows.Forms.TextBox();
            this.optionsButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.navPanel = new System.Windows.Forms.Panel();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressBox
            // 
            this.addressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.addressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.addressBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(145, 6);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(479, 22);
            this.addressBox.TabIndex = 4;
            // 
            // optionsButton
            // 
            this.optionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_settings;
            this.optionsButton.Location = new System.Drawing.Point(665, 5);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(29, 23);
            this.optionsButton.TabIndex = 6;
            this.optionsButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_stop;
            this.stopButton.Location = new System.Drawing.Point(630, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(29, 23);
            this.stopButton.TabIndex = 5;
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // forwardButton
            // 
            this.forwardButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_forward;
            this.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.forwardButton.Location = new System.Drawing.Point(110, 5);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(29, 23);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Location = new System.Drawing.Point(82, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(29, 23);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // reloadButton
            // 
            this.reloadButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_reload;
            this.reloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reloadButton.Location = new System.Drawing.Point(47, 5);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(29, 23);
            this.reloadButton.TabIndex = 1;
            this.reloadButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = global::ExpressoBrowser.Properties.Resources.nav_home;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeButton.Location = new System.Drawing.Point(12, 5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(29, 23);
            this.homeButton.TabIndex = 0;
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.navPanel.Controls.Add(this.stopButton);
            this.navPanel.Controls.Add(this.optionsButton);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(706, 35);
            this.navPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(706, 512);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.navPanel);
            this.Name = "MainForm";
            this.Text = "ExpressoBrowser";
            this.TransparencyKey = System.Drawing.Color.DarkKhaki;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Panel navPanel;


    }
}

