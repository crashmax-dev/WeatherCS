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
            this.WeatherIco = new System.Windows.Forms.PictureBox();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TempLabel = new System.Windows.Forms.Label();
            this.CloudsLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.WindLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.LocationInput = new System.Windows.Forms.TextBox();
            this.LocMessage = new System.Windows.Forms.Label();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.LabelLocationS = new System.Windows.Forms.Label();
            this.SettingsLocation = new System.Windows.Forms.TextBox();
            this.Main = new System.Windows.Forms.Panel();
            this.DescriptionPic = new System.Windows.Forms.Label();
            this.TitleBar = new System.Windows.Forms.Label();
            this.DescriptionErrorLabel = new System.Windows.Forms.Label();
            this.ReconnectButton = new System.Windows.Forms.Button();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.TraySeparator = new System.Windows.Forms.ToolStripSeparator();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ErrGlobePic = new System.Windows.Forms.PictureBox();
            this.TrayAboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TraySettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayCloseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIco)).BeginInit();
            this.TrayMenu.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            this.Main.SuspendLayout();
            this.ErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrGlobePic)).BeginInit();
            this.SuspendLayout();
            // 
            // WeatherIco
            // 
            this.WeatherIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WeatherIco.ErrorImage = null;
            this.WeatherIco.InitialImage = null;
            this.WeatherIco.Location = new System.Drawing.Point(0, 34);
            this.WeatherIco.Name = "WeatherIco";
            this.WeatherIco.Size = new System.Drawing.Size(200, 200);
            this.WeatherIco.TabIndex = 6;
            this.WeatherIco.TabStop = false;
            this.WeatherIco.WaitOnLoad = true;
            // 
            // Tray
            // 
            this.Tray.ContextMenuStrip = this.TrayMenu;
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            // 
            // TrayMenu
            // 
            this.TrayMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.TrayMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayAboutButton,
            this.TraySettingsButton,
            this.TraySeparator,
            this.TrayCloseButton});
            this.TrayMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TrayMenu.Name = "contextMenuStrip1";
            this.TrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TrayMenu.Size = new System.Drawing.Size(150, 76);
            // 
            // TempLabel
            // 
            this.TempLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36.25F, System.Drawing.FontStyle.Bold);
            this.TempLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TempLabel.Location = new System.Drawing.Point(200, 64);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(200, 136);
            this.TempLabel.TabIndex = 12;
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloudsLabel
            // 
            this.CloudsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CloudsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloudsLabel.Location = new System.Drawing.Point(0, 223);
            this.CloudsLabel.Name = "CloudsLabel";
            this.CloudsLabel.Size = new System.Drawing.Size(200, 21);
            this.CloudsLabel.TabIndex = 13;
            this.CloudsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.HumidityLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HumidityLabel.Location = new System.Drawing.Point(0, 244);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(200, 21);
            this.HumidityLabel.TabIndex = 15;
            this.HumidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindLabel
            // 
            this.WindLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.WindLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WindLabel.Location = new System.Drawing.Point(200, 223);
            this.WindLabel.Name = "WindLabel";
            this.WindLabel.Size = new System.Drawing.Size(200, 21);
            this.WindLabel.TabIndex = 16;
            this.WindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PressureLabel
            // 
            this.PressureLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PressureLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PressureLabel.Location = new System.Drawing.Point(200, 244);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(200, 21);
            this.PressureLabel.TabIndex = 17;
            this.PressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationInput
            // 
            this.LocationInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LocationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationInput.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F);
            this.LocationInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LocationInput.Location = new System.Drawing.Point(11, 3);
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
            this.LocMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.LocMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LocMessage.Location = new System.Drawing.Point(0, 51);
            this.LocMessage.Name = "LocMessage";
            this.LocMessage.Size = new System.Drawing.Size(400, 23);
            this.LocMessage.TabIndex = 20;
            this.LocMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingPanel
            // 
            this.SettingPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingPanel.Controls.Add(this.LabelLocationS);
            this.SettingPanel.Controls.Add(this.SettingsLocation);
            this.SettingPanel.Location = new System.Drawing.Point(0, 21);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(400, 279);
            this.SettingPanel.TabIndex = 24;
            this.SettingPanel.Visible = false;
            // 
            // LabelLocationS
            // 
            this.LabelLocationS.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelLocationS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelLocationS.Location = new System.Drawing.Point(11, 6);
            this.LabelLocationS.Name = "LabelLocationS";
            this.LabelLocationS.Size = new System.Drawing.Size(379, 19);
            this.LabelLocationS.TabIndex = 1;
            this.LabelLocationS.Text = "Город, страна или регион:";
            this.LabelLocationS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsLocation
            // 
            this.SettingsLocation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 16.75F);
            this.SettingsLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingsLocation.Location = new System.Drawing.Point(11, 23);
            this.SettingsLocation.MaxLength = 64;
            this.SettingsLocation.Name = "SettingsLocation";
            this.SettingsLocation.Size = new System.Drawing.Size(379, 30);
            this.SettingsLocation.TabIndex = 0;
            this.SettingsLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.DescriptionPic);
            this.Main.Controls.Add(this.LocationInput);
            this.Main.Controls.Add(this.LocMessage);
            this.Main.Controls.Add(this.WindLabel);
            this.Main.Controls.Add(this.PressureLabel);
            this.Main.Controls.Add(this.HumidityLabel);
            this.Main.Controls.Add(this.CloudsLabel);
            this.Main.Controls.Add(this.TempLabel);
            this.Main.Controls.Add(this.WeatherIco);
            this.Main.Location = new System.Drawing.Point(0, 21);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(400, 279);
            this.Main.TabIndex = 25;
            // 
            // DescriptionPic
            // 
            this.DescriptionPic.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.DescriptionPic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriptionPic.Location = new System.Drawing.Point(0, 190);
            this.DescriptionPic.Name = "DescriptionPic";
            this.DescriptionPic.Size = new System.Drawing.Size(200, 21);
            this.DescriptionPic.TabIndex = 21;
            this.DescriptionPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.Control;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(400, 21);
            this.TitleBar.TabIndex = 21;
            // 
            // DescriptionErrorLabel
            // 
            this.DescriptionErrorLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DescriptionErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionErrorLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriptionErrorLabel.Location = new System.Drawing.Point(0, 183);
            this.DescriptionErrorLabel.Name = "DescriptionErrorLabel";
            this.DescriptionErrorLabel.Size = new System.Drawing.Size(400, 34);
            this.DescriptionErrorLabel.TabIndex = 18;
            this.DescriptionErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReconnectButton
            // 
            this.ReconnectButton.AutoSize = true;
            this.ReconnectButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReconnectButton.FlatAppearance.BorderSize = 0;
            this.ReconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReconnectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReconnectButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReconnectButton.Location = new System.Drawing.Point(150, 237);
            this.ReconnectButton.Name = "ReconnectButton";
            this.ReconnectButton.Size = new System.Drawing.Size(100, 23);
            this.ReconnectButton.TabIndex = 0;
            this.ReconnectButton.TabStop = false;
            this.ReconnectButton.UseVisualStyleBackColor = false;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ErrorPanel.Controls.Add(this.ReconnectButton);
            this.ErrorPanel.Controls.Add(this.DescriptionErrorLabel);
            this.ErrorPanel.Controls.Add(this.ErrGlobePic);
            this.ErrorPanel.Location = new System.Drawing.Point(0, 21);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(400, 279);
            this.ErrorPanel.TabIndex = 0;
            this.ErrorPanel.Visible = false;
            // 
            // TraySeparator
            // 
            this.TraySeparator.Name = "TraySeparator";
            this.TraySeparator.Size = new System.Drawing.Size(146, 6);
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
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.SystemColors.Control;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(350, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 21);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.UseVisualStyleBackColor = false;
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
            // ErrGlobePic
            // 
            this.ErrGlobePic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ErrGlobePic.ErrorImage = null;
            this.ErrGlobePic.Image = global::WeatherCS.Properties.Resources.www;
            this.ErrGlobePic.InitialImage = null;
            this.ErrGlobePic.Location = new System.Drawing.Point(100, 0);
            this.ErrGlobePic.Name = "ErrGlobePic";
            this.ErrGlobePic.Size = new System.Drawing.Size(200, 200);
            this.ErrGlobePic.TabIndex = 9;
            this.ErrGlobePic.TabStop = false;
            this.ErrGlobePic.WaitOnLoad = true;
            // 
            // TrayAboutButton
            // 
            this.TrayAboutButton.ForeColor = System.Drawing.Color.White;
            this.TrayAboutButton.Image = global::WeatherCS.Properties.Resources.about_white;
            this.TrayAboutButton.Name = "TrayAboutButton";
            this.TrayAboutButton.Size = new System.Drawing.Size(149, 22);
            this.TrayAboutButton.Text = "О программе";
            // 
            // TraySettingsButton
            // 
            this.TraySettingsButton.ForeColor = System.Drawing.Color.White;
            this.TraySettingsButton.Image = global::WeatherCS.Properties.Resources.setting_white;
            this.TraySettingsButton.Name = "TraySettingsButton";
            this.TraySettingsButton.Size = new System.Drawing.Size(149, 22);
            this.TraySettingsButton.Text = "Настройки";
            // 
            // TrayCloseButton
            // 
            this.TrayCloseButton.ForeColor = System.Drawing.Color.White;
            this.TrayCloseButton.Image = global::WeatherCS.Properties.Resources.close_white;
            this.TrayCloseButton.Name = "TrayCloseButton";
            this.TrayCloseButton.Size = new System.Drawing.Size(149, 22);
            this.TrayCloseButton.Text = "Закрыть";
            // 
            // AboutPanel
            // 
            this.AboutPanel.Location = new System.Drawing.Point(0, 21);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(400, 279);
            this.AboutPanel.TabIndex = 26;
            this.AboutPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.AboutPanel);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.Main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIco)).EndInit();
            this.TrayMenu.ResumeLayout(false);
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrGlobePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.PictureBox WeatherIco;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayCloseButton;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label CloudsLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label WindLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.TextBox LocationInput;
        private System.Windows.Forms.Label LocMessage;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.ToolStripMenuItem TraySettingsButton;
        private System.Windows.Forms.ToolStripMenuItem TrayAboutButton;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Label TitleBar;
        private System.Windows.Forms.PictureBox ErrGlobePic;
        private System.Windows.Forms.Label DescriptionErrorLabel;
        private System.Windows.Forms.Button ReconnectButton;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label LabelLocationS;
        private System.Windows.Forms.TextBox SettingsLocation;
        private System.Windows.Forms.Label DescriptionPic;
        private System.Windows.Forms.ToolStripSeparator TraySeparator;
        private System.Windows.Forms.Panel AboutPanel;
    }
}