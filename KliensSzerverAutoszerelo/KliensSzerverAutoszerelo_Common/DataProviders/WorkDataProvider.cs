using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using KliensSzerverAutoszerelo_Common.Models;
using Newtonsoft.Json;

namespace KliensSzerverAutoszerelo_Common.DataProviders {
    public class WorkDataProvider {

        private const string URL = "http://localhost:5000/api/work";

        public static IEnumerable<Work> GetWorks() {

            using (var client = new HttpClient()) {

                var response = client.GetAsync(URL).Result;

                if (response.IsSuccessStatusCode) {

                    var rawData = response.Content.ReadAsStringAsync().Result;
                    IEnumerable<Work> works = JsonConvert.DeserializeObject<IEnumerable<Work>>(rawData);
                    return works;
                }
                throw new InvalidOperationException($"Failed to read works {response.StatusCode}");
            }
        }

        public static void CreateWork(Work work) {

            using(var client = new HttpClient()) {

                var rawData = JsonConvert.SerializeObject(work);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(URL, content).Result;
                if (!response.IsSuccessStatusCode) {

                    throw new InvalidOperationException($"Failed to create work {response.StatusCode}");
                }
            }
        }
    }
}
