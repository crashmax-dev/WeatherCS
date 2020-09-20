using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Install-Package Newtonsoft.Json
using Newtonsoft.Json.Linq;

namespace WeatherCS
{
    public partial class MainForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = 0x20000;
                return cp;
            }
        }

        static readonly HttpClient client = new HttpClient();

        string city = "";
        string data = "";
        bool fadeIn = true;

        public MainForm()
        {
            InitializeComponent();
            InitializeApp();
        }

        async void LoadApp()
        {
            if (fadeIn)
            {
                for (Opacity = 0; Opacity < 0.95; Opacity += 0.05)
                {
                    await Task.Delay(10);
                }
            } else { Opacity = 0.95; }

            fadeIn = false;
        }
        async void ErrorHandler(string error = "")
        {
            if (error != "")
            {
                Text = "WeatherCS";
                // 64 ???
                Tray.Text = error;

                ReloadPage.Visible = true;
                GlobePic.Visible = true;
                ReconnectButton.Visible = true;
                ReconnectButton.Text = "Обновить";
                ReconnectButton.Enabled = true;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = error;
            }
            else
            {
                ReloadPage.Visible = false;
                GlobePic.Visible = false;
                ReconnectButton.Visible = false;
                ErrorLabel.Visible = false;

                LocMessage.ForeColor = SystemColors.ControlDarkDark;
                LocMessage.Text = $"Обновлено в {DateTime.Now:HH:mm}";
                await Task.Delay(60000);
                GetWeather();
            }
        }
        async void GetWeather(string newCity = "")
        {
            try
            {
                string query = newCity == "" ? city : newCity;
                string api = $"https://api.openweathermap.org/data/2.5/weather?lang=ru&units=metric&q={query}&appid=4b7f29a8e15af3ec8d463f83ce5dd419";
                HttpResponseMessage response = await client.GetAsync(api);
                Encoding.UTF8.GetString(await response.Content.ReadAsByteArrayAsync());

                data = await response.Content.ReadAsStringAsync();

                if (response.StatusCode.ToString() == "OK")
                {
                    city = query;
                    JObject w = JObject.Parse(data);

                    // strings
                    string temp = $"{Math.Ceiling((double)w["main"]["temp"])}°C";
                    string humidity = $"Влажность: {(string)w["main"]["humidity"]}%";
                    string pressure = $"Давление: {Math.Round((int)w["main"]["pressure"] * 0.75, 1)}mmHg";
                    string clouds = $"Облачность: {(string)w["clouds"]["all"]}%";
                    string wind = $"Ветер: {(string)w["wind"]["speed"]}m/sec";
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

                    WeatherStatus();
                    ErrorHandler();
                }
                else
                {
                    LocMessage.ForeColor = Color.Firebrick;
                    LocMessage.Text = "Город не найден, чтобы откатить, нажмите Esc.";
                }
            }
            catch
            {
                ErrorHandler("Ошибка получения данных с OpenWeatherMap.");
            }
            finally
            {
                LoadApp();
            }
        }

        async void WeatherStatus()
        {
            JObject w = JObject.Parse(data);

            foreach (var i in w["weather"])
            {
                WeatherIco.ImageLocation = String.Format("https://openweathermap.org/img/wn/{0}@4x.png", i["icon"]);
                await Task.Delay(5000);
            }
        }
        async void InitializeApp()
        {
            try
            {
                HttpResponseMessage geo = await client.GetAsync("https://ipwhois.app/json/?objects=city&lang=ru");

                if (geo.StatusCode.ToString() == "OK")
                {
                    JObject r = JObject.Parse(await geo.Content.ReadAsStringAsync());
                    city = (string)r["city"];
                    GetWeather();
                }
                else
                {
                    ErrorHandler("Ошибка определения вашей геолокации.");
                    LoadApp();
                }
            }
            catch (HttpRequestException e)
            {
                ErrorHandler(e.Message);
                LoadApp();
            }
        }

        private void FormMove(object sender, MouseEventArgs e)
        {
            CustomPanel.Capture = false;
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

        private void EscEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LocMessage.ForeColor = SystemColors.ControlDarkDark;
                LocMessage.Text = "Нажмите Enter, чтобы сохранить.";
                e.SuppressKeyPress = true;
                LocationInput.Text = city;
                LocationInput.Focus();
            }
        }
    }
}