using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class TextRecord : IRecord 
    {
        public string Name { get; set; } = string.Empty;
        public string UniqueId { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AddedBy { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public TextRecord() { }

        public void Load( StreamReader reader )
        {
            try
            {
                string recordString = reader.ReadLine();
                List<string> recordData = recordString.Split(",").ToList();

                this.Name = recordData[0];
                this.UniqueId = recordData[1];
                this.Description = recordData[2];
                this.AddedBy = recordData[3];
                this.Content = recordData[4];
            }
            catch( Exception e ) { }
        }

        public void Save(StreamWriter writer)
        {
            try
            {
                writer.WriteLine(this.ToString());
            }
            catch( Exception e ) { }
        }

        public override string ToString()
        {
            return $"{Name},{UniqueId},{Description},{AddedBy},{Content}";
        }
    }
}
