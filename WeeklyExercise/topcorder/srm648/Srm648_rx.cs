using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13650&rd=16312
/// </summary>
namespace WeeklyExercise.topcorder.srm648
{
    class KitayutaMart2_rx
    {
        public static IEnumerable<T> Unfold<T>(T seed, Func<T, T> accumulator)
        {
            var nextValue = seed;
            while (true)
            {
                yield return nextValue;
                nextValue = accumulator(nextValue);
            }
        }

        public int numBought(int K, int T)
        {
            var naturalNumbers = Unfold(K, i => i * 2);
            return naturalNumbers.ToObservable()        // emit : 150, 300, 600, 1200 ...
                            .TakeWhile(x => x <= T)     // emit : 150, 300, 600 
                            .Scan((x, y) => x + y)      // emit : 150, 450, 1050
                            .Where(x => x <= T)         // emit : 150, 450, 1050
                            .Count()                    // emit : 3
                            .First();
        }

        public void doing()
        {
            print(numBought(100, 100));
            print(numBought(100, 300));
            print(numBought(150, 1050));
            print(numBought(150, 1049));
            print(numBought(150, 1051));
            print(numBought(160, 163680));
            //1
            //2
            //3
            //2
            //3
            //10

        }

        public void print(int text)
        {
            Logger.log("return: " + text);
        }
    }

}
