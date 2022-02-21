using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class SupremeCourt : Court
    {
        public SupremeCourt(int independence, int corruption, int constitutionalСompliance, string name)
        {
            Independence = independence;
            Corruption = corruption;
            ConstitutionalСompliance = constitutionalСompliance;
            Rating = (independence + constitutionalСompliance - corruption) / 2;
            Rank = "SupremeCourt";
            Name = name;
        }

        public int ConstitutionalСompliance { get; set; }
    }
}
