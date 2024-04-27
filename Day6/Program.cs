using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    delegate bool MyDelegate<T>(T num);
    delegate bool MyOtherDelegate(int num);
    delegate bool MyModifiedDelegate(int num, string s);
    internal class Program
    {
        static bool IsPositive(int num)
        {
            return num > 0;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static void Filter<T>(List<T> items, Predicate<T> del)//MyDelegate<T> del)
        {
            foreach (T item in items)
            {
                if (del(item))
                    Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            #region Delegates
            //List<int> list = new List<int> { 1, 2, -3, -4, 5, -6, 7, 8, 9 };

            //MyDelegate<int> delPositive = new MyDelegate<int>(IsPositive);
            //MyDelegate<int> delEven = IsEven; //new MyDelegate(IsEven);

            //bool flag = delEven(5); //delEven.Invoke(5);
            //Filter(list, delEven);
            //Filter(list, IsEven);

            //delEven = IsPositive;

            //MyDelegate del = Helper.IsNeative;

            //Helper helper = new Helper();
            //MyDelegate del = helper.IsOdd;

            //Filter(list, delegate (int num)
            //{
            //    return num > 0;
            //});

            //Filter(list, num => num > 0);
            //Filter(list, num => num > 0 && num < 10);

            //Predicate<string> del = str => str.Length > 10 ;

            //Func<int> del = () => list[0];
            //Func<int, string> del = x => x.ToString();

            //Action<int> del = x => Console.WriteLine(x);
            //Action del = () => Console.WriteLine("hi");

            //MyDelegate<int> del = IsEven;

            //del += IsPositive;
            //del += Helper.IsNeative;
            //del += x => x < 100;

            //bool flag = del(5);
            //del -= IsPositive; 
            #endregion

            Journalist journalist = new Journalist();
            Magazine magazine = new Magazine();
            NewsAgency newsAgency = new NewsAgency();

            newsAgency.AddNews("Zamalek has been defeated yesterday");

            newsAgency.NewsAdded += journalist.NewsArrived;
            newsAgency.NewsAdded += magazine.NewsIsHere;

            magazine.NewsCreated += journalist.NewsArrived;

            //newsAgency.NewsAdded = magazine.NewsIsHere;
            //newsAgency.NewsAdded = null;

            newsAgency.AddNews("Al-Ahly will win today ISA");

        }
    }
}
