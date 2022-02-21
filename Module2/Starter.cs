using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    internal class Starter
    {
        private readonly ListOfGovernment _listOfGovernment;
        private readonly IOutputList _output;
        private readonly ISortList _sortList;
        private readonly ISummarizing _summarizing;
        private readonly IGetFromConsole _getFromConsole;

        public Starter(IOutputList output, ISortList sortList, ISummarizing summarizing, IGetFromConsole getFromConsole)
        {
            _listOfGovernment = new ListOfGovernment();
            _output = output;
            _sortList = sortList;
            _summarizing = summarizing;
            _getFromConsole = getFromConsole;
        }

        public void Run()
        {
            _output.Outut(_listOfGovernment.GovernmentList);
            Console.WriteLine("Choose a sort type:\n1.Rating ascending\n2.Descending ranking");
            int sortOptions = 2;
            int typeOfSort = _getFromConsole.Get(sortOptions);
            _sortList.Sort(_listOfGovernment.GovernmentList, typeOfSort);
            _output.Outut(_listOfGovernment.GovernmentList);
            _summarizing.Outcome(_listOfGovernment.GovernmentList);
        }
    }
}
