using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class OutputList : IOutputList
    {
        public void Outut(Government[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"N{i + 1}\tName:{array[i].Name}\tRank:{array[i].Rank}\tRating:{array[i].Rating}%");
            }
        }
    }
}
