using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Magazine
    {
        public event Action<object, NewsEventArgs> NewsCreated;
        public void NewsIsHere(object sender, NewsEventArgs item)
        {
            Console.WriteLine($"Magazine: {item.News}");

            if (NewsCreated == null)
                return;

            NewsCreated(this, item);
        }
    }
}
