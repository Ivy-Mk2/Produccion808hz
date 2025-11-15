using Produccion808xHz.models;
using Produccion808xHz.services.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Produccion808xHz.services
{
    internal class UserService
    {
        private readonly JsonStorageService _storage;
      

        public UserService(JsonStorageService storage)
        {
            _storage = storage;
          
        }

      public List<User> GetUsers(string path)
        {
            return _storage.Load<List<User>>(path);
        }

        public HashTableT<string, User> BuildHash(string path)
        {
            var users = GetUsers(path);
            var table = new HashTableT<string, User>();
            foreach (var u in users)
            {
                if (!string.IsNullOrEmpty(u.UserName))
                    table.Put(u.UserName, u);
            }
            return table;
        }
    }
}
