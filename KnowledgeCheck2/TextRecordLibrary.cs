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
            FileName = "text_records.txt";
            base.Initialize();
        }

        public override T InitializeRecord() {
            T record = base.InitializeRecord();

            Console.Write("Text Content: ");
            record.Content = Console.ReadLine();

            return (T)record;
        }

        public override bool DisplayRecord(string uniqueId)
        {
            bool exists = base.DisplayRecord(uniqueId);

            if (exists)
            {
                Console.WriteLine($"Record Content: {Records[uniqueId].Content}");
                return true;
            }

            return false;
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
