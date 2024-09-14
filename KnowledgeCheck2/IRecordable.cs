using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public interface IRecordable
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }

        public abstract void Load(StreamReader reader);
        public abstract void Save(StreamWriter writer);
    }
}
