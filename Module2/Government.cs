using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public abstract class Government
    {
        public int Corruption { get; set; }

        public int Rating { get; set; }

        public string? Name { get; set; }

        public string? Rank { get; set; }
    }
}
