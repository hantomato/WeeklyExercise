using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13779
/// </summary>
namespace WeeklyExercise.topcorder.srm659
{

    class FilipTheFrog
    {

        int countReachableIslands(int[] positions, int L)
        {
            var low = positions.Where(x => x <= positions[0]);
            var high = positions.Where(x => x >= positions[0]);
            low = low.OrderByDescending(x => x);                    // ex) 17, 14, 10, 5, 3, 2, 1
            high = high.OrderBy(x => x);                            // ex) 17, 22

            int lowCount = GetCount<int>(low, L);
            int highCount = GetCount<int>(high, L);
            return 1 + lowCount + highCount;
        }

        int GetCount<T>(IEnumerable<int> input, int L)
        {
            return input.ToObservable()
                .Buffer(2, 1)
                .Where(x => x.Count > 1)    // ex) (17,14), (14,10), (10,5), (5,3), (3,2), (2,1)
                .Select(x => x.Aggregate((a, b) => Math.Abs(a - b)))  // ex) 3, 4, 5, 2, 1, 1
                .TakeWhile(x => x <= L)     // ex) 3,4
                .Count()
                .First();
        }

        public void doing()
        {
            Console.WriteLine("3, " + countReachableIslands(new int[] { 4, 7, 1, 3, 5 }, 1));
            Console.WriteLine("5, " + countReachableIslands(new int[] {100, 101, 103, 105, 107 }, 2));
            Console.WriteLine("7, " + countReachableIslands(new int[] { 17, 10, 22, 14, 6, 1, 2, 3 }, 4));
            Console.WriteLine("1, " + countReachableIslands(new int[] {0}, 1000));
            Console.WriteLine("3, " + countReachableIslands(new int[] { 17, 10, 22, 14, 5, 1, 2, 3 }, 4));
        }
    }

}
