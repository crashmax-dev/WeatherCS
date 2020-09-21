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
            this.MenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TempLabel = new System.Windows.Forms.Label();
            this.CloudsLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.WindLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.LocationInput = new System.Windows.Forms.TextBox();
            this.LocMessage = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.LabelLocationS = new System.Windows.Forms.Label();
            this.SettingsMessage = new System.Windows.Forms.Label();
            this.LocationInputS = new System.Windows.Forms.TextBox();
            this.Main = new System.Windows.Forms.Panel();
            this.TitleBar = new System.Windows.Forms.Label();
            this.ErrGlobePic = new System.Windows.Forms.PictureBox();
            this.DescriptionErrorLabel = new System.Windows.Forms.Label();
            this.ReconnectButton = new System.Windows.Forms.Button();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.DescriptionPic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIco)).BeginInit();
            this.MenuTray.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrGlobePic)).BeginInit();
            this.ErrorPanel.SuspendLayout();
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Image = global::WeatherCS.Properties.Resources.about_gray;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
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
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeToolStripMenuItem.Image = global::WeatherCS.Properties.Resources.close_gray;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseApp);
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
            this.LocationInput.TextChanged += new System.EventHandler(this.LabelFontSize);
            this.LocationInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateLocation);
            this.LocationInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RegExpLocationInput);
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
            this.SettingButton.Click += new System.EventHandler(this.OpenSettings);
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
            // SettingPanel
            // 
            this.SettingPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingPanel.Controls.Add(this.LabelLocationS);
            this.SettingPanel.Controls.Add(this.SettingsMessage);
            this.SettingPanel.Controls.Add(this.LocationInputS);
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
            // SettingsMessage
            // 
            this.SettingsMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.SettingsMessage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsMessage.Location = new System.Drawing.Point(12, 247);
            this.SettingsMessage.Name = "SettingsMessage";
            this.SettingsMessage.Size = new System.Drawing.Size(377, 23);
            this.SettingsMessage.TabIndex = 2;
            this.SettingsMessage.Text = "Настройки успешно сохранены!";
            this.SettingsMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationInputS
            // 
            this.LocationInputS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LocationInputS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationInputS.Font = new System.Drawing.Font("Segoe UI Semibold", 16.75F);
            this.LocationInputS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LocationInputS.Location = new System.Drawing.Point(11, 23);
            this.LocationInputS.MaxLength = 64;
            this.LocationInputS.Name = "LocationInputS";
            this.LocationInputS.Size = new System.Drawing.Size(379, 30);
            this.LocationInputS.TabIndex = 0;
            this.LocationInputS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LocationInputS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateLocationS);
            this.LocationInputS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RegExpLocationInput);
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
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.Control;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(400, 21);
            this.TitleBar.TabIndex = 21;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
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
            this.ReconnectButton.Click += new System.EventHandler(this.Reconnect);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.ErrorPanel);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EscEvent);
            this.Resize += new System.EventHandler(this.ToTray);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIco)).EndInit();
            this.MenuTray.ResumeLayout(false);
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrGlobePic)).EndInit();
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.PictureBox WeatherIco;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip MenuTray;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label CloudsLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label WindLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.TextBox LocationInput;
        private System.Windows.Forms.Label LocMessage;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Label TitleBar;
        private System.Windows.Forms.PictureBox ErrGlobePic;
        private System.Windows.Forms.Label DescriptionErrorLabel;
        private System.Windows.Forms.Button ReconnectButton;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label LabelLocationS;
        private System.Windows.Forms.Label SettingsMessage;
        private System.Windows.Forms.TextBox LocationInputS;
        private System.Windows.Forms.Label DescriptionPic;
    }
}