using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
// Install-Package Newtonsoft.Json
using Newtonsoft.Json.Linq;

namespace WeatherCS
{
    public partial class MainForm : Form
    {
        string latt = "";
        string longt = "";
        string data = "";
        public MainForm()
        {
            InitializeComponent();
            InitializeApp();
            LoadApp();
        }

        async void LoadApp()
        {
            for (Opacity = 0; Opacity < 0.95; Opacity += 0.05)
            {
                await Task.Delay(10);
            }
        }
        async void ErrorHandler(string error = "")
        {
            if (error != "")
            {
                GlobePic.Visible = true;
                ReconnectButton.Visible = true;
                ReloadPage.Visible = true;
                ReloadPage.Text = error;
            } else
            {
                GlobePic.Visible = false;
                ReconnectButton.Visible = false;
                ReloadPage.Visible = false;

                await Task.Delay(3600);
                GetWeather();
            }
        }
        async void GetWeather()
        {
            try
            {
                WebClient client = new WebClient();
                data = await client.DownloadStringTaskAsync($"https://api.openweathermap.org/data/2.5/weather?units=metric&lat={latt}&lon={longt}&appid=5f11ea40424990937175d20a072e0c72");
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
                string wind = $"Wind: {(string)w["wind"]["speed"]}m/sec";
                string clouds = $"Clouds: {(string)w["clouds"]["all"]}%";

                //tray tooltip
                Tray.Text = $"{title}\n{temp}\n{humidity}\n{wind}";

                // labels
                Text = title;
                CloudsLabel.Text = clouds;
                TempLabel.Text = temp;
                TempDescLabel.Text = tempDesc;
                HumidityLabel.Text = humidity;
                WindLabel.Text = wind;
                PressureLabel.Text = pressure;
                LocationLabel.Text = $"{name}, {region}";

                WeatherStatus();
                ErrorHandler("1");
            } catch
            {
                ErrorHandler("Ошибка получения данных о погоде");
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
            WebClient client = new WebClient();

            try
            {
                var ip = await client.DownloadStringTaskAsync("https://api.ipify.org");
                var data = await client.DownloadStringTaskAsync($"https://geocode.xyz/{ip}?json=1");

                JObject geo = JObject.Parse(data);
                latt = (string)geo["latt"];
                longt = (string)geo["longt"];

                GetWeather();
            } catch
            {
                ErrorHandler("Ошибка подключения к интернету");
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
            InitializeApp();
        }
    }
}