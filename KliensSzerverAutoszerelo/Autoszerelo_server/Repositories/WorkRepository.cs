using KliensSzerverAutoszerelo_Common.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Autoszerelo_Szerver.Repositories
{
    public static class WorkRepository
    {
        public static IList<Work> GetWorks() 
        {
            var appDataPath = GetAppDataPath();

            if (File.Exists(appDataPath))
            {
                var rawContent = File.ReadAllText(appDataPath);
                var works = JsonSerializer.Deserialize<IList<Work>>(rawContent);
                return works;
            }

            return new List<Work>();
        }

        public static void StoreWorks(IList<Work> works)
        {
            var appDataPath = GetAppDataPath();

            var rawContent = JsonSerializer.Serialize(works);
            File.WriteAllText(appDataPath, rawContent);
        }

        public static string GetAppDataPath()
        {
            var localAppFolder = GetLocalFolder();
            var appDataPath = Path.Combine(localAppFolder,"WorkState.json");
            return appDataPath;
        }

        public static string GetLocalFolder()
        {
            var localAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var localAppFolder = Path.Combine(localAppDataFolder, "WebAPI_Server");

            if (!Directory.Exists(localAppFolder))
            {
                Directory.CreateDirectory(localAppFolder);
            }

            return localAppFolder;
        }
    }
}
