using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public enum State
    {
        Unknown = 0,
        Solid,
        Liquid,
        Gas,
        Plasma
    }

    public class Mixture
    {
        public string Name { get; set; } = string.Empty;
        public decimal Weight { get; set; } = 0.0M;
        public string Description { get; set; } = string.Empty;
        public State State { get; set; } = State.Unknown;
        public bool IsHazardous { get; set; } = false;

        public Mixture() { }
    }
}
