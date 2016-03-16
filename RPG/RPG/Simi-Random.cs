using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Simi_Random
    {
        // Gives a number out of the List of numbers to simulate true randomness. //
        int i;
        public int rNum()
        {
            List<int> Troll2 = new List<int> { 10, 4, 7, 10, 9, 8, 3, 6, 10, 4, 6, 11, 6, 11, 4, 8, 8, 7, 9, 6 };
            i++;
            if (i > Troll2.Count)
            { i = 0; }
            return Troll2[i];
        }
    }
}
