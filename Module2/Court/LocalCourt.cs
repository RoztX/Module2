using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class LocalCourt : Court
    {
        public LocalCourt(int independence, int corruption, int justice, string name)
        {
            Independence = independence;
            Corruption = corruption;
            Justice = justice;
            Rating = (independence + justice - corruption) / 2;
            Rank = "LocalCourt";
            Name = name;
        }

        public int Justice { get; set; }
    }
}
