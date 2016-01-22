using System;
using System.Linq;
using System.Reactive.Linq;

/// <summary>
/// public static IObservable<IList<TSource>> Buffer<TSource>(this IObservable<TSource> source, int count, int skip);
/// { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}
/// count:5, skip 3 인 경우 결과는 아래와 같음.
/// => {1,2,3,4,5}, {4,5,6,7,8}, {7,8,9,10,11}, {10,11,12,13,14}, {13,14,15}
/// </summary>
namespace WeeklyExercise.topcorder.srm646
{
    class TheConsecutiveIntegersDivTwo_rx
    {
        public int find(int[] numbers, int k)
        {

            if (k == 1)
                return 0;

            Array.Sort(numbers);
            return numbers.ToObservable()
                .Buffer(2, 1)
                //.SkipLast(1)
                .Where(x => x.Count == 2)
                .Select(x => Math.Abs(x[0] - x[1]) - 1)
                .Min()
                .First();
        }

        public void doing()
        {

            Logger.log(find(new int[] { 4, 47, 7 }, 2));
            Logger.log(find(new int[] { 1, 100 }, 1));
            Logger.log(find(new int[] { -96, -53, 82, -24, 6, -75 }, 2));
            Logger.log(find(new int[] { 64, -31, -56 }, 2));
            //2
            //0
            //20
            //24
        }

        public void print(int n)
        {
            Logger.log("return: " + n);
        }
    }
}
