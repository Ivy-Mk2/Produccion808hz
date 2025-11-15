using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produccion808xHz.services.DataStructures
{
    internal class HashTableT<TKey, TValue>
    {
        private class Entry
        {
            public TKey Key;
            public TValue Value;

        }

        private List<Entry>[] buckets;
        private int size;

        public HashTableT(int capacity = 10)
        {
            buckets = new List<Entry>[capacity];
            for (int i = 0; i < capacity; i++)
                buckets[i] = new List<Entry>();
            size = capacity;
        }

        private int Hash(TKey key)
        {
            return Math.Abs(key.GetHashCode()% size);
        }

        public void Put(TKey key, TValue value)
        {
            int index = Hash(key);
            foreach(var  entry in buckets[index])
            {
                if (entry.Key.Equals(key))
                {
                    entry.Value = value; 
                    return;
                }
            }

            buckets[index].Add(new Entry { Key = key, Value = value });
        }

        public bool TryGet(TKey key, out TValue value)
        {
            value = default(TValue);
            int index = Hash(key);
            foreach (var entry in buckets[index])
            {
                if (entry.Key.Equals(key))
                {
                    value = entry.Value;
                    return true;
                }
            }
            return false;
        }
    }
}
