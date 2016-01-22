using System;
using System.Linq;
using System.Reactive.Linq;

namespace WeeklyExercise.topcorder.srm646
{
    class srm646_rx
    {
        public static void find(int[] numbers, int k)
        {
            //if (k == 1) return 0;

            //int res = 10000001;
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length - 1; ++i)
            //{
            //    res = Math.Min(res, numbers[i + 1] - numbers[i]);
            //}
            //return res - 1;

            //IObservable<int> obs = numbers.

            //numbers.ToObservable()
            //        .Select(x => x * 2).Subscribe(Console.WriteLine);

            //IObservable<int> obs = Observable.ToObservable<int>();

            if (k == 1)
            {
                Observable.Return<int>(1)
                    .Subscribe(x => Logger.log(x.ToString()));
            } else {
                numbers.ToObservable()
                    .Aggregate((x, y) => Math.Min(x, y))
                    .Subscribe(x => Logger.log(x.ToString()));
            }
        }

        public void doing()
        {
            find(new int[] { 4, 47, 7 }, 2);
            find(new int[] { 1, 100 }, 1);
            find(new int[] { -96, -53, 82, -24, 6, -75 }, 2);
            find(new int[] { 64, -31, -56 }, 2);
            //return: 2
            //return: 1
            //return: 20
            //return: 24
        }

        public void print(int n)
        {
            Logger.log("return: " + n);
        }
    }
}
