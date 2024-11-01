using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace ServerApp
{
    internal static class Data
    {
        public static List<Organization> Organizations = new List<Organization>();

        public static void LoadData()
        {
            if (File.Exists("data.json"))
            {
                string json = File.ReadAllText("data.json");
                Organizations = JsonConvert.DeserializeObject<List<Organization>>(json);
            }
        }

        public static void SaveData()
        {
            string json = JsonConvert.SerializeObject(Organizations, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("data.json", json);
        }
    }
}

