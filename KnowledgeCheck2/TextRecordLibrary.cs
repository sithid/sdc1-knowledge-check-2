using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class TextRecordLibrary<T> : RecordLibrary<T> where T : TextRecord
    {
        public TextRecordLibrary() {
            Initialize();
        }

        public override void Initialize() {
            FileName = "sample_records.txt";
            base.Initialize();
        }

        public override T InitializeRecord() {
            T record = base.InitializeRecord();

            Console.Write("Text Content: ");
            record.Content = Console.ReadLine();

            return (T)record;
        }

        public override void DisplayRecord(string uniqueId)
        {
            base.DisplayRecord(uniqueId);

            if (Records.ContainsKey(uniqueId))
                Console.WriteLine($"Record Content: {Records[uniqueId].Content}");
            else
                Console.WriteLine("That record does not exist.");
        }

        public void DisplayAllContent()
        {
            foreach( var record in Records)
            {
                Console.WriteLine(record.Value.Content);
            }

            Console.WriteLine();
        }
    }
}
