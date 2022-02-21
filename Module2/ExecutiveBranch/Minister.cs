using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class Minister : ExecutiveBranch
    {
        public Minister(int corruption, int executionOfObligations, int sphereDevelopment, string name)
        {
            Corruption = corruption;
            ExecutionOfObligations = executionOfObligations;
            SphereDevelopment = sphereDevelopment;
            Rating = (executionOfObligations + sphereDevelopment - corruption) / 2;
            Rank = "Minister";
            Name = name;
        }

        public int SphereDevelopment { get; set; }
    }
}