using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class GetFromConsole : IGetFromConsole
    {
        public int Get(int number)
        {
            int contain;
            while (true)
            {
                try
                {
                    contain = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    contain = 0;
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    contain = 0;
                    continue;
                }

                if (contain > 0 && contain <= number)
                {
                    break;
                }

                Console.WriteLine("Invalid value entered");
            }

            return contain;
        }
    }
}
