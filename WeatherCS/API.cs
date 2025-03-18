using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherCS
{
    public static class API
    {
        public static string Key = "4b7f29a8e15af3ec8d463f83ce5dd419";

        public class Release
        {
            public string Tag_Name { get; set; }
        }

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
            return NetworkInterface.GetIsNetworkAvailable();
        }

        public static async Task<T> GetJSON<T>(string url) where T : new()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "WeatherCS API Client");

                var response = await client.GetAsync(url);
                if (response == null) return new T();
                if (!response.IsSuccessStatusCode)
                {
                    string error = $"Ошибка API: {response.StatusCode}";
                    Console.WriteLine(error);
                    return new T();
                }

                string json = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(json))
                {
                    string error = "Пустой ответ от API";
                    Console.WriteLine(error);
                    return new T();
                }

                Console.WriteLine("JSON от API:\n" + json);
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}
