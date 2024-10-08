﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;

namespace KnowledgeCheck2
{
    public abstract class RecordLibrary<T>
        where T: IRecord
    {
        public Dictionary<string, T> Records { get; set; }

        public int TotalRecords { get { return Records.Count; } }

        public string FileName { get; set; }

        public  virtual void Initialize() {
            Records = new Dictionary<string, T>();

            LoadRecords();
        }

        public virtual T FindRecord(string uniqueId)
        {
            if (Records.ContainsKey(uniqueId))
                return Records[uniqueId];
            else
                return default(T);
        }

        public virtual void AddRecord(T record)
        {
            Records.Add(record.UniqueId, record);
        }

        public virtual bool RemoveRecord(string key)
        {
            if (Records.ContainsKey(key))
            {
                Records.Remove(key);
                return true;
            }

            return false;
        }

        public virtual bool DisplayRecord( string uniqueId) {
            if (Records.ContainsKey(uniqueId))
            {
                T record = Records[uniqueId];

                Console.WriteLine($"Record Id: {record.UniqueId}");
                Console.WriteLine($"Record Name: {record.Name}");
                Console.WriteLine($"Record Description: {record.Description}");
                Console.WriteLine($"Record Added By: {record.AddedBy}");
                return true;
            }
            else
            {
                Console.WriteLine("That record does not exist.");
                return false;
            }
        }

        public virtual void DisplayAllRecords() {
            foreach( var record in Records)
            {
                DisplayRecord(record.Key);
                Console.WriteLine();
            }
        }

        public virtual void LoadRecords()
        {
            if (!File.Exists(FileName))
                SaveRecords();

            using (StreamReader reader = new StreamReader(FileName))
            {
                while (!reader.EndOfStream)
                {
                    T record = Activator.CreateInstance<T>();

                    record.Load(reader);

                    Records.Add(record.UniqueId, record);
                }

                reader.Close();
            }
        }

        public virtual void SaveRecords()
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                foreach( KeyValuePair<string, T> record in Records )
                {
                    record.Value.Save(writer);
                }

                writer.Close();
            }
        }

        public virtual T InitializeRecord()
        {
            T record = Activator.CreateInstance<T>();

            Console.Write("Name: ");
            record.Name = Console.ReadLine();

            Console.Write("What is this records unique identifier: ");
            record.UniqueId = Console.ReadLine();

            Console.Write("Description: ");
            record.Description = Console.ReadLine();

            Console.Write("Record Added By: ");
            record.AddedBy = Console.ReadLine();

            return record;
        }
    }
}
