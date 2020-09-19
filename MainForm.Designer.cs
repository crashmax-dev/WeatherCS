namespace WeatherCS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.Rain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CustomPanel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.WeatherIco = new System.Windows.Forms.PictureBox();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReconnectButton = new System.Windows.Forms.Button();
            this.ReloadPage = new System.Windows.Forms.Label();
            this.GlobePic = new System.Windows.Forms.PictureBox();
            this.MinButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TempLabel = new System.Windows.Forms.Label();
            this.CloudsLabel = new System.Windows.Forms.Label();
            this.TempDescLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.WindLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIco)).BeginInit();
            this.MenuTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GlobePic)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomPanel
            // 
            this.CustomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomPanel.Name = "CustomPanel";
            this.CustomPanel.Size = new System.Drawing.Size(400, 21);
            this.CustomPanel.TabIndex = 4;
            this.CustomPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // LocationLabel
            // 
            this.LocationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F);
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LocationLabel.Location = new System.Drawing.Point(0, 26);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(400, 52);
            this.LocationLabel.TabIndex = 5;
            this.LocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeatherIco
            // 
            this.WeatherIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WeatherIco.ErrorImage = null;
            this.WeatherIco.InitialImage = null;
            this.WeatherIco.Location = new System.Drawing.Point(12, 55);
            this.WeatherIco.Name = "WeatherIco";
            this.WeatherIco.Size = new System.Drawing.Size(200, 200);
            this.WeatherIco.TabIndex = 6;
            this.WeatherIco.TabStop = false;
            this.WeatherIco.WaitOnLoad = true;
            // 
            // Tray
            // 
            this.Tray.ContextMenuStrip = this.MenuTray;
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowApp);
            // 
            // MenuTray
            // 
            this.MenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.MenuTray.Name = "contextMenuStrip1";
            this.MenuTray.Size = new System.Drawing.Size(94, 26);
            // 
            // ReconnectButton
            // 
            this.ReconnectButton.FlatAppearance.BorderSize = 0;
            this.ReconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReconnectButton.Font = new System.Drawing.Font("Segoe UI Semilight", 7.75F);
            this.ReconnectButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReconnectButton.Location = new System.Drawing.Point(136, 258);
            this.ReconnectButton.Name = "ReconnectButton";
            this.ReconnectButton.Size = new System.Drawing.Size(128, 21);
            this.ReconnectButton.TabIndex = 10;
            this.ReconnectButton.Text = "Переподключиться";
            this.ReconnectButton.UseVisualStyleBackColor = false;
            this.ReconnectButton.Visible = false;
            this.ReconnectButton.Click += new System.EventHandler(this.Reconnect);
            // 
            // ReloadPage
            // 
            this.ReloadPage.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadPage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReloadPage.Location = new System.Drawing.Point(0, 26);
            this.ReloadPage.Name = "ReloadPage";
            this.ReloadPage.Size = new System.Drawing.Size(400, 272);
            this.ReloadPage.TabIndex = 8;
            this.ReloadPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReloadPage.Visible = false;
            // 
            // GlobePic
            // 
            this.GlobePic.ErrorImage = null;
            this.GlobePic.Image = global::WeatherCS.Properties.Resources.www;
            this.GlobePic.InitialImage = null;
            this.GlobePic.Location = new System.Drawing.Point(100, 44);
            this.GlobePic.Name = "GlobePic";
            this.GlobePic.Size = new System.Drawing.Size(200, 200);
            this.GlobePic.TabIndex = 9;
            this.GlobePic.TabStop = false;
            this.GlobePic.Visible = false;
            this.GlobePic.WaitOnLoad = true;
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.SystemColors.Control;
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Image = ((System.Drawing.Image)(resources.GetObject("MinButton.Image")));
            this.MinButton.Location = new System.Drawing.Point(350, 0);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(25, 21);
            this.MinButton.TabIndex = 1;
            this.MinButton.UseVisualStyleBackColor = false;
            this.MinButton.Click += new System.EventHandler(this.MinApp);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::WeatherCS.Properties.Resources.close_gray;
            this.CloseButton.Location = new System.Drawing.Point(375, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 21);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseApp);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButtonLeave);
            this.CloseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseButtonHover);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeToolStripMenuItem.Image = global::WeatherCS.Properties.Resources.close_gray;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseApp);
            // 
            // TempLabel
            // 
            this.TempLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36.25F, System.Drawing.FontStyle.Bold);
            this.TempLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TempLabel.Location = new System.Drawing.Point(227, 87);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(141, 136);
            this.TempLabel.TabIndex = 12;
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloudsLabel
            // 
            this.CloudsLabel.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.CloudsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloudsLabel.Location = new System.Drawing.Point(12, 237);
            this.CloudsLabel.Name = "CloudsLabel";
            this.CloudsLabel.Size = new System.Drawing.Size(181, 21);
            this.CloudsLabel.TabIndex = 13;
            this.CloudsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempDescLabel
            // 
            this.TempDescLabel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.TempDescLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TempDescLabel.Location = new System.Drawing.Point(227, 183);
            this.TempDescLabel.Name = "TempDescLabel";
            this.TempDescLabel.Size = new System.Drawing.Size(141, 25);
            this.TempDescLabel.TabIndex = 14;
            this.TempDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.HumidityLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HumidityLabel.Location = new System.Drawing.Point(12, 258);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(181, 21);
            this.HumidityLabel.TabIndex = 15;
            this.HumidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindLabel
            // 
            this.WindLabel.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.WindLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WindLabel.Location = new System.Drawing.Point(207, 237);
            this.WindLabel.Name = "WindLabel";
            this.WindLabel.Size = new System.Drawing.Size(181, 21);
            this.WindLabel.TabIndex = 16;
            this.WindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PressureLabel
            // 
            this.PressureLabel.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.PressureLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PressureLabel.Location = new System.Drawing.Point(207, 258);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(181, 21);
            this.PressureLabel.TabIndex = 17;
            this.PressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.GlobePic);
            this.Controls.Add(this.ReconnectButton);
            this.Controls.Add(this.ReloadPage);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.WeatherIco);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CustomPanel);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.TempDescLabel);
            this.Controls.Add(this.WindLabel);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.CloudsLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.ToTray);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIco)).EndInit();
            this.MenuTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GlobePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Label CustomPanel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.PictureBox WeatherIco;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip MenuTray;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.PictureBox GlobePic;
        private System.Windows.Forms.Button ReconnectButton;
        private System.Windows.Forms.Label ReloadPage;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label CloudsLabel;
        private System.Windows.Forms.Label TempDescLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label WindLabel;
        private System.Windows.Forms.Label PressureLabel;
    }
}