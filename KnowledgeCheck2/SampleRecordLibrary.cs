using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class SampleRecordLibrary<T> : RecordLibrary<T> where T : Record
    {
        public SampleRecordLibrary() {
            Initialize();
        }

        public override void Initialize() {
            FileName = "sample_records.txt";
            base.Initialize();
        }

        public override void DisplayRecord(string uniqueId) {
            T record = FindRecord(uniqueId);

            base.DisplayRecord(record.Id);

            Console.WriteLine($"Record Added By: {record.AddedBy}");
        }

        public override T InitializeRecord() {
            T record = base.InitializeRecord();

            Console.Write("Record Added By: ");
            record.AddedBy = Console.ReadLine();

            return (T)record;
        }
    }
}
