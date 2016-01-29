using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13632&rd=16279
/// </summary>
namespace WeeklyExercise.topcorder.srm646
{
    class PeacefulLine
    {
        public string makeLine(int[] x)
        {
            int mostAgeCount = x.Length / 2 + x.Length % 2;
            Dictionary<int, int> dicCateAge = categorizeAge(x);
            return checkPossible(mostAgeCount, dicCateAge);
        }

        private Dictionary<int, int> categorizeAge(int[] x)
        {
            var temp = new Dictionary<int, int>();
            foreach(int n in x)
            {
                if (temp.ContainsKey(n))
                    ++temp[n];
                else
                    temp[n] = 1;
            }
            return temp;
        }
        private string checkPossible(int mostAgeCount, Dictionary<int, int> dicCateAge)
        {
            foreach (int age in dicCateAge.Keys)
            {
                if (mostAgeCount < dicCateAge[age])
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
