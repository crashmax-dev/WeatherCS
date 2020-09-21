using System;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
// Install-Package Newtonsoft.Json
using Newtonsoft.Json.Linq;

namespace WeatherCS
{
    public partial class MainForm : Form
    {
        protected override CreateParams CreateParams
        {
            get { CreateParams cp = base.CreateParams; cp.ClassStyle = 0x20000; return cp; }
        }

        static JObject w;
        static readonly HttpClient client = new HttpClient();
        bool fadeIn = true;

        public MainForm()
        {
            InitializeComponent();
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

        async void InitializeApp()
        {
            try
            {
                HttpResponseMessage geo = await client.GetAsync("https://ipwhois.app/json/?objects=city&lang=ru");

                if (geo.IsSuccessStatusCode)
                {
                    JObject r = JObject.Parse(await geo.Content.ReadAsStringAsync());
                    RegistryApp("location", (string)r["city"]);
                    GetWeather();
                }
                else
                {
                    ErrorHandler("Ошибка определения вашей геолокации");
                }
            }
            catch (HttpRequestException e)
            {
                ErrorHandler(e.Message);
            }
        }

        async void GetWeather(string newCity = "")
        {
            try
            {
                string query = newCity == "" ? GetRegistry("location") : newCity;
                string api = $"https://api.openweathermap.org/data/2.5/weather?lang=ru&units=metric&q={query}&appid=4b7f29a8e15af3ec8d463f83ce5dd419";
                
                HttpResponseMessage response = await client.GetAsync(api);
                Encoding.UTF8.GetString(await response.Content.ReadAsByteArrayAsync());
                w = JObject.Parse(await response.Content.ReadAsStringAsync());

                bool IsSuccess = response.IsSuccessStatusCode;
                string StatusCode = response.StatusCode.ToString();

                if (IsSuccess && StatusCode == "OK")
                {
                    SetRegistry("location", query);

                    string temp = $"{Math.Round((double)w["main"]["temp"], 1)}°C";
                    string clouds = $"Облачность: {(string)w["clouds"]["all"]}%";
                    string humidity = $"Влажность: {(string)w["main"]["humidity"]}%";
                    string wind = $"Ветер: {(string)w["wind"]["speed"]}m/sec";

                    // convert hPa to mmHg
                    string pressure = $"Давление: {Math.Round((double)w["main"]["pressure"] * 0.75, 1)}mmHg";

                    string loc = (string)w["name"];
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
                    LocationInputS.Text = loc;

                    WeatherStatus();
                    ErrorHandler();

                    // animation for SettingsMessage
                    if(query != "")
                    {
                        // 0, 202, 40 Green
                        // 227, 227, 227 ControlLight
                        SettingsMessage.Visible = true;

                        for (byte r = 227, g = 227, b = 227; r >= 0 & g >= 202 & b >= 40; r -= 22, g -= 2, b -= 18, await Task.Delay(30))
                            SettingsMessage.ForeColor = Color.FromArgb(r, g, b);
                        SettingsMessage.ForeColor = Color.FromArgb(0, 202, 40);
                        await Task.Delay(1000);
                        for (byte r = 0, g = 202, b = 40; r <= 227 & g <= 227 & b <= 227; r += 22, g += 2, b += 18, await Task.Delay(30))
                            SettingsMessage.ForeColor = Color.FromArgb(r, g, b);
                        SettingsMessage.ForeColor = Color.FromArgb(227, 227, 227);
                    }
                }
                else if(StatusCode == "NotFound")
                {
                    LocMessage.ForeColor = Color.Firebrick;
                    LocMessage.Text = "Город не найден, чтобы откатить, нажмите Esc";
                }
                else if(StatusCode == "Unauthorized")
                {
                    ErrorHandler("Требуется ключ авторизация для OpenWeatherMap");
                }
            }
            catch
            {
                ErrorHandler("Ошибка доступа к OpenWeatherMap");
            }
            finally
            {
                FadeInApp();
            }
        }

        async void WeatherStatus()
        {
            if(w["weather"].Count() > 1)
            {
                foreach (var i in w["weather"])
                {
                    DescriptionPic.Text = (string)i["description"];
                    WeatherIco.ImageLocation = String.Format("https://openweathermap.org/img/wn/{0}@4x.png", i["icon"]);
                    await Task.Delay(5000);
                }
            } else
            {
                DescriptionPic.Text = (string)w["weather"][0]["description"];
                WeatherIco.ImageLocation = String.Format("https://openweathermap.org/img/wn/{0}@4x.png", w["weather"][0]["icon"]);
            }
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
                await Task.Delay(60000);
                GetWeather();
            }
        }

        private void RegistryApp(string key, string value)
        {
            using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Software\WeatherCS"))
                if (reg.GetValue(key) == null)
                    reg.SetValue(key, value);
        }

        private static string GetRegistry(string key)
        {
            using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Software\WeatherCS"))
                if (reg.GetValue(key) != null)
                    return reg.GetValue(key).ToString();
                else
                    return "";
        }

        private void SetRegistry(string key, string value)
        {
            using (RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Software\WeatherCS"))
                reg.SetValue(key, value);
        }

        private void FormMove(object sender, MouseEventArgs e)
        {
            TitleBar.Capture = false;
            Message m = Message.Create(Handle, 161, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Close();
        }

        private void MinApp(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButtonHover(object sender, MouseEventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(255, 38, 60);
            CloseButton.Image = Properties.Resources.close_white;
        }

        private void CloseButtonLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = SystemColors.Control;
            CloseButton.Image = Properties.Resources.close_gray;
        }

        private void ToTray(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                Tray.Visible = true;
            }
            else if (FormWindowState.Normal == WindowState)
            { Tray.Visible = false; }
        }

        private void ShowApp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                Tray.Visible = false;
                WindowState = FormWindowState.Normal;
            }
        }
        private void Reconnect(object sender, EventArgs e)
        {
            ReconnectButton.Text = "Подключаюсь...";
            ReconnectButton.Enabled = false;
            InitializeApp();
        }

        private void UpdateLocation(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActiveControl = null;
                e.SuppressKeyPress = true;
                GetWeather(LocationInput.Text);
            }
        }

        private void UpdateLocationS(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActiveControl = null;
                e.SuppressKeyPress = true;
                GetWeather(LocationInputS.Text);
            }
        }

        private void EscEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LocMessage.ForeColor = SystemColors.ControlDarkDark;
                LocMessage.Text = "Нажмите Enter, чтобы сохранить.";
                e.SuppressKeyPress = true;
                LocationInput.Text = GetRegistry("location");
                LocationInput.Focus();
            }
        }

        private void RegExpLocationInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                (e.KeyChar != ' ' && e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            SettingPanel.Visible = SettingPanel.Visible ? false : true;
            SettingButton.BackColor = SettingPanel.Visible ? SystemColors.ControlLight : SystemColors.Control;
            SettingsMessage.Visible = false;
        }

        private void LabelFontSize(object sender, EventArgs e)
        {
            int i = LocationInput.TextLength;

            if (i >= 25)
            {
                LocationInput.Font = new Font("Segoe UI Semibold", 16.75F);
                LocationInput.Location = new Point(11, 15);
            } else if(i >= 20)
            {
                LocationInput.Location = new Point(11, 10);
                LocationInput.Font = new Font("Segoe UI Semibold", 18.75F);
            } else if(i >= 15)
            {
                LocationInput.Location = new Point(11, 6);
                LocationInput.Font = new Font("Segoe UI Semibold", 20.75F);
            } else
            {
                LocationInput.Location = new Point(11, 3);
                LocationInput.Font = new Font("Segoe UI Semibold", 27.75F);
            }
        }
    }
}