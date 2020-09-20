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
            this.WeatherIco = new System.Windows.Forms.PictureBox();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReconnectButton = new System.Windows.Forms.Button();
            this.ReloadPage = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.CloudsLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.WindLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LocationInput = new System.Windows.Forms.TextBox();
            this.LocMessage = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.GlobePic = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // WeatherIco
            // 
            this.WeatherIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WeatherIco.ErrorImage = null;
            this.WeatherIco.InitialImage = null;
            this.WeatherIco.Location = new System.Drawing.Point(0, 55);
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
            this.MenuTray.BackColor = System.Drawing.Color.Black;
            this.MenuTray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.MenuTray.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuTray.Name = "contextMenuStrip1";
            this.MenuTray.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuTray.Size = new System.Drawing.Size(150, 76);
            // 
            // ReconnectButton
            // 
            this.ReconnectButton.AutoSize = true;
            this.ReconnectButton.FlatAppearance.BorderSize = 0;
            this.ReconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReconnectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReconnectButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReconnectButton.Location = new System.Drawing.Point(150, 254);
            this.ReconnectButton.Name = "ReconnectButton";
            this.ReconnectButton.Size = new System.Drawing.Size(100, 23);
            this.ReconnectButton.TabIndex = 0;
            this.ReconnectButton.TabStop = false;
            this.ReconnectButton.UseVisualStyleBackColor = false;
            this.ReconnectButton.Visible = false;
            this.ReconnectButton.Click += new System.EventHandler(this.Reconnect);
            // 
            // ReloadPage
            // 
            this.ReloadPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReloadPage.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadPage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReloadPage.Location = new System.Drawing.Point(0, 21);
            this.ReloadPage.Name = "ReloadPage";
            this.ReloadPage.Size = new System.Drawing.Size(400, 279);
            this.ReloadPage.TabIndex = 8;
            this.ReloadPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReloadPage.Visible = false;
            // 
            // TempLabel
            // 
            this.TempLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36.25F, System.Drawing.FontStyle.Bold);
            this.TempLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TempLabel.Location = new System.Drawing.Point(200, 85);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(200, 136);
            this.TempLabel.TabIndex = 12;
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloudsLabel
            // 
            this.CloudsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CloudsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloudsLabel.Location = new System.Drawing.Point(0, 237);
            this.CloudsLabel.Name = "CloudsLabel";
            this.CloudsLabel.Size = new System.Drawing.Size(200, 21);
            this.CloudsLabel.TabIndex = 13;
            this.CloudsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.HumidityLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HumidityLabel.Location = new System.Drawing.Point(0, 258);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(200, 21);
            this.HumidityLabel.TabIndex = 15;
            this.HumidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindLabel
            // 
            this.WindLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.WindLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WindLabel.Location = new System.Drawing.Point(200, 237);
            this.WindLabel.Name = "WindLabel";
            this.WindLabel.Size = new System.Drawing.Size(200, 21);
            this.WindLabel.TabIndex = 16;
            this.WindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PressureLabel
            // 
            this.PressureLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PressureLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PressureLabel.Location = new System.Drawing.Point(200, 258);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(200, 21);
            this.PressureLabel.TabIndex = 17;
            this.PressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ErrorLabel.Location = new System.Drawing.Point(0, 204);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(400, 34);
            this.ErrorLabel.TabIndex = 18;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // LocationInput
            // 
            this.LocationInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LocationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationInput.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F);
            this.LocationInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LocationInput.Location = new System.Drawing.Point(11, 24);
            this.LocationInput.MaxLength = 64;
            this.LocationInput.Name = "LocationInput";
            this.LocationInput.Size = new System.Drawing.Size(379, 50);
            this.LocationInput.TabIndex = 19;
            this.LocationInput.TabStop = false;
            this.LocationInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LocationInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateLocation);
            // 
            // LocMessage
            // 
            this.LocMessage.Font = new System.Drawing.Font("Segoe UI Semilight", 8.75F);
            this.LocMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LocMessage.Location = new System.Drawing.Point(0, 72);
            this.LocMessage.Name = "LocMessage";
            this.LocMessage.Size = new System.Drawing.Size(400, 23);
            this.LocMessage.TabIndex = 20;
            this.LocMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.Control;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutButton.Image = global::WeatherCS.Properties.Resources.about_gray;
            this.AboutButton.Location = new System.Drawing.Point(25, 0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(25, 21);
            this.AboutButton.TabIndex = 22;
            this.AboutButton.TabStop = false;
            this.AboutButton.UseVisualStyleBackColor = false;
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.SystemColors.Control;
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SettingButton.Image = global::WeatherCS.Properties.Resources.setting_gray;
            this.SettingButton.Location = new System.Drawing.Point(0, 0);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(25, 21);
            this.SettingButton.TabIndex = 21;
            this.SettingButton.TabStop = false;
            this.SettingButton.UseVisualStyleBackColor = false;
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.SystemColors.Control;
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinButton.Image = ((System.Drawing.Image)(resources.GetObject("MinButton.Image")));
            this.MinButton.Location = new System.Drawing.Point(350, 0);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(25, 21);
            this.MinButton.TabIndex = 0;
            this.MinButton.TabStop = false;
            this.MinButton.UseVisualStyleBackColor = false;
            this.MinButton.Click += new System.EventHandler(this.MinApp);
            // 
            // GlobePic
            // 
            this.GlobePic.ErrorImage = null;
            this.GlobePic.Image = global::WeatherCS.Properties.Resources.www;
            this.GlobePic.InitialImage = null;
            this.GlobePic.Location = new System.Drawing.Point(100, 21);
            this.GlobePic.Name = "GlobePic";
            this.GlobePic.Size = new System.Drawing.Size(200, 200);
            this.GlobePic.TabIndex = 9;
            this.GlobePic.TabStop = false;
            this.GlobePic.Visible = false;
            this.GlobePic.WaitOnLoad = true;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Image = global::WeatherCS.Properties.Resources.close_gray;
            this.CloseButton.Location = new System.Drawing.Point(375, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 21);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseApp);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButtonLeave);
            this.CloseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseButtonHover);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeToolStripMenuItem.Image = global::WeatherCS.Properties.Resources.close_gray;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseApp);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingToolStripMenuItem.Image = global::WeatherCS.Properties.Resources.setting_gray;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.settingToolStripMenuItem.Text = "Настройки";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Image = global::WeatherCS.Properties.Resources.about_gray;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.ReconnectButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.GlobePic);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CustomPanel);
            this.Controls.Add(this.ReloadPage);
            this.Controls.Add(this.LocationInput);
            this.Controls.Add(this.LocMessage);
            this.Controls.Add(this.WindLabel);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.CloudsLabel);
            this.Controls.Add(this.WeatherIco);
            this.Controls.Add(this.TempLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EscEvent);
            this.Resize += new System.EventHandler(this.ToTray);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIco)).EndInit();
            this.MenuTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GlobePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Label CustomPanel;
        private System.Windows.Forms.PictureBox WeatherIco;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip MenuTray;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.PictureBox GlobePic;
        private System.Windows.Forms.Button ReconnectButton;
        private System.Windows.Forms.Label ReloadPage;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label CloudsLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label WindLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox LocationInput;
        private System.Windows.Forms.Label LocMessage;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}