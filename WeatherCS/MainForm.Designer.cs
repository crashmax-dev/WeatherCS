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
            this.TrayWeatherInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TrayAboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TraySettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TraySeparator = new System.Windows.Forms.ToolStripSeparator();
            this.TrayCloseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TempLabel = new System.Windows.Forms.Label();
            this.CloudsLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.WindLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.LocationInput = new System.Windows.Forms.TextBox();
            this.LocMessage = new System.Windows.Forms.Label();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.SettingsInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SettingsAutoRun = new System.Windows.Forms.CheckBox();
            this.SettingsRunPath = new System.Windows.Forms.TextBox();
            this.SettingsLocation = new System.Windows.Forms.TextBox();
            this.GetAPIButton = new System.Windows.Forms.Button();
            this.SettingsSaveButton = new System.Windows.Forms.Button();
            this.SettingsRestoreButton = new System.Windows.Forms.Button();
            this.SettingsApiKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Main = new System.Windows.Forms.Panel();
            this.DescriptionPic = new System.Windows.Forms.Label();
            this.TitleBar = new System.Windows.Forms.Label();
            this.DescriptionErrorLabel = new System.Windows.Forms.Label();
            this.ReconnectButton = new System.Windows.Forms.Button();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.ErrGlobePic = new System.Windows.Forms.PictureBox();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.AboutCheckUpdates = new System.Windows.Forms.Button();
            this.AboutAppVer = new System.Windows.Forms.Label();
            this.openGitHub = new System.Windows.Forms.Button();
            this.AboutAppDesc = new System.Windows.Forms.Label();
            this.AboutAppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIco)).BeginInit();
            this.TrayMenu.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            this.Main.SuspendLayout();
            this.ErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrGlobePic)).BeginInit();
            this.AboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WeatherIco
            // 
            this.WeatherIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WeatherIco.ErrorImage = null;
            this.WeatherIco.InitialImage = null;
            this.WeatherIco.Location = new System.Drawing.Point(0, 42);
            this.WeatherIco.Margin = new System.Windows.Forms.Padding(4);
            this.WeatherIco.Name = "WeatherIco";
            this.WeatherIco.Size = new System.Drawing.Size(267, 246);
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
            this.TrayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayWeatherInfo,
            this.toolStripSeparator1,
            this.TrayAboutButton,
            this.TraySettingsButton,
            this.TraySeparator,
            this.TrayCloseButton});
            this.TrayMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TrayMenu.Name = "contextMenuStrip1";
            this.TrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TrayMenu.Size = new System.Drawing.Size(215, 148);
            // 
            // TrayWeatherInfo
            // 
            this.TrayWeatherInfo.ForeColor = System.Drawing.Color.White;
            this.TrayWeatherInfo.Name = "TrayWeatherInfo";
            this.TrayWeatherInfo.Size = new System.Drawing.Size(214, 26);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // TrayAboutButton
            // 
            this.TrayAboutButton.ForeColor = System.Drawing.Color.White;
            this.TrayAboutButton.Image = global::WeatherCS.Properties.Resources.about_white;
            this.TrayAboutButton.Name = "TrayAboutButton";
            this.TrayAboutButton.Size = new System.Drawing.Size(214, 26);
            this.TrayAboutButton.Text = "О программе";
            // 
            // TraySettingsButton
            // 
            this.TraySettingsButton.ForeColor = System.Drawing.Color.White;
            this.TraySettingsButton.Image = global::WeatherCS.Properties.Resources.setting_white;
            this.TraySettingsButton.Name = "TraySettingsButton";
            this.TraySettingsButton.Size = new System.Drawing.Size(214, 26);
            this.TraySettingsButton.Text = "Настройки";
            // 
            // TraySeparator
            // 
            this.TraySeparator.Name = "TraySeparator";
            this.TraySeparator.Size = new System.Drawing.Size(211, 6);
            // 
            // TrayCloseButton
            // 
            this.TrayCloseButton.ForeColor = System.Drawing.Color.White;
            this.TrayCloseButton.Image = global::WeatherCS.Properties.Resources.close_white;
            this.TrayCloseButton.Name = "TrayCloseButton";
            this.TrayCloseButton.Size = new System.Drawing.Size(214, 26);
            this.TrayCloseButton.Text = "Закрыть";
            // 
            // TempLabel
            // 
            this.TempLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36.25F, System.Drawing.FontStyle.Bold);
            this.TempLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TempLabel.Location = new System.Drawing.Point(267, 79);
            this.TempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(267, 167);
            this.TempLabel.TabIndex = 12;
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloudsLabel
            // 
            this.CloudsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CloudsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloudsLabel.Location = new System.Drawing.Point(0, 274);
            this.CloudsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloudsLabel.Name = "CloudsLabel";
            this.CloudsLabel.Size = new System.Drawing.Size(267, 26);
            this.CloudsLabel.TabIndex = 13;
            this.CloudsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.HumidityLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HumidityLabel.Location = new System.Drawing.Point(0, 300);
            this.HumidityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(267, 26);
            this.HumidityLabel.TabIndex = 15;
            this.HumidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindLabel
            // 
            this.WindLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.WindLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WindLabel.Location = new System.Drawing.Point(267, 274);
            this.WindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindLabel.Name = "WindLabel";
            this.WindLabel.Size = new System.Drawing.Size(267, 26);
            this.WindLabel.TabIndex = 16;
            this.WindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PressureLabel
            // 
            this.PressureLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PressureLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PressureLabel.Location = new System.Drawing.Point(267, 300);
            this.PressureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(267, 26);
            this.PressureLabel.TabIndex = 17;
            this.PressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationInput
            // 
            this.LocationInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LocationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationInput.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F);
            this.LocationInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LocationInput.Location = new System.Drawing.Point(15, 4);
            this.LocationInput.Margin = new System.Windows.Forms.Padding(4);
            this.LocationInput.MaxLength = 30;
            this.LocationInput.Name = "LocationInput";
            this.LocationInput.Size = new System.Drawing.Size(505, 62);
            this.LocationInput.TabIndex = 19;
            this.LocationInput.TabStop = false;
            this.LocationInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocMessage
            // 
            this.LocMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.LocMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LocMessage.Location = new System.Drawing.Point(0, 63);
            this.LocMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocMessage.Name = "LocMessage";
            this.LocMessage.Size = new System.Drawing.Size(533, 28);
            this.LocMessage.TabIndex = 20;
            this.LocMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingPanel
            // 
            this.SettingPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingPanel.Controls.Add(this.SettingsInterval);
            this.SettingPanel.Controls.Add(this.label4);
            this.SettingPanel.Controls.Add(this.label3);
            this.SettingPanel.Controls.Add(this.SettingsAutoRun);
            this.SettingPanel.Controls.Add(this.SettingsRunPath);
            this.SettingPanel.Controls.Add(this.SettingsLocation);
            this.SettingPanel.Controls.Add(this.GetAPIButton);
            this.SettingPanel.Controls.Add(this.SettingsSaveButton);
            this.SettingPanel.Controls.Add(this.SettingsRestoreButton);
            this.SettingPanel.Controls.Add(this.SettingsApiKey);
            this.SettingPanel.Controls.Add(this.label2);
            this.SettingPanel.Controls.Add(this.label1);
            this.SettingPanel.Location = new System.Drawing.Point(0, 26);
            this.SettingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(533, 343);
            this.SettingPanel.TabIndex = 24;
            this.SettingPanel.Visible = false;
            // 
            // SettingsInterval
            // 
            this.SettingsInterval.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsInterval.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F);
            this.SettingsInterval.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingsInterval.Location = new System.Drawing.Point(343, 182);
            this.SettingsInterval.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsInterval.MaxLength = 3;
            this.SettingsInterval.Name = "SettingsInterval";
            this.SettingsInterval.Size = new System.Drawing.Size(171, 29);
            this.SettingsInterval.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(15, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(501, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Интервал обновления погоды (в минутах):";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Автозагрузка:";
            // 
            // SettingsAutoRun
            // 
            this.SettingsAutoRun.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsAutoRun.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsAutoRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsAutoRun.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.SettingsAutoRun.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingsAutoRun.Location = new System.Drawing.Point(485, 150);
            this.SettingsAutoRun.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsAutoRun.Name = "SettingsAutoRun";
            this.SettingsAutoRun.Size = new System.Drawing.Size(31, 28);
            this.SettingsAutoRun.TabIndex = 8;
            this.SettingsAutoRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsAutoRun.UseVisualStyleBackColor = false;
            // 
            // SettingsRunPath
            // 
            this.SettingsRunPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsRunPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsRunPath.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F);
            this.SettingsRunPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingsRunPath.Location = new System.Drawing.Point(20, 155);
            this.SettingsRunPath.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsRunPath.Name = "SettingsRunPath";
            this.SettingsRunPath.ReadOnly = true;
            this.SettingsRunPath.Size = new System.Drawing.Size(459, 20);
            this.SettingsRunPath.TabIndex = 9;
            // 
            // SettingsLocation
            // 
            this.SettingsLocation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F);
            this.SettingsLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingsLocation.Location = new System.Drawing.Point(20, 34);
            this.SettingsLocation.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsLocation.MaxLength = 30;
            this.SettingsLocation.Name = "SettingsLocation";
            this.SettingsLocation.Size = new System.Drawing.Size(493, 29);
            this.SettingsLocation.TabIndex = 0;
            // 
            // GetAPIButton
            // 
            this.GetAPIButton.AutoSize = true;
            this.GetAPIButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GetAPIButton.FlatAppearance.BorderSize = 0;
            this.GetAPIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetAPIButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetAPIButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GetAPIButton.Location = new System.Drawing.Point(423, 92);
            this.GetAPIButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetAPIButton.Name = "GetAPIButton";
            this.GetAPIButton.Size = new System.Drawing.Size(108, 36);
            this.GetAPIButton.TabIndex = 7;
            this.GetAPIButton.TabStop = false;
            this.GetAPIButton.Text = "Получить";
            this.GetAPIButton.UseVisualStyleBackColor = false;
            // 
            // SettingsSaveButton
            // 
            this.SettingsSaveButton.AutoSize = true;
            this.SettingsSaveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsSaveButton.FlatAppearance.BorderSize = 0;
            this.SettingsSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsSaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsSaveButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingsSaveButton.Location = new System.Drawing.Point(125, 292);
            this.SettingsSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsSaveButton.Name = "SettingsSaveButton";
            this.SettingsSaveButton.Size = new System.Drawing.Size(133, 36);
            this.SettingsSaveButton.TabIndex = 6;
            this.SettingsSaveButton.TabStop = false;
            this.SettingsSaveButton.Text = "Сохранить";
            this.SettingsSaveButton.UseVisualStyleBackColor = false;
            // 
            // SettingsRestoreButton
            // 
            this.SettingsRestoreButton.AutoSize = true;
            this.SettingsRestoreButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsRestoreButton.FlatAppearance.BorderSize = 0;
            this.SettingsRestoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsRestoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsRestoreButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingsRestoreButton.Location = new System.Drawing.Point(275, 292);
            this.SettingsRestoreButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsRestoreButton.Name = "SettingsRestoreButton";
            this.SettingsRestoreButton.Size = new System.Drawing.Size(133, 36);
            this.SettingsRestoreButton.TabIndex = 0;
            this.SettingsRestoreButton.TabStop = false;
            this.SettingsRestoreButton.Text = "Сбросить";
            this.SettingsRestoreButton.UseVisualStyleBackColor = false;
            // 
            // SettingsApiKey
            // 
            this.SettingsApiKey.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsApiKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsApiKey.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F);
            this.SettingsApiKey.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingsApiKey.Location = new System.Drawing.Point(20, 92);
            this.SettingsApiKey.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsApiKey.MaxLength = 32;
            this.SettingsApiKey.Name = "SettingsApiKey";
            this.SettingsApiKey.PasswordChar = '●';
            this.SettingsApiKey.Size = new System.Drawing.Size(388, 29);
            this.SettingsApiKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "API Ключ:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Город, страна или регион:";
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
            this.Main.Location = new System.Drawing.Point(0, 26);
            this.Main.Margin = new System.Windows.Forms.Padding(4);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(533, 343);
            this.Main.TabIndex = 25;
            // 
            // DescriptionPic
            // 
            this.DescriptionPic.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.DescriptionPic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriptionPic.Location = new System.Drawing.Point(0, 234);
            this.DescriptionPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionPic.Name = "DescriptionPic";
            this.DescriptionPic.Size = new System.Drawing.Size(267, 26);
            this.DescriptionPic.TabIndex = 21;
            this.DescriptionPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.Control;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(533, 26);
            this.TitleBar.TabIndex = 21;
            // 
            // DescriptionErrorLabel
            // 
            this.DescriptionErrorLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DescriptionErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionErrorLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriptionErrorLabel.Location = new System.Drawing.Point(0, 225);
            this.DescriptionErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionErrorLabel.Name = "DescriptionErrorLabel";
            this.DescriptionErrorLabel.Size = new System.Drawing.Size(533, 42);
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
            this.ReconnectButton.Location = new System.Drawing.Point(200, 292);
            this.ReconnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReconnectButton.Name = "ReconnectButton";
            this.ReconnectButton.Size = new System.Drawing.Size(133, 28);
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
            this.ErrorPanel.Location = new System.Drawing.Point(0, 26);
            this.ErrorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(533, 343);
            this.ErrorPanel.TabIndex = 0;
            this.ErrorPanel.Visible = false;
            // 
            // ErrGlobePic
            // 
            this.ErrGlobePic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ErrGlobePic.ErrorImage = null;
            this.ErrGlobePic.Image = global::WeatherCS.Properties.Resources.www;
            this.ErrGlobePic.InitialImage = null;
            this.ErrGlobePic.Location = new System.Drawing.Point(133, 0);
            this.ErrGlobePic.Margin = new System.Windows.Forms.Padding(4);
            this.ErrGlobePic.Name = "ErrGlobePic";
            this.ErrGlobePic.Size = new System.Drawing.Size(267, 246);
            this.ErrGlobePic.TabIndex = 9;
            this.ErrGlobePic.TabStop = false;
            this.ErrGlobePic.WaitOnLoad = true;
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.AboutCheckUpdates);
            this.AboutPanel.Controls.Add(this.AboutAppVer);
            this.AboutPanel.Controls.Add(this.openGitHub);
            this.AboutPanel.Controls.Add(this.AboutAppDesc);
            this.AboutPanel.Controls.Add(this.AboutAppName);
            this.AboutPanel.Controls.Add(this.pictureBox1);
            this.AboutPanel.Location = new System.Drawing.Point(0, 26);
            this.AboutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(533, 343);
            this.AboutPanel.TabIndex = 26;
            this.AboutPanel.Visible = false;
            // 
            // AboutCheckUpdates
            // 
            this.AboutCheckUpdates.AutoSize = true;
            this.AboutCheckUpdates.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AboutCheckUpdates.FlatAppearance.BorderSize = 0;
            this.AboutCheckUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutCheckUpdates.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutCheckUpdates.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AboutCheckUpdates.Location = new System.Drawing.Point(96, 292);
            this.AboutCheckUpdates.Margin = new System.Windows.Forms.Padding(4);
            this.AboutCheckUpdates.Name = "AboutCheckUpdates";
            this.AboutCheckUpdates.Size = new System.Drawing.Size(133, 36);
            this.AboutCheckUpdates.TabIndex = 23;
            this.AboutCheckUpdates.TabStop = false;
            this.AboutCheckUpdates.UseVisualStyleBackColor = false;
            // 
            // AboutAppVer
            // 
            this.AboutAppVer.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.AboutAppVer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AboutAppVer.Location = new System.Drawing.Point(160, 199);
            this.AboutAppVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutAppVer.Name = "AboutAppVer";
            this.AboutAppVer.Size = new System.Drawing.Size(213, 31);
            this.AboutAppVer.TabIndex = 22;
            this.AboutAppVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openGitHub
            // 
            this.openGitHub.AutoSize = true;
            this.openGitHub.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openGitHub.FlatAppearance.BorderSize = 0;
            this.openGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openGitHub.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openGitHub.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.openGitHub.Location = new System.Drawing.Point(297, 292);
            this.openGitHub.Margin = new System.Windows.Forms.Padding(4);
            this.openGitHub.Name = "openGitHub";
            this.openGitHub.Size = new System.Drawing.Size(133, 36);
            this.openGitHub.TabIndex = 21;
            this.openGitHub.TabStop = false;
            this.openGitHub.Text = "Посетить GitHub";
            this.openGitHub.UseVisualStyleBackColor = false;
            // 
            // AboutAppDesc
            // 
            this.AboutAppDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 11.75F);
            this.AboutAppDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AboutAppDesc.Location = new System.Drawing.Point(27, 229);
            this.AboutAppDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutAppDesc.Name = "AboutAppDesc";
            this.AboutAppDesc.Size = new System.Drawing.Size(481, 53);
            this.AboutAppDesc.TabIndex = 20;
            this.AboutAppDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutAppName
            // 
            this.AboutAppName.Font = new System.Drawing.Font("Segoe UI Semilight", 22.75F);
            this.AboutAppName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AboutAppName.Location = new System.Drawing.Point(28, 150);
            this.AboutAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutAppName.Name = "AboutAppName";
            this.AboutAppName.Size = new System.Drawing.Size(472, 54);
            this.AboutAppName.TabIndex = 18;
            this.AboutAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WeatherCS.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(160, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Image = global::WeatherCS.Properties.Resources.close_gray;
            this.CloseButton.Location = new System.Drawing.Point(500, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 26);
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
            this.MinimizeButton.Image = global::WeatherCS.Properties.Resources.minimize_gray;
            this.MinimizeButton.Location = new System.Drawing.Point(467, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(33, 26);
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
            this.SettingButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(33, 26);
            this.SettingButton.TabIndex = 21;
            this.SettingButton.TabStop = false;
            this.SettingButton.UseVisualStyleBackColor = false;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.Control;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.25F, System.Drawing.FontStyle.Bold);
            this.AboutButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AboutButton.Image = global::WeatherCS.Properties.Resources.about_gray;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(33, 0);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(4);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(33, 26);
            this.AboutButton.TabIndex = 22;
            this.AboutButton.TabStop = false;
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AboutButton.UseVisualStyleBackColor = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 60000;
            this.Timer.Tick += new System.EventHandler(this.Schedule);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(533, 369);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 369);
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
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SettingsLocation;
        private System.Windows.Forms.Label DescriptionPic;
        private System.Windows.Forms.ToolStripSeparator TraySeparator;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SettingsApiKey;
        private System.Windows.Forms.ToolStripMenuItem TrayWeatherInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button SettingsRestoreButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AboutAppName;
        private System.Windows.Forms.Label AboutAppDesc;
        private System.Windows.Forms.Button openGitHub;
        private System.Windows.Forms.Button SettingsSaveButton;
        private System.Windows.Forms.Label AboutAppVer;
        private System.Windows.Forms.Button GetAPIButton;
        private System.Windows.Forms.CheckBox SettingsAutoRun;
        private System.Windows.Forms.TextBox SettingsRunPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AboutCheckUpdates;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SettingsInterval;
    }
}