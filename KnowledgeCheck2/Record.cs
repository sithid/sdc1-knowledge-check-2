using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Record : IRecordable
    {
        public string Name { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AddedBy { get; set; }

        public Record() { }

        public void Load( StreamReader reader )
        {
            try
            {
                string line = reader.ReadLine();
                List<string> values = line.Split(",").ToList();

                this.Name = values[0];
                this.Id = values[1];
                this.Description = values[2];
                this.AddedBy = values[3];
            }
            catch( Exception e ) { }
        }

        public void Save(StreamWriter writer)
        {
            try
            {
                writer.WriteLine($"{Name},{Id},{Description},{AddedBy}");
            }
            catch( Exception e ) { }
        }

        public override string ToString()
        {
            return $"{Name},{Id},{Description},{AddedBy}";
        }
    }
}
