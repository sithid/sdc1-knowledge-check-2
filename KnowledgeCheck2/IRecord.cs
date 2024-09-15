using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public interface IRecord
    {
        public string Name { get; set; }
        public string UniqueId { get; set; }
        public string Description { get; set; }
        public string AddedBy { get; set; }

        public abstract void Load(StreamReader reader);
        public abstract void Save(StreamWriter writer);
    }
}
