using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Teleman.Core.JsonHelper
{
    public static class JH
    {
        private static string filePath = "tp_list.json";

        public static List<TeleportPoint> LoadTeleportPoints()
        {
            if (!File.Exists(filePath))
            {
                // Create a new empty list and save it to the file
                SaveTeleportPoints(new List<TeleportPoint>());
                return new List<TeleportPoint>();
            }

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<TeleportPoint>>(json);
        }

        public static void SaveTeleportPoints(List<TeleportPoint> points)
        {
            var json = JsonConvert.SerializeObject(points, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
