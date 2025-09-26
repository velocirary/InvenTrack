using System.IO;
using Newtonsoft.Json;

namespace InvenTrack.Configuration
{
    public class Config
    {
        public string SmtpEmail { get; set; }
        public string SmtpPassword { get; set; }
        public string DbPath { get; set; }

        public static Config Load(string path = "config.json")
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Arquivo de configuração não encontrado: {path}");

            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(path));
        }
    }
}
