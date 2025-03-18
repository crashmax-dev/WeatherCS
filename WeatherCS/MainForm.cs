using System;
using System.Net;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WeatherCS
{
    public partial class MainForm : Form
    {
        protected override CreateParams CreateParams
        {
            get { CreateParams cp = base.CreateParams; cp.ClassStyle = 0x20000; return cp; }
        }

        public static readonly string APP_NAME = About.AssemblyTitle;
        public static readonly string EXECUTABLE_PATH = Application.ExecutablePath;

        bool isChecked = false;
        bool isEntered = false;

        public MainForm()
        {
            InitializeComponent();

            Load += async (s, e) =>
            {
                if (Registry.GetRegistry("autorun") == null)
                    Registry.SetRegistry("autorun", "True");

                if (Registry.GetRegistry("autorun") == "True")
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
                    LocationInput.Text = Registry.GetRegistry("location");
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
                    FadeInApp();
                }
            };
            TrayAboutButton.Click += (s, e) =>
            {
                Show();
                Tray.Visible = false;
                WindowState = FormWindowState.Normal;
                FadeInApp();

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
                FadeInApp();

                if (!SettingPanel.Visible)
                {
                    SettingButton.Focus();
                    SendKeys.Send(" ");
                }
            };
            TrayCloseButton.Click += (s, e) => { Close(); };

            LocationInput.Enter += (s, e) => { isEntered = true; LocMessage.Text = "Нажмите Enter, чтобы сохранить."; };
            LocationInput.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ActiveControl = null;
                    e.SuppressKeyPress = true;
                    GetWeather((s as TextBox).Text);
                }
            };
            LocationInput.KeyPress += (s, e) => { Helpers.RegExpLocationInput(s, e); };
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

            SettingsLocation.KeyPress += (s, e) => { Helpers.RegExpLocationInput(s, e); };
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
            SettingsRunPath.Text = EXECUTABLE_PATH;
            SettingsAutoRun.CheckedChanged += (s, e) =>
            {
                bool check = (s as CheckBox).Checked;
                if (check) Registry.RegistryEnableAutorun();
                else Registry.RegistryDisableAutorun();
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
                if (SettingsInterval.Text != "0")
                {
                    Registry.SetRegistry("interval", SettingsInterval.Text);
                    Timer.Interval = Convert.ToInt32(SettingsInterval.Text) * 60000;
                    SettingsInterval.ForeColor = SystemColors.ControlDarkDark;
                }
                else
                {
                    SettingsInterval.ForeColor = Color.Firebrick;
                }
                Registry.SetRegistry("api", SettingsApiKey.Text);
                GetWeather(SettingsLocation.Text);
                b.Enabled = true;
            };
            SettingsRestoreButton.Click += (s, e) =>
            {
                Registry.RestoreRegistry();
                SettingsAutoRun.Checked = true;
                InitializeApp();
            };

            ReconnectButton.Click += (s, e) =>
            {
                ReconnectButton.Text = "Подключаюсь...";
                ReconnectButton.Enabled = false;
                InitializeApp();
            };

            AboutAppName.Text = APP_NAME;
            AboutAppVer.Text = $"Версия {About.AssemblyVersion}";
            AboutAppDesc.Text = About.AssemblyDescription;
            openGitHub.Click += (s, e) => { Process.Start("https://github.com/crashmax-dev/WeatherCS"); };
            GetAPIButton.Click += (s, e) => { Process.Start("https://openweathermap.org/appid"); };
            AboutCheckUpdates.Click += async (s, e) =>
            {
                var b = (s as Button);
                b.Enabled = false;
                await CheckForUpdates();
            };

            InitializeApp();
        }

        async void InitializeApp()
        {
            var location = await API.GetJSON<API.Geo>("https://ipwhois.app/json/?objects=success,city&lang=ru");

            if (location.Success)
            {
                Registry.SetRegistry("api", API.Key);
                Registry.SetRegistry("location", location.City);
                Registry.SetRegistry("interval", "10");

                SettingsApiKey.Text = Registry.GetRegistry("api");
                SettingsInterval.Text = Registry.GetRegistry("interval");
                Timer.Interval = Convert.ToInt32(SettingsInterval.Text) * 60000;

                GetWeather();
                FadeInApp();
            }
            else
            {
                ErrorHandler("Отсутствует интернет соединение");
            }

            await CheckForUpdates();
        }

        async void GetWeather(string newCity = "", string newKey = "")
        {
            string key = newKey != "" ? newKey : Registry.GetRegistry("api");
            string query = newCity != "" ? newCity : Registry.GetRegistry("location");

            var w = await API.GetJSON<API.Root>($"https://api.openweathermap.org/data/2.5/weather?lang=ru&units=metric&q={query}&appid={key}");

            if (w.Cod.Equals("200"))
            {
                isEntered = false;
                Registry.SetRegistry("api", key);
                Registry.SetRegistry("location", query);

                string temp = $"{Math.Round(w.Main.Temp, 1)}°C";
                string clouds = $"Облачность: {w.Clouds.All}%";
                string humidity = $"Влажность: {w.Main.Humidity}%";
                string wind = $"Ветер: {w.Wind.Speed}m/sec";

                // convert hPa to mmHg
                string pressure = $"Давление: {Math.Round(w.Main.Pressure * 0.75, 1)}mmHg";

                string loc = w.Name;
                string title = $"{loc} ({temp})";

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
                DescriptionPic.Text = Char.ToUpper(w.Weather[0].Description[0]) + w.Weather[0].Description.Substring(1);

                object iconImage = Properties.Resources.ResourceManager.GetObject(w.Weather[0].Icon);
                if (iconImage is Image image)
                {
                    WeatherIco.Image = Helpers.AdjustImageContrast(image, 1.5f);
                }

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

        async Task CheckForUpdates()
        {
            using (WebClient w = new WebClient())
            {
                var release = await API.GetJSON<API.Release>("https://api.github.com/repos/crashmax-dev/WeatherCS/releases/latest");
                if (release.Tag_Name != null)
                {
                    string[] v1 = release.Tag_Name.Split('.');
                    string[] v2 = About.AssemblyVersion.Split('.');
                    string[] r = v1.Where(x => v2.Any(y => y.Equals(x))).ToArray();
                    string u = "https://github.com/crashmax-dev/WeatherCS/releases/latest";

                    if (r.Length < 3)
                    {
                        AboutButton.Size = new Size(150, 21);
                        AboutButton.Text = "Доступна новая версия";
                        AboutCheckUpdates.Text = "Обновиться до " + release.Tag_Name;
                        AboutCheckUpdates.Click += (s, e) => { Process.Start(u); };

                        if (!isChecked)
                        {
                            Tray.BalloonTipTitle = "Доступна новая версия " + release.Tag_Name;
                            Tray.BalloonTipText = "Нажмите, чтобы перейти на GitHub";
                            Tray.BalloonTipIcon = ToolTipIcon.Info;
                            Tray.BalloonTipClicked += (s, e) => { Process.Start(u); };
                            Tray.Visible = true;
                            Tray.ShowBalloonTip(1000);
                            isChecked = true;
                        }

                        return;
                    }
                }
            }

            AboutCheckUpdates.Text = "Проверить обновления";
            AboutCheckUpdates.Enabled = true;
        }

        void ErrorHandler(string error = "")
        {
            if (error != "")
            {
                Text = APP_NAME;
                // 64 ???
                Tray.Text = error;
                TrayWeatherInfo.Text = error;

                ErrorPanel.Visible = true;
                ReconnectButton.Text = "Обновить";
                ReconnectButton.Enabled = true;
                DescriptionErrorLabel.Text = error;
                SettingsApiKey.ForeColor = Color.Firebrick;

                Registry.SetRegistry("api", API.Key);
                SettingsApiKey.Text = API.Key;
            }
            else
            {
                ErrorPanel.Visible = false;

                SettingsLocation.ForeColor = SystemColors.ControlDarkDark;
                SettingsApiKey.ForeColor = SystemColors.ControlDarkDark;
                LocMessage.ForeColor = SystemColors.ControlDarkDark;
                LocMessage.Text = $"Обновлено в {DateTime.Now:HH:mm}";
            }
        }

        async void FadeInApp()
        {
            for (Opacity = 0; Opacity < 0.95; Opacity += 0.05)
            {
                await Task.Delay(10);
            }
        }
    }
}
