using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13678
/// </summary>
namespace WeeklyExercise.topcorder.srm652
{
    class ValueOfString
    {
        // ex) 2*4 + 1*2 + 2*4 + 3*5 + 1*2 = 35
        public int findValue(String s)
        {
            byte[] input = Encoding.UTF8.GetBytes(s);
            int sum = 0;
            for (int i=0; i<input.Length; ++i)
                sum = sum + getValue(input, input[i]);

            return sum;
        }

        private int getValue(byte[] src, byte target)
        {
            int firstValue = target - 'a' + 1;
            int order = 0;
            for (int i=0; i<src.Length; ++i)
            {
                order += (target >= src[i] ? 1 : 0);
            }

            return firstValue * order;
        }

        public void doing()
        {
            print(findValue("babca"));
            print(findValue("zz"));
            print(findValue("y"));
            print(findValue("aaabbc"));
            print(findValue("topcoder"));
            print(findValue("thequickbrownfoxjumpsoverthelazydog"));
            print(findValue("zyxwvutsrqponmlkjihgfedcba"));
            // result
            //35
            //104
            //25
            //47
            //558
            //11187
            //6201
        }

        public void print(int text)
        {
            Logger.log("return: " + text);
        }
    }

}
