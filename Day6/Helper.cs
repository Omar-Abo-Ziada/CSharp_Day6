using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Helper
    {
        public bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        public static bool IsNeative(int num)
        {
            return num < 0;
        }
    }
}
