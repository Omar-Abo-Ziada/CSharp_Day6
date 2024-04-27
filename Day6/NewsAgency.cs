using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class NewsAgency
    {
        public event Action<object, NewsEventArgs> NewsAdded;
        //public event EventHandler<NewsEventArgs> NewsAdded;

        public void AddNews(string news)
        {
            if (NewsAdded == null)
                return;

            NewsAdded(this, new NewsEventArgs
            {
                News = news,
                Date = DateTime.Now
            });
        }
    }

    class NewsEventArgs : EventArgs
    {
        public string News { get; set; }
        public DateTime Date { get; set; }
    }
}
