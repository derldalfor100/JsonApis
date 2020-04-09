using JsonApis.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace JsonApis.Services
{
    public class JsonReader: IJsonReader
    {
        public T GetSerializedJSON<T>(string url) where T : new()
        {
            using (var x = new WebClient())
            {
                var json_data = string.Empty;

                try
                {
                    json_data = x.DownloadString(url);
                }
                catch (Exception)
                {

                    throw;
                }

                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }
}
