using Produccion808xHz.models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Produccion808xHz.services
{
    internal class ClientService
    {
        private readonly JsonStorageService _storage;

        public ClientService(JsonStorageService storage)
        {
            _storage = storage;
        }

        public List<Client> GetClients(string path)
        {
            try
            {
                return _storage.Load<List<Client>>(path);
            }
            catch (FileNotFoundException)
            {
                return new List<Client>();
            }
        }

        public void SaveClients(string path, List<Client> clients)
        {
            _storage.Save(path, clients);
        }
    }
}
