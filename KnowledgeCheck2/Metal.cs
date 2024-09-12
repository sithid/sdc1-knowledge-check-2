using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Metal
    {
        public string Name {  get; set; } = string.Empty;

        public Metal() : this("unknown") {}

        public Metal( string name ) {
            Name = name;
        }
    }
}
