using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class Summarizing : ISummarizing
    {
        public void Outcome(Government[] array)
        {
            var indexMinRating = 0;
            var indexMaxRating = 0;
            var overallRating = 0;
            for (int i = 0; i < array.Length; i++)
            {
                overallRating += array[i].Rating;
                if (array[i].Rating > array[indexMaxRating].Rating)
                {
                    indexMaxRating = i;
                }

                if (array[i].Rating < array[indexMinRating].Rating)
                {
                    indexMinRating = i;
                }
            }

            overallRating /= array.Length;
            Console.WriteLine($"The highest rating: {array[indexMaxRating].GetType().ToString().Substring(8)}({array[indexMaxRating].Rating}%)");
            Console.WriteLine($"The lowest rating: {array[indexMinRating].GetType().ToString().Substring(8)}({array[indexMinRating].Rating}%)");
            Console.WriteLine($"Overall rating: {overallRating}%");
        }
    }
}