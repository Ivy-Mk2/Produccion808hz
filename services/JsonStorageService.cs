using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Produccion808xHz.services
{
    internal class JsonStorageService
    {
        public void Save<T>(string path, T data)
        {
            var dir = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(dir))
                Directory.CreateDirectory(dir);

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public T Load<T>(string path) where T : new()
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Archivo no encontrado: " + path);

            var json = File.ReadAllText(path);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true
            };

            var obj = JsonSerializer.Deserialize<T>(json, options);
            if (obj == null)
                return new T();
            else
                return obj;
        }



    }
}
