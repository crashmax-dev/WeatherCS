﻿using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Win32;

namespace WeatherCS
{
    public partial class MainForm : Form
    {
        protected override CreateParams CreateParams
        {
            get { CreateParams cp = base.CreateParams; cp.ClassStyle = 0x20000; return cp; }
        }

        bool fadeIn = true;

        public MainForm()
        {
            InitializeComponent();

            Resize += (s, e) =>
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    Hide();
                    Tray.Visible = true;
                }
                else if (FormWindowState.Normal == WindowState)
                { Tray.Visible = false; }
            };
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape && !SettingPanel.Visible)
                {
                    LocMessage.ForeColor = SystemColors.ControlDarkDark;
                    LocMessage.Text = "Нажмите Enter, чтобы сохранить.";
                    e.SuppressKeyPress = true;
                    LocationInput.Text = GetRegistry("location");
                    LocationInput.SelectAll();
                    LocationInput.Focus();
                }
            };

            TitleBar.MouseDown += (s, e) =>
            {
                TitleBar.Capture = false;
                Message m = Message.Create(Handle, 161, new IntPtr(2), IntPtr.Zero);
                WndProc(ref m);
            };
            MinimizeButton.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            CloseButton.Click += (s, e) => { Close(); };
            CloseButton.MouseMove += (s, e) =>
            {
                CloseButton.BackColor = Color.FromArgb(255, 38, 60);
                CloseButton.Image = Properties.Resources.close_white;
            };
            CloseButton.MouseLeave += (s, e) =>
            {
                CloseButton.BackColor = SystemColors.Control;
                CloseButton.Image = Properties.Resources.close_gray;
            };
            SettingButton.Click += (s, e) =>
            {
                if (AboutPanel.Visible)
                {
                    AboutPanel.Visible = false;
                    AboutButton.BackColor = SystemColors.Control;
                }
                SettingPanel.Visible = !SettingPanel.Visible;
                SettingButton.BackColor = SettingPanel.Visible ? SystemColors.ControlLight : SystemColors.Control;
            };
            AboutButton.Click += (s, e) =>
            {
                if (SettingPanel.Visible)
                {
                    SettingPanel.Visible = false;
                    SettingButton.BackColor = SystemColors.Control;
                }
                AboutPanel.Visible = !AboutPanel.Visible;
                AboutButton.BackColor = AboutPanel.Visible ? SystemColors.ControlLight : SystemColors.Control;

            };

            Tray.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Show();
                    Tray.Visible = false;
                    WindowState = FormWindowState.Normal;
                }
            };
            TrayAboutButton.Click += (s, e) =>
            {
                Show();
                Tray.Visible = false;
                WindowState = FormWindowState.Normal;

                if (!AboutPanel.Visible)
                {
                    AboutButton.Focus();
                    SendKeys.Send(" ");
                }
            };
            TraySettingsButton.Click += (s, e) =>
            {
                Show();
                Tray.Visible = false;
                WindowState = FormWindowState.Normal;
                if (!SettingPanel.Visible)
                {
                    SettingButton.Focus();
                    SendKeys.Send(" ");
                }
            };
            TrayCloseButton.Click += (s, e) => { Close(); };

            LocationInput.KeyDown += (s, e) => { UpdateLocation(s, e); };
            LocationInput.KeyPress += (s, e) => { RegExpLocationInput(s, e); };
            LocationInput.TextChanged += (s, e) =>
            {
                int i = LocationInput.TextLength;

                if (i >= 25)
                {
                    LocationInput.Font = new Font("Segoe UI Semibold", 16.75F);
                    LocationInput.Location = new Point(11, 15);
                }
                else if (i >= 20)
                {
                    LocationInput.Location = new Point(11, 10);
                    LocationInput.Font = new Font("Segoe UI Semibold", 18.75F);
                }
                else if (i >= 15)
                {
                    LocationInput.Location = new Point(11, 6);
                    LocationInput.Font = new Font("Segoe UI Semibold", 20.75F);
                }
                else
                {
                    LocationInput.Location = new Point(11, 3);
                    LocationInput.Font = new Font("Segoe UI Semibold", 27.75F);
                }
            };

            SettingsLocation.KeyPress += (s, e) => { RegExpLocationInput(s, e); };
            SettingsApiKey.Enter += (s, e) =>
            {
                SettingsApiKey.PasswordChar = '\0';
            };
            SettingsApiKey.Leave += (s, e) =>
            {
                SettingsApiKey.PasswordChar = '●';
            };
            SettingsApiKey.KeyPress += (s, e) =>
            {
                char k = e.KeyChar;
                if (!char.IsControl(k) &&
                    !char.IsNumber(k) &&
                    (k <= 96 || k >= 193))
                {
                    e.Handled = true;
                }
            };
            SettingsSaveButton.Click += (s, e) =>
            {
                SettingsSaveButton.Enabled = false;
                SetRegistry("api", SettingsApiKey.Text);
                GetWeather(SettingsLocation.Text);
                SettingsSaveButton.Enabled = true;
            };
            SettingsRestoreButton.Click += (s, e) =>
            {
                using (RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\WeatherCS"))
                {
                    if (reg != null)
                    {
                        Registry.CurrentUser.DeleteSubKey(@"Software\WeatherCS");
                        InitializeApp();
                    }
                }
            };

            ReconnectButton.Click += (s, e) =>
            {
                ReconnectButton.Text = "Подключаюсь...";
                ReconnectButton.Enabled = false;
                InitializeApp();
            };

            AboutAppName.Text = About.AssemblyTitle;
            AboutAppVer.Text = About.AssemblyVersion;
            AboutAppDesc.Text = About.AssemblyDescription;
            openGitHub.Click += (s, e) => { Process.Start("https://github.com/crashmax-off/WeatherCS"); };
            GetAPIButton.Click += (s, e) => { Process.Start("https://openweathermap.org/appid"); };
            InitializeApp();
        }

        async void FadeInApp()
        {
            if (fadeIn)
            {
                for (Opacity = 0; Opacity < 0.95; Opacity += 0.05)
                {
                    await Task.Delay(10);
                }
            }
            else { Opacity = 0.95; }
            fadeIn = false;
        }

        void InitializeApp()
        {
            string ipwhois = "https://ipwhois.app/json/?objects=success,city&lang=ru";
            var location = API.GetJSON<API.Geo>(ipwhois);

            if (location.Success)
            {
                AutoRun();
                RegistryApp("api", API.Key);
                RegistryApp("location", location.City);
                GetWeather();
            }
            else
            {
                ErrorHandler("Отсутствует интернет соединение");
            }
        }

        void GetWeather(string newCity = "", string newKey = "")
        {
            string key = newKey != "" ? newKey : GetRegistry("api");
            string query = newCity != "" ? newCity : GetRegistry("location");

            string openweathermap = $"https://api.openweathermap.org/data/2.5/weather?lang=ru&units=metric&q={query}&appid={key}";
            var w = API.GetJSON<API.Root>(openweathermap);

            if (w.Cod.Equals("200"))
            {
                SetRegistry("api", key);
                SetRegistry("location", query);

                string temp = $"{Math.Round(w.Main.Temp, 1)}°C";
                string clouds = $"Облачность: {w.Clouds.All}%";
                string humidity = $"Влажность: {w.Main.Humidity}%";
                string wind = $"Ветер: {w.Wind.Speed}m/sec";

                // convert hPa to mmHg
                string pressure = $"Давление: {Math.Round(w.Main.Pressure * 0.75, 1)}mmHg";

                string loc = w.Name;
                string title = $"{loc} — {temp}";

                // labels
                Text = title;
                Tray.Text = title;
                TrayWeatherInfo.Text = title;
                TempLabel.Text = temp;
                CloudsLabel.Text = clouds;
                HumidityLabel.Text = humidity;
                WindLabel.Text = wind;
                PressureLabel.Text = pressure;
                LocationInput.Text = loc;
                SettingsLocation.Text = loc;
                SettingsApiKey.Text = GetRegistry("api");

                WeatherStatus(w.Weather);
                ErrorHandler();
            }
            else if (w.Cod.Equals("404"))
            {
                SettingsLocation.ForeColor = Color.Firebrick;
                LocMessage.ForeColor = Color.Firebrick;
                LocMessage.Text = "Город не найден, чтобы откатить, нажмите Esc";
            }
            else if (w.Cod.Equals("401"))
            {
                ErrorHandler("Ключ не действителен");
            }
            else
            {
                ErrorHandler("Ошибка доступа к OpenWeatherMap");
            }
        }

        async void WeatherStatus(List<API.Weather> w)
        {
            if (w.Count > 0 && WindowState == FormWindowState.Normal)
            {
                foreach (var i in w)
                {
                    DescriptionPic.Text = FirstLetterToUpper(i.Description);
                    WeatherIco.ImageLocation = String.Format("https://openweathermap.org/img/wn/{0}@4x.png", i.Icon);
                    await Task.Delay(5000);
                }
            }

            DescriptionPic.Text = FirstLetterToUpper(w[0].Description);
            WeatherIco.ImageLocation = String.Format("https://openweathermap.org/img/wn/{0}@4x.png", w[0].Icon);
        }

        async void ErrorHandler(string error = "")
        {
            if (error != "")
            {
                Text = "WeatherCS";
                // 64 ???
                Tray.Text = error;
                TrayWeatherInfo.Text = error;

                ErrorPanel.Visible = true;
                ReconnectButton.Text = "Обновить";
                ReconnectButton.Enabled = true;
                DescriptionErrorLabel.Text = error;
                SettingsLocation.Text = error;

                RegistryApp("api", API.Key);
                SettingsApiKey.Text = GetRegistry("api");
                FadeInApp();
            }
            else
            {
                ErrorPanel.Visible = false;

                SettingsLocation.ForeColor = SystemColors.ControlDarkDark;
                LocMessage.ForeColor = SystemColors.ControlDarkDark;
                LocMessage.Text = $"Обновлено в {DateTime.Now:HH:mm}";
                FadeInApp();
                await Task.Delay(60000);
                GetWeather();
            }
        }

        void AutoRun()
        {
            RegistryKey Run = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            Run.SetValue("WeatherCS", $"\"{Application.ExecutablePath}\"");
        }

        void RegistryApp(string key, string value)
        {
            using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Software\WeatherCS"))
                if (reg.GetValue(key) == null) reg.SetValue(key, value);
        }

        string GetRegistry(string key)
        {
            using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Software\WeatherCS"))
                if (reg.GetValue(key) != null)
                    return reg.GetValue(key).ToString();
                else
                    return "";
        }

        void SetRegistry(string key, string value)
        {
            using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Software\WeatherCS"))
            {

                if (reg.GetValue(key) == null)
                {
                    reg.SetValue(key, value);
                }
                else if (reg.GetValue(key).ToString() != value)
                {
                    reg.SetValue(key, value);
                }
            }
        }

        string FirstLetterToUpper(string str)
        {
            return Char.ToUpper(str[0]) + str.Substring(1);
        }

        void UpdateLocation(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActiveControl = null;
                e.SuppressKeyPress = true;
                GetWeather((sender as TextBox).Text);
            }
        }

        void RegExpLocationInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                (e.KeyChar != ' ' && e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}