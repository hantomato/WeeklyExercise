using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// week1
/// https://community.topcoder.com/stat?c=problem_statement&pm=13604&rd=16277
/// </summary>
namespace WeeklyExercise.topcorder.srm645
{

    class BacteriesColony
    {

        public static int[] performTheExperiment(int[] colonies)
        {
            bool changed = true;
            while (changed)
            {
                changed = false;

                int[] temp = new int[colonies.Length];
                Array.Copy(colonies, temp, colonies.Length);

                for (int i=1; i< (temp.Length - 1); ++i)
                {
                    if (colonies[i] < colonies[i-1] && colonies[i] < colonies[i+1])
                    {
                        ++temp[i];
                        changed = true;
                    } else if (colonies[i] > colonies[i - 1] && colonies[i] > colonies[i + 1])
                    {
                        --temp[i];
                        changed = true;
                    }
                }

                colonies = temp;

            }


            return colonies;
        }

        public void doing()
        {
            print(performTheExperiment(new int[] { 5, 3, 4, 6, 1 }));
            print(performTheExperiment(new int[] { 1, 5, 4, 9 }));
            print(performTheExperiment(new int[] { 78, 34, 3, 54, 44, 99 }));
            print(performTheExperiment(new int[] { 32, 68, 50, 89, 34, 56, 47, 30, 82, 7, 21, 16, 82, 24, 91 }));

            //output
            //{5,4,4,4,1}
            //{1,4,5,9}
            //{78,34,34,49,49,99}
            //{32,59,59,59,47,47,47,47,47,18,18,19,53,53,91}
        }

        public void print(int[] input)
        {
            Logger.log("{" + string.Join(",", input) + "}");
        }

    }
}
