using System.IO;
using System.Net;
using System.Text;
// Install-Package Newtonsoft.Json
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace WeatherCS
{
    public static class API
    {
        // https://openweathermap.org/api
        public static string Key = "4b7f29a8e15af3ec8d463f83ce5dd419";

        public class Geo
        {
            public bool Success { get; set; }
            public string City { get; set; }
        }

        public class Weather
        {
            public string Description { get; set; }
            public string Icon { get; set; }
        }

        public class Main
        {
            public double Temp { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
        }

        public class Wind
        {
            public double Speed { get; set; }
        }

        public class Clouds
        {
            public int All { get; set; }
        }

        public class Root
        {
            public List<Weather> Weather { get; set; }
            public Main Main { get; set; }
            public Wind Wind { get; set; }
            public Clouds Clouds { get; set; }
            public string Name { get; set; }
            public string Cod { get; set; }
        }

        public static bool CheckInternet()
        {
            if (NetworkInterface.GetIsNetworkAvailable() &&
                        new Ping().Send(new IPAddress(new byte[] { 8, 8, 8, 8 }), 2000).Status == IPStatus.Success)
                return true;
            else
                return false;
        }

        public static T GetJSON<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                w.Encoding = Encoding.UTF8;
                var json_data = string.Empty;

                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (WebException ex)
                {
                    if (CheckInternet())
                    {
                        using (StreamReader r = new StreamReader(ex.Response.GetResponseStream()))
                        {
                            json_data = r.ReadToEnd();
                        }
                    }
                    else
                    {
                        return JsonConvert.DeserializeObject<T>("{\"cod\": 0}");
                    }
                }

                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }
}