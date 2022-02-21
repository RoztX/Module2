using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class Deputy : Legislature
    {
        public Deputy(int corruption, int havingIdeas, int lackOfLobbying, string name)
        {
            Corruption = corruption;
            HavingIdeas = havingIdeas;
            LackOfLobbying = lackOfLobbying;
            Rating = (havingIdeas + lackOfLobbying - corruption) / 2;
            Rank = "Deputy";
            Name = name;
        }

        public int LackOfLobbying { get; set; }
    }
}
