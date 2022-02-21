using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class SortList : ISortList
    {
        public void Sort(Government[] array, int typeOfSort)
        {
            switch (typeOfSort)
            {
                case 1:
                    SortDescending(array);
                    break;
                case 2:
                    SortAscending(array);
                    break;
            }
        }

        public void SortAscending(Government[] array)
        {
            Government conteiner;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i].Rating < array[j].Rating)
                    {
                        conteiner = array[i];
                        array[i] = array[j];
                        array[j] = conteiner;
                    }
                }
            }
        }

        public void SortDescending(Government[] array)
        {
            Government conteiner;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i].Rating > array[j].Rating)
                    {
                        conteiner = array[i];
                        array[i] = array[j];
                        array[j] = conteiner;
                    }
                }
            }
        }
    }
}