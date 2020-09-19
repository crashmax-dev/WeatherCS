using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
// Install-Package Newtonsoft.Json
using Newtonsoft.Json.Linq;

namespace WeatherCS
{
    public partial class MainForm : Shadow
    {

        static readonly HttpClient client = new HttpClient();
        string latt = "";
        string longt = "";
        string data = "";
        bool fade = true;

        public MainForm()
        {
            InitializeComponent();
            InitializeApp();
        }

        async void LoadApp()
        {
            if (fade)
            {
                for (Opacity = 0; Opacity < 0.95; Opacity += 0.05)
                {
                    await Task.Delay(10);
                }
            }

            fade = false;
        }
        async void ErrorHandler(string error = "")
        {
            if (error != "")
            {
                Text = "WeatherCS";
                Tray.Text = error;

                GlobePic.Visible = true;
                ReconnectButton.Visible = true;
                ReloadPage.Visible = true;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = error;

                ReconnectButton.Text = "Переподключиться";
                ReconnectButton.Enabled = true;
            }
            else
            {
                GlobePic.Visible = false;
                ReconnectButton.Visible = false;
                ReloadPage.Visible = false;
                ErrorLabel.Visible = false;

                await Task.Delay(60000);
                GetWeather();
            }
        }
        async void GetWeather()
        {
            try
            {
                string api = String.Format("https://api.openweathermap.org/data/2.5/weather?units=metric&lat={0}&lon={1}&appid=4b7f29a8e15af3ec8d463f83ce5dd419", latt, longt);

                HttpResponseMessage response = await client.GetAsync(api);
                response.EnsureSuccessStatusCode();
                data = await response.Content.ReadAsStringAsync();
                JObject w = JObject.Parse(data);

                // title
                string name = (string)w["name"];
                string region = (string)w["sys"]["country"];
                string title = $"Weather: {name}, {region}";

                //main
                string temp = $"{(string)w["main"]["temp"]} ℃";
                string tempDesc = $"Feels like {(string)w["main"]["feels_like"]}°C";
                string humidity = $"Humidity: {(string)w["main"]["humidity"]}%";
                string pressure = $"Pressure: {(string)w["main"]["pressure"]}hPa";
                string clouds = $"Clouds: {(string)w["clouds"]["all"]}%";
                string wind = $"Wind: {(string)w["wind"]["speed"]}m/sec";

                // labels
                Text = title;
                TempLabel.Text = temp;
                TempDescLabel.Text = tempDesc;
                CloudsLabel.Text = clouds;
                HumidityLabel.Text = humidity;
                WindLabel.Text = wind;
                PressureLabel.Text = pressure;
                LocationLabel.Text = $"{name}, {region}";

                //tray tooltip
                Tray.Text = $"{name}, {region} — {temp}";

                WeatherStatus();
                ErrorHandler();
            }
            catch
            {
                ErrorHandler("Ошибка получения данных с OpenWeatherMap");
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
                HttpResponseMessage ip = await client.GetAsync("https://api.ipify.org");
                ip.EnsureSuccessStatusCode();
                string responseIP = await ip.Content.ReadAsStringAsync();

                HttpResponseMessage geo = await client.GetAsync($"https://geocode.xyz/{responseIP}?json=1");
                geo.EnsureSuccessStatusCode();

                JObject r = JObject.Parse(await geo.Content.ReadAsStringAsync());
                latt = (string)r["latt"];
                longt = (string)r["longt"];

                GetWeather();
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
    }
}