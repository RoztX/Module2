using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class ListOfGovernment
    {
        public Government[] GovernmentList { get; set; } =
        {
           new President(1, 87, 78, "Maxim"),
           new Minister(5, 100, 70, "Ivan"),
           new Minister(2, 50, 50, "Efim"),
           new Minister(40, 60, 70, "Abdula"),
           new SupremeCourt(100, 5, 100, "Nik"),
           new LocalCourt(88, 15, 85, "Kostya"),
           new Deputy(0, 100, 0, "Ostap"),
           new Deputy(20, 90, 10, "Kristy"),
           new Deputy(30, 50, 20, "Emillio"),
           new Deputy(40, 20, 30, "Alehandro"),
           new Deputy(50, 10, 50, "Sofia")
        };
    }
}
