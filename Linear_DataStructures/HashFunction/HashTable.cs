using System.Collections.Generic;
namespace Linear_DataStructures
{
    public class HashTable
    {
        public class Entry
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }
        int size = 5;
        internal LinkedList<Entry>[] entries = new LinkedList<Entry>[5];


        public void put(int key, string value)
        {
            var index = Hash(key);
            if (entries[index] == null)
            {
                entries[index] = new LinkedList<Entry>();
            }
            Entry entry = new Entry() { Key = key, Value = value };

            var bucket=entries[index];
            foreach (var e in bucket)
            {
                if (e.Key == key)
                {
                    e.Value = value;
                    return;
                }
                
            }
            bucket.AddLast(entry); // if key check is not present then same key with multiple values
                
        }
        public string get(int key)
        {
            var index = Hash(key);
            var bucket=entries[index];
           foreach (var e in bucket)
            {
                if (e.Key == key)
                {
                    return e.Value;
                }
                
            }
            return null;
        }

        private int Hash(int key)
        {
            return key % size;
        }

        public static void DriverCode()
        {
            HashTable hs = new HashTable();
            hs.put(6, "A");
            hs.put(6, "B");
            System.Console.WriteLine(hs.get(6));
            
        }
    }
}