using System;
using System.Collections.Generic;
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
    class PeacefulLine_rx
    {
        public string makeLine(int[] x)
        {
            int validMaxValue = x.Length / 2 + x.Length % 2;    // 허용하는 같은 나이를 갖는 학생 수
            Dictionary<int, int> dicCateAge = categorizeAge(x);
            return checkMaxValue(dicCateAge, validMaxValue);
        }

        private Dictionary<int, int> categorizeAge(int[] x)
        {
            var temp = new Dictionary<int, int>();
            foreach (int n in x)
            {
                if (temp.ContainsKey(n))
                    ++temp[n];
                else
                    temp[n] = 1;
            }
            return temp;
        }

        private string checkMaxValue(Dictionary<int, int> dicCateAge, int validMaxValue)
        {
            foreach (int age in dicCateAge.Keys)
            {
                if (dicCateAge[age] > validMaxValue)
                    return "impossible";
            }
            return "possible";
        }

        public void doing()
        {
            print(makeLine(new int[] { 1, 2, 3, 4 }));
            print(makeLine(new int[] { 1, 1, 1, 2 }));
            print(makeLine(new int[] { 1, 1, 2, 2, 3, 3, 4, 4 }));
            print(makeLine(new int[] { 3, 3, 3, 3, 13, 13, 13, 13 }));
            print(makeLine(new int[] { 3, 7, 7, 7, 3, 7, 7, 7, 3 }));
            print(makeLine(new int[] { 25, 12, 3, 25, 25, 12, 12, 12, 12, 3, 25 }));
            print(makeLine(new int[] { 3, 3, 3, 3, 13, 13, 13, 13, 3 }));
            //possible
            //impossible
            //possible
            //possible
            //impossible
            //possible
            //possible

        }

        public void print(string text)
        {
            Logger.log("return: " + text);
        }
    }
}
