using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13650&rd=16312
/// 
/// ex 1)
/// 150
/// 1050
/// 이라면. 
/// 
/// 1050 - (150 * 2의 0승 = 150) = 900    - first
/// 900  - (150 * 2의 1승 = 300) = 600    - second
/// 600  - (150 * 2의 2승 = 600) = 0.     - third
/// 총 3번 뺏으니, 3개 살수 있다.
/// 
/// ex 2)
/// 160
/// 163680
/// 이라면.
/// 
/// 163680 -    160 =   163520      first
/// 163520 -    320 =   163200      2
/// 163200 -    640 =   162560      3
/// 162560 -    1280 =  161280      4
/// 161280 -    2560 =  158720      5
///             5120  = 153600      6
///             10240 = 143360      7
///             20480 = 122880      8
///             40960 = 81920       9
///             81920 = 0           10
/// 즉 10개 살수 있다.
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
            return naturalNumbers.ToObservable()
                .TakeWhile(x => x <= T)     // emit : 160, 320, 640 .. 81920 총 10개
                .Scan((x, y) => x + y)      // emit : 160, 480, 1120 .. 163680 총 10개
                .Where(x => x <= T)         // emit : 160, 480, 1120 .. 163680 총 10개
                .Count()                    //
                .First();
        }

        public void doing()
        {
            print(numBought(100, 100));
            print(numBought(100, 300));
            print(numBought(150, 1050));
            print(numBought(160, 163680));
            //1
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
