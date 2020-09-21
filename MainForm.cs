using System;
using System.Drawing;
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
                if (e.KeyCode == Keys.Escape)
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
                SettingPanel.Visible = !SettingPanel.Visible;
                SettingButton.BackColor = SettingPanel.Visible ? SystemColors.ControlLight : SystemColors.Control;
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

            ReconnectButton.Click += (s, e) =>
            {
                ReconnectButton.Text = "Подключаюсь...";
                ReconnectButton.Enabled = false;
                InitializeApp();
            };

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
                RegistryApp("api", "4b7f29a8e15af3ec8d463f83ce5dd419");
                RegistryApp("location", location.City);
                GetWeather();
            }
            else
            {
                ErrorHandler("Ошибка интернет соединения");
            }
        }

        void GetWeather(string newCity = "")
        {
            string key = GetRegistry("api");
            string query = newCity != "" ? newCity : GetRegistry("location");

            string openweathermap = $"https://api.openweathermap.org/data/2.5/weather?lang=ru&units=metric&q={query}&appid={key}";
            var w = API.GetJSON<API.Root>(openweathermap);

            if (w.Cod.Equals("200"))
            {
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
                TempLabel.Text = temp;
                CloudsLabel.Text = clouds;
                HumidityLabel.Text = humidity;
                WindLabel.Text = wind;
                PressureLabel.Text = pressure;
                LocationInput.Text = loc;
                SettingsLocation.Text = loc;

                WeatherStatus(w.Weather);
                ErrorHandler();
            }
            else if (w.Cod.Equals("404"))
            {
                LocMessage.ForeColor = Color.Firebrick;
                LocMessage.Text = "Город не найден, чтобы откатить, нажмите Esc";
            }
            else if (w.Cod.Equals("401"))
            {
                ErrorHandler("Недействительный ключ авторизации");
            }
            else
            {
                ErrorHandler("Ошибка доступа к OpenWeatherMap");
            }
        }

        async void WeatherStatus(List<API.Weather> w)
        {
            while (w.Count < 0)
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

                ErrorPanel.Visible = true;
                ReconnectButton.Text = "Обновить";
                ReconnectButton.Enabled = true;
                DescriptionErrorLabel.Text = error;
                FadeInApp();
            }
            else
            {
                ErrorPanel.Visible = false;

                LocMessage.ForeColor = SystemColors.ControlDarkDark;
                LocMessage.Text = $"Обновлено в {DateTime.Now:HH:mm}";
                FadeInApp();
                await Task.Delay(60000);
                GetWeather();
            }
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
                reg.SetValue(key, value);
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