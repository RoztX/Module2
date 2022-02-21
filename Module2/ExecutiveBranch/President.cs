using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class President : ExecutiveBranch
    {
        public President(int corruption, int executionOfObligations, int residentialSupport, string name)
        {
            Corruption = corruption;
            ExecutionOfObligations = executionOfObligations;
            ResidentialSupport = residentialSupport;
            Rating = (executionOfObligations + residentialSupport - corruption) / 2;
            Rank = "President";
            Name = name;
        }

        public int ResidentialSupport { get; set; }
    }
}
