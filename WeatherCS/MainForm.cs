using System;
using System.Net;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace WeatherCS
{
    public partial class MainForm : Form
    {
        protected override CreateParams CreateParams
        {
            get { CreateParams cp = base.CreateParams; cp.ClassStyle = 0x20000; return cp; }
        }

        readonly string appName = About.AssemblyTitle;
        readonly string exPath = Application.ExecutablePath;
        bool fadeIn = true;
        bool isChecked = false;
        bool isEntered = false;

        public MainForm()
        {
            InitializeComponent();
            Load += async (s, e) =>
            {
                if (GetRegistry("autorun") == null)
                    SetRegistry("autorun", "True");

                if (GetRegistry("autorun") == "True")
                {
                    SettingsAutoRun.Checked = true;
                    String[] args = Environment.GetCommandLineArgs();

                    if (args.Length > 1)
                    {
                        if (args[1] == "/minimized")
                        {
                            // костыль ебаный!
                            await Task.Delay(10);
                            WindowState = FormWindowState.Minimized;
                            Hide();
                        }
                    }
                }
                else
                {
                    SettingsAutoRun.Checked = false;
                }
            };
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

            LocationInput.Enter += (s, e) => { isEntered = true; LocMessage.Text = "Нажмите Enter, чтобы сохранить."; };
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
            SettingsApiKey.Enter += (s, e) => { SettingsApiKey.PasswordChar = '\0'; };
            SettingsApiKey.Leave += (s, e) => { SettingsApiKey.PasswordChar = '●'; };
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
            SettingsRunPath.Text = exPath;
            SettingsAutoRun.CheckedChanged += (s, e) =>
            {
                bool check = (s as CheckBox).Checked;

                if (check)
                {
                    SetRegistry("autorun", "True");
                    using (RegistryKey r = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                        r.SetValue(About.AssemblyTitle, exPath + " /minimized");
                }
                else
                {
                    SetRegistry("autorun", "False");
                    using (RegistryKey r = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                        r.DeleteValue(About.AssemblyTitle);
                }
            };
            SettingsInterval.KeyPress += (s, e) =>
            {
                char k = e.KeyChar;
                if (!char.IsControl(k) && !char.IsNumber(k))
                    e.Handled = true;
            };
            SettingsSaveButton.Click += (s, e) =>
            {
                var b = (s as Button);
                b.Enabled = false;
                if(SettingsInterval.Text != "0")
                {
                    SetRegistry("interval", SettingsInterval.Text);
                    Timer.Interval = Convert.ToInt32(SettingsInterval.Text) * 60000;
                    SettingsInterval.ForeColor = SystemColors.ControlDarkDark;
                } else
                {
                    SettingsInterval.ForeColor = Color.Firebrick;
                }
                SetRegistry("api", SettingsApiKey.Text);
                GetWeather(SettingsLocation.Text);
                b.Enabled = true;
            };
            SettingsRestoreButton.Click += (s, e) =>
            {
                using (RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\" + appName))
                {
                    if (reg != null)
                    {
                        Registry.CurrentUser.DeleteSubKey(@"Software\" + appName);
                    }
                }

                using (RegistryKey run = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run"))
                {
                    if (run.GetValue(appName) != null)
                        run.DeleteValue(appName);
                    SetRegistry("autorun", "True");
                    SettingsAutoRun.Checked = true;
                }

                InitializeApp();
            };

            ReconnectButton.Click += (s, e) =>
            {
                ReconnectButton.Text = "Подключаюсь...";
                ReconnectButton.Enabled = false;
                InitializeApp();
            };

            AboutAppName.Text = appName;
            AboutAppVer.Text = $"Версия {About.AssemblyVersion}";
            AboutAppDesc.Text = About.AssemblyDescription;
            openGitHub.Click += (s, e) => { Process.Start("https://github.com/crashmax-off/WeatherCS"); };
            GetAPIButton.Click += (s, e) => { Process.Start("https://openweathermap.org/appid"); };
            AboutCheckUpdates.Click += (s, e) =>
            {
                var b = (s as Button);
                b.Enabled = false;
                CheckForUpdates();
            };

            InitializeApp();
        }

        void InitializeApp()
        {
            var location = API.GetJSON<API.Geo>("https://ipwhois.app/json/?objects=success,city&lang=ru");

            if (location.Success)
            {
                RegistryApp("api", API.Key);
                RegistryApp("location", location.City);
                RegistryApp("interval", "10");

                SettingsApiKey.Text = GetRegistry("api");
                SettingsInterval.Text = GetRegistry("interval");
                Timer.Interval = Convert.ToInt32(SettingsInterval.Text) * 60000;

                GetWeather();
            }
            else
            {
                ErrorHandler("Отсутствует интернет соединение");
            }

            CheckForUpdates();
        }

        void GetWeather(string newCity = "", string newKey = "")
        {
            string key = newKey != "" ? newKey : GetRegistry("api");
            string query = newCity != "" ? newCity : GetRegistry("location");

            var w = API.GetJSON<API.Root>($"https://api.openweathermap.org/data/2.5/weather?lang=ru&units=metric&q={query}&appid={key}");

            if (w.Cod.Equals("200"))
            {
                isEntered = false;
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
                DescriptionPic.Text = FirstLetterToUpper(w.Weather[0].Description);
                WeatherIco.ImageLocation = String.Format("https://openweathermap.org/img/wn/{0}@4x.png", w.Weather[0].Icon);

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

        void Schedule(object sender, EventArgs e)
        {
            if(!isEntered || !SettingPanel.Visible)
            {
                GetWeather();
            }
        }

        void CheckForUpdates()
        {
            using (WebClient w = new WebClient())
            {
                Match m = Regex.Match(w.DownloadString("https://raw.githubusercontent.com/crashmax-off/WeatherCS/master/WeatherCS/Properties/AssemblyInfo.cs"), @"\[assembly\: AssemblyVersion\(""(\d+\.\d+\.\d+)""\)\]");
                string[] v1 = m.Groups[1].Value.Split('.');
                string[] v2 = About.AssemblyVersion.Split('.');
                string[] r = v2.Where(x => v1.Any(y => y.Equals(x))).ToArray();
                string u = "https://github.com/crashmax-off/WeatherCS/releases/latest";

                if (r.Length < 3)
                {
                    AboutButton.Size = new Size(150, 21);
                    AboutButton.Text = "Доступна новая версия";
                    AboutCheckUpdates.Text = "Обновиться до " + m.Groups[1].Value;
                    AboutCheckUpdates.Click += (s, e) => { Process.Start(u); };

                    if (!isChecked)
                    {
                        Tray.BalloonTipTitle = "Доступна новая версия " + m.Groups[1].Value;
                        Tray.BalloonTipText = "Нажмите, чтобы перейти на GitHub";
                        Tray.BalloonTipIcon = ToolTipIcon.Info;
                        Tray.BalloonTipClicked += (s, e) => { Process.Start(u); };
                        Tray.Visible = true;
                        Tray.ShowBalloonTip(1000);
                        isChecked = true;
                    }
                }
                else
                {
                    AboutCheckUpdates.Text = "Проверить обновления";
                }
            }

            AboutCheckUpdates.Enabled = true;
        }

        void ErrorHandler(string error = "")
        {
            FadeInApp();

            if (error != "")
            {
                Text = appName;
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
            }
            else
            {
                ErrorPanel.Visible = false;

                SettingsLocation.ForeColor = SystemColors.ControlDarkDark;
                LocMessage.ForeColor = SystemColors.ControlDarkDark;
                LocMessage.Text = $"Обновлено в {DateTime.Now:HH:mm}";
            }
        }

        void RegistryApp(string key, string value)
        {
            using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Software\" + appName, true))
                if (reg.GetValue(key) == null) reg.SetValue(key, value);
        }

        string GetRegistry(string key)
        {
            using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Software\" + appName))
                if (reg.GetValue(key) != null)
                    return reg.GetValue(key).ToString();
                else
                    return null;
        }

        void SetRegistry(string key, string value)
        {
            using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Software\" + appName))
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