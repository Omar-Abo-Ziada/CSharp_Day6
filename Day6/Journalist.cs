using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Journalist
    {
        public void NewsArrived(object sender, NewsEventArgs args)
        {
            if (sender is NewsAgency)
                Console.WriteLine($"Journalist - From Agency: {args}");
            else if (sender is Magazine)
                Console.WriteLine($"Journalist - From Magazine: {args}");
        }
    }
}
