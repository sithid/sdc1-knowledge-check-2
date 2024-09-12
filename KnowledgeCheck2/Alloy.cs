using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Alloy : Metal
    {
        public bool ContainsIron {  get; set; } = false;

        public Alloy(){ }

        public override string ToString()
        {
            if (ContainsIron)
                return $"{Name}:Ferrous";
            else
                return $"{Name}:Non-Ferrous";
        }
    }
}
